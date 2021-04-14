namespace WindowsFormsApp1
{
    partial class ChatApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.IpBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IP = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PortRemoteBox1 = new System.Windows.Forms.TextBox();
            this.IpRemoteBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.Messagetext = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PortBox);
            this.groupBox1.Controls.Add(this.IpBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.IP);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Me";
            // 
            // PortBox
            // 
            this.PortBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PortBox.Location = new System.Drawing.Point(52, 87);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(142, 23);
            this.PortBox.TabIndex = 3;
            // 
            // IpBox
            // 
            this.IpBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.IpBox.Location = new System.Drawing.Point(49, 33);
            this.IpBox.Name = "IpBox";
            this.IpBox.Size = new System.Drawing.Size(145, 23);
            this.IpBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // IP
            // 
            this.IP.AutoSize = true;
            this.IP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP.Location = new System.Drawing.Point(7, 34);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(19, 16);
            this.IP.TabIndex = 0;
            this.IP.Text = "IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PortRemoteBox1);
            this.groupBox2.Controls.Add(this.IpRemoteBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(220, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 151);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Friend";
            // 
            // PortRemoteBox1
            // 
            this.PortRemoteBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PortRemoteBox1.Location = new System.Drawing.Point(68, 86);
            this.PortRemoteBox1.Name = "PortRemoteBox1";
            this.PortRemoteBox1.Size = new System.Drawing.Size(126, 23);
            this.PortRemoteBox1.TabIndex = 3;
            // 
            // IpRemoteBox
            // 
            this.IpRemoteBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.IpRemoteBox.Location = new System.Drawing.Point(68, 32);
            this.IpRemoteBox.Name = "IpRemoteBox";
            this.IpRemoteBox.Size = new System.Drawing.Size(126, 23);
            this.IpRemoteBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "IP";
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonConnect.Location = new System.Drawing.Point(430, 47);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(84, 40);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // listMessage
            // 
            this.listMessage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.listMessage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMessage.FormattingEnabled = true;
            this.listMessage.ItemHeight = 17;
            this.listMessage.Location = new System.Drawing.Point(12, 170);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(502, 106);
            this.listMessage.TabIndex = 3;
            // 
            // Messagetext
            // 
            this.Messagetext.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Messagetext.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Messagetext.Location = new System.Drawing.Point(13, 298);
            this.Messagetext.Name = "Messagetext";
            this.Messagetext.Size = new System.Drawing.Size(401, 23);
            this.Messagetext.TabIndex = 4;
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonSend.Location = new System.Drawing.Point(430, 288);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(84, 43);
            this.buttonSend.TabIndex = 5;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkGreen;
            this.button1.Location = new System.Drawing.Point(430, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChatApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(526, 467);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.Messagetext);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChatApp";
            this.Text = "ChatApp";
            this.Load += new System.EventHandler(this.ChatApp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PortBox;
        private System.Windows.Forms.TextBox IpBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox PortRemoteBox1;
        private System.Windows.Forms.TextBox IpRemoteBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ListBox listMessage;
        private System.Windows.Forms.TextBox Messagetext;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button button1;
    }
}