namespace TCPServer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSend = new Button();
            txtMesaj = new TextBox();
            label2 = new Label();
            txtInfo = new TextBox();
            btnStart = new Button();
            txtIp = new TextBox();
            label1 = new Label();
            lstClientIp = new ListBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.DeepSkyBlue;
            btnSend.Location = new Point(362, 405);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(130, 46);
            btnSend.TabIndex = 13;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // txtMesaj
            // 
            txtMesaj.Location = new Point(67, 372);
            txtMesaj.Name = "txtMesaj";
            txtMesaj.Size = new Size(584, 27);
            txtMesaj.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 375);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 11;
            label2.Text = "Mesaj:";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(67, 53);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.ScrollBars = ScrollBars.Both;
            txtInfo.Size = new Size(584, 313);
            txtInfo.TabIndex = 10;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Lime;
            btnStart.Location = new Point(521, 405);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(130, 46);
            btnStart.TabIndex = 9;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // txtIp
            // 
            txtIp.Location = new Point(67, 23);
            txtIp.Name = "txtIp";
            txtIp.Size = new Size(149, 27);
            txtIp.TabIndex = 8;
            txtIp.Text = "192.168.106.142:8000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 23);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 7;
            label1.Text = "Server:";
            // 
            // lstClientIp
            // 
            lstClientIp.FormattingEnabled = true;
            lstClientIp.Location = new Point(657, 63);
            lstClientIp.Name = "lstClientIp";
            lstClientIp.Size = new Size(213, 304);
            lstClientIp.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(657, 40);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 15;
            label3.Text = "Client IP:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(900, 491);
            Controls.Add(label3);
            Controls.Add(lstClientIp);
            Controls.Add(btnSend);
            Controls.Add(txtMesaj);
            Controls.Add(label2);
            Controls.Add(txtInfo);
            Controls.Add(btnStart);
            Controls.Add(txtIp);
            Controls.Add(label1);
            Name = "Form1";
            Text = "TCP/IP Server";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private TextBox txtMesaj;
        private Label label2;
        private TextBox txtInfo;
        private Button btnStart;
        private TextBox txtIp;
        private Label label1;
        private ListBox lstClientIp;
        private Label label3;
    }
}
