using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Net;
using MailKit.Net.Imap;
using MimeKit;
using Org.BouncyCastle.Asn1.X509;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace TestMailKit
{
    public partial class MainForm : Form
    {
        public string EXT_IMAP_SERVER = "imap.yandex.ru";
        public int EXT_IMAP_PORT = 993;
        public string EXT_USERNAME = "";
        public string EXT_PASSWORD = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private async void btnRead_ClickAsync(object sender, EventArgs e)
        {
            ClearMailDate();
            GetAuthorizationData();           
            await ReadAndMoveToTrashMessageAsync();
        }

        private async void btnReadAndDelete_Click(object sender, EventArgs e)
        {
            ClearMailDate();
            GetAuthorizationData();
            await ReadAndDeleteMessageAsync();
        }



        private async Task ReadAndMoveToTrashMessageAsync()
        {
            using (var client = new ImapClient())
            {
                client.Connect(EXT_IMAP_SERVER, EXT_IMAP_PORT, true);
                client.Authenticate(EXT_USERNAME, EXT_PASSWORD);
                                     
                var inbox = client.Inbox;                
                inbox.Open(FolderAccess.ReadWrite);
                var trash = client.GetFolder(SpecialFolder.Trash);
                var lastUnreadIndex = inbox.FirstUnread;
                var lastMessage = client.Inbox.GetMessage(lastUnreadIndex);

                await inbox.AddFlagsAsync(lastUnreadIndex, MessageFlags.Seen, true);
                await inbox.MoveToAsync(lastUnreadIndex, trash);
                FillMailData(lastMessage);

                client.Disconnect(true);

            }
        }

        private async Task ReadAndDeleteMessageAsync()
        {
            using (var client = new ImapClient())
            {
                client.Connect(EXT_IMAP_SERVER, EXT_IMAP_PORT, true);
                client.Authenticate(EXT_USERNAME, EXT_PASSWORD);

                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadWrite);
                var lastUnreadIndex = inbox.FirstUnread;
                var lastMessage = client.Inbox.GetMessage(lastUnreadIndex);

                await inbox.AddFlagsAsync(lastUnreadIndex, MessageFlags.Deleted, true);
                FillMailData(lastMessage);
                client.Disconnect(true);
            }
        }
       

        private void tbIMAPPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearMailDate();
        }

        private void ClearMailDate()
        {
            tbFrom.Clear();
            tbSubject.Clear();
            tbDate.Clear();
            tbContent.Clear();
        }

        private void GetAuthorizationData()
        {
            EXT_IMAP_SERVER = tbIMAPServer.Text;
            int.TryParse(tbIMAPPort.Text, out EXT_IMAP_PORT);
            EXT_USERNAME = tbUsername.Text;
            EXT_PASSWORD = tbPassword.Text;
        }

        private void FillMailData(MimeMessage msg)
        {
            tbFrom.Text = msg.From.ToString();
            tbSubject.Text = msg.Subject;
            tbDate.Text = msg.Date.Date.ToLongDateString();
            tbContent.Text = msg.TextBody ?? msg.HtmlBody;
        }
    }
}
