namespace TCPClient
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
            label1 = new Label();
            txtIp = new TextBox();
            btnConnect = new Button();
            txtInfo = new TextBox();
            txtMesaj = new TextBox();
            label2 = new Label();
            btnSend = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 37);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Server:";
            // 
            // txtIp
            // 
            txtIp.Location = new Point(78, 37);
            txtIp.Name = "txtIp";
            txtIp.Size = new Size(173, 27);
            txtIp.TabIndex = 1;
            txtIp.Text = "192.168.106.142:8000";
            // 
            // btnConnect
            // 
            btnConnect.BackColor = SystemColors.HotTrack;
            btnConnect.Location = new Point(629, 422);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(103, 37);
            btnConnect.TabIndex = 2;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(78, 70);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.ScrollBars = ScrollBars.Both;
            txtInfo.Size = new Size(654, 313);
            txtInfo.TabIndex = 3;
            // 
            // txtMesaj
            // 
            txtMesaj.Location = new Point(78, 389);
            txtMesaj.Name = "txtMesaj";
            txtMesaj.Size = new Size(654, 27);
            txtMesaj.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 389);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 4;
            label2.Text = "Mesaj:";
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.LimeGreen;
            btnSend.Location = new Point(478, 422);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(106, 37);
            btnSend.TabIndex = 6;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(780, 499);
            Controls.Add(btnSend);
            Controls.Add(txtMesaj);
            Controls.Add(label2);
            Controls.Add(txtInfo);
            Controls.Add(btnConnect);
            Controls.Add(txtIp);
            Controls.Add(label1);
            Name = "Form1";
            Text = "TCP/IP Client";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIp;
        private Button btnConnect;
        private TextBox txtInfo;
        private TextBox txtMesaj;
        private Label label2;
        private Button btnSend;
    }
}
