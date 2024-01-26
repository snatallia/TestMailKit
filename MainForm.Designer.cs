namespace TestMailKit
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRead = new Button();
            tbIMAPServer = new TextBox();
            lblIMAPServer = new Label();
            lblIMAPPort = new Label();
            tbIMAPPort = new TextBox();
            lblUsername = new Label();
            tbUsername = new TextBox();
            lblPassword = new Label();
            tbPassword = new TextBox();
            tbSubject = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbDate = new TextBox();
            btnClear = new Button();
            btnReadAndDelete = new Button();
            lblFrom = new Label();
            tbFrom = new TextBox();
            tbContent = new TextBox();
            lblContent = new Label();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.Location = new Point(80, 413);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(679, 58);
            btnRead.TabIndex = 0;
            btnRead.Text = "Read and move to trash";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_ClickAsync;
            // 
            // tbIMAPServer
            // 
            tbIMAPServer.Location = new Point(313, 79);
            tbIMAPServer.Name = "tbIMAPServer";
            tbIMAPServer.Size = new Size(442, 47);
            tbIMAPServer.TabIndex = 1;
            tbIMAPServer.Text = "imap.yandex.ru";
            // 
            // lblIMAPServer
            // 
            lblIMAPServer.AutoSize = true;
            lblIMAPServer.Location = new Point(80, 79);
            lblIMAPServer.Name = "lblIMAPServer";
            lblIMAPServer.Size = new Size(186, 41);
            lblIMAPServer.TabIndex = 2;
            lblIMAPServer.Text = "IMAP Server:";
            lblIMAPServer.TextAlign = ContentAlignment.TopRight;
            // 
            // lblIMAPPort
            // 
            lblIMAPPort.AutoSize = true;
            lblIMAPPort.Location = new Point(80, 154);
            lblIMAPPort.Name = "lblIMAPPort";
            lblIMAPPort.Size = new Size(79, 41);
            lblIMAPPort.TabIndex = 3;
            lblIMAPPort.Text = "Port:";
            // 
            // tbIMAPPort
            // 
            tbIMAPPort.Location = new Point(313, 151);
            tbIMAPPort.MaxLength = 6;
            tbIMAPPort.Name = "tbIMAPPort";
            tbIMAPPort.Size = new Size(442, 47);
            tbIMAPPort.TabIndex = 4;
            tbIMAPPort.Text = "993";
            tbIMAPPort.KeyPress += tbIMAPPort_KeyPress;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(80, 250);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(159, 41);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username:";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(313, 247);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(442, 47);
            tbUsername.TabIndex = 6;
            tbUsername.Text = "senefishka";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(80, 331);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(150, 41);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password:";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(311, 325);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(448, 47);
            tbPassword.TabIndex = 8;
            tbPassword.Text = "Fishka1234";
            // 
            // tbSubject
            // 
            tbSubject.Location = new Point(1278, 154);
            tbSubject.Name = "tbSubject";
            tbSubject.Size = new Size(896, 47);
            tbSubject.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1092, 151);
            label1.Name = "label1";
            label1.Size = new Size(123, 41);
            label1.TabIndex = 10;
            label1.Text = "Subject:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1128, 253);
            label2.Name = "label2";
            label2.Size = new Size(87, 41);
            label2.TabIndex = 11;
            label2.Text = "Date:";
            // 
            // tbDate
            // 
            tbDate.Location = new Point(1278, 253);
            tbDate.Name = "tbDate";
            tbDate.Size = new Size(893, 47);
            tbDate.TabIndex = 12;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(1896, 524);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(275, 58);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear mail data";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnReadAndDelete
            // 
            btnReadAndDelete.Location = new Point(80, 524);
            btnReadAndDelete.Name = "btnReadAndDelete";
            btnReadAndDelete.Size = new Size(679, 58);
            btnReadAndDelete.TabIndex = 14;
            btnReadAndDelete.Text = "Read and delete";
            btnReadAndDelete.UseVisualStyleBackColor = true;
            btnReadAndDelete.Click += btnReadAndDelete_Click;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(1118, 65);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(94, 41);
            lblFrom.TabIndex = 15;
            lblFrom.Text = "From:";
            // 
            // tbFrom
            // 
            tbFrom.Location = new Point(1278, 62);
            tbFrom.Name = "tbFrom";
            tbFrom.Size = new Size(896, 47);
            tbFrom.TabIndex = 16;
            // 
            // tbContent
            // 
            tbContent.Location = new Point(1278, 354);
            tbContent.Multiline = true;
            tbContent.Name = "tbContent";
            tbContent.Size = new Size(896, 118);
            tbContent.TabIndex = 17;
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.Location = new Point(1092, 354);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(132, 41);
            lblContent.TabIndex = 18;
            lblContent.Text = "Content:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2261, 799);
            Controls.Add(lblContent);
            Controls.Add(tbContent);
            Controls.Add(tbFrom);
            Controls.Add(lblFrom);
            Controls.Add(btnReadAndDelete);
            Controls.Add(btnClear);
            Controls.Add(tbDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbSubject);
            Controls.Add(tbPassword);
            Controls.Add(lblPassword);
            Controls.Add(tbUsername);
            Controls.Add(lblUsername);
            Controls.Add(tbIMAPPort);
            Controls.Add(lblIMAPPort);
            Controls.Add(lblIMAPServer);
            Controls.Add(tbIMAPServer);
            Controls.Add(btnRead);
            Name = "MainForm";
            Text = "Test Mail Kit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRead;
        private TextBox tbIMAPServer;
        private Label lblIMAPServer;
        private Label lblIMAPPort;
        private TextBox tbIMAPPort;
        private Label lblUsername;
        private TextBox tbUsername;
        private Label lblPassword;
        private TextBox tbPassword;
        private TextBox tbSubject;
        private Label label1;
        private Label label2;
        private TextBox tbDate;
        private Button btnClear;
        private Button btnReadAndDelete;
        private Label lblFrom;
        private TextBox tbFrom;
        private TextBox tbContent;
        private Label lblContent;
    }
}