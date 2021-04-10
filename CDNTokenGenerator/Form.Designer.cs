namespace CDNTokenGenerator
{
    partial class Form
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
            this.btnGenURL = new System.Windows.Forms.Button();
            this.textBoxToken = new System.Windows.Forms.TextBox();
            this.lblCDNLink = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.lblSalt = new System.Windows.Forms.Label();
            this.lblWindow = new System.Windows.Forms.Label();
            this.lblToken = new System.Windows.Forms.Label();
            this.tbxCDNLink = new System.Windows.Forms.TextBox();
            this.tbxFilePath = new System.Windows.Forms.TextBox();
            this.tbxSalt = new System.Windows.Forms.TextBox();
            this.tbxExpiration = new System.Windows.Forms.TextBox();
            this.tbxTokenName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOrigin = new System.Windows.Forms.Button();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.tbxCookie = new System.Windows.Forms.TextBox();
            this.lblFP = new System.Windows.Forms.Label();
            this.tbxFP = new System.Windows.Forms.TextBox();
            this.lblCookie = new System.Windows.Forms.Label();
            this.tbxOrigin = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblDst = new System.Windows.Forms.Label();
            this.tbxDst = new System.Windows.Forms.TextBox();
            this.tbxError = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenURL
            // 
            this.btnGenURL.Location = new System.Drawing.Point(23, 159);
            this.btnGenURL.Name = "btnGenURL";
            this.btnGenURL.Size = new System.Drawing.Size(106, 27);
            this.btnGenURL.TabIndex = 0;
            this.btnGenURL.Text = "Generate URL";
            this.btnGenURL.UseVisualStyleBackColor = true;
            this.btnGenURL.Click += new System.EventHandler(this.btnStartClick);
            // 
            // textBoxToken
            // 
            this.textBoxToken.Location = new System.Drawing.Point(135, 163);
            this.textBoxToken.Name = "textBoxToken";
            this.textBoxToken.Size = new System.Drawing.Size(439, 20);
            this.textBoxToken.TabIndex = 1;
            // 
            // lblCDNLink
            // 
            this.lblCDNLink.AutoSize = true;
            this.lblCDNLink.Location = new System.Drawing.Point(20, 25);
            this.lblCDNLink.Name = "lblCDNLink";
            this.lblCDNLink.Size = new System.Drawing.Size(109, 13);
            this.lblCDNLink.TabIndex = 2;
            this.lblCDNLink.Text = "CDN Edge Hostname";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(20, 50);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(48, 13);
            this.lblFilePath.TabIndex = 3;
            this.lblFilePath.Text = "File Path";
            // 
            // lblSalt
            // 
            this.lblSalt.AutoSize = true;
            this.lblSalt.Location = new System.Drawing.Point(20, 74);
            this.lblSalt.Name = "lblSalt";
            this.lblSalt.Size = new System.Drawing.Size(135, 13);
            this.lblSalt.TabIndex = 4;
            this.lblSalt.Text = "Encryption Key (Salt Value)";
            // 
            // lblWindow
            // 
            this.lblWindow.AutoSize = true;
            this.lblWindow.Location = new System.Drawing.Point(20, 99);
            this.lblWindow.Name = "lblWindow";
            this.lblWindow.Size = new System.Drawing.Size(138, 13);
            this.lblWindow.TabIndex = 5;
            this.lblWindow.Text = "Token Expiration (Seconds)";
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Location = new System.Drawing.Point(20, 122);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(69, 13);
            this.lblToken.TabIndex = 6;
            this.lblToken.Text = "Token Name";
            // 
            // tbxCDNLink
            // 
            this.tbxCDNLink.Location = new System.Drawing.Point(160, 22);
            this.tbxCDNLink.Name = "tbxCDNLink";
            this.tbxCDNLink.Size = new System.Drawing.Size(191, 20);
            this.tbxCDNLink.TabIndex = 7;
            this.tbxCDNLink.Text = "https://test1.akamaized.net";
            this.tbxCDNLink.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxFilePath
            // 
            this.tbxFilePath.Location = new System.Drawing.Point(160, 47);
            this.tbxFilePath.Name = "tbxFilePath";
            this.tbxFilePath.Size = new System.Drawing.Size(191, 20);
            this.tbxFilePath.TabIndex = 8;
            this.tbxFilePath.Text = "/monitor.txt";
            // 
            // tbxSalt
            // 
            this.tbxSalt.Location = new System.Drawing.Point(160, 71);
            this.tbxSalt.Name = "tbxSalt";
            this.tbxSalt.Size = new System.Drawing.Size(191, 20);
            this.tbxSalt.TabIndex = 9;
            this.tbxSalt.Text = "Salt Value";
            // 
            // tbxExpiration
            // 
            this.tbxExpiration.Location = new System.Drawing.Point(160, 96);
            this.tbxExpiration.Name = "tbxExpiration";
            this.tbxExpiration.Size = new System.Drawing.Size(191, 20);
            this.tbxExpiration.TabIndex = 10;
            this.tbxExpiration.Text = "600";
            // 
            // tbxTokenName
            // 
            this.tbxTokenName.Location = new System.Drawing.Point(160, 119);
            this.tbxTokenName.Name = "tbxTokenName";
            this.tbxTokenName.Size = new System.Drawing.Size(191, 20);
            this.tbxTokenName.TabIndex = 11;
            this.tbxTokenName.Text = "token";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCDNLink);
            this.groupBox1.Controls.Add(this.tbxTokenName);
            this.groupBox1.Controls.Add(this.btnGenURL);
            this.groupBox1.Controls.Add(this.tbxExpiration);
            this.groupBox1.Controls.Add(this.textBoxToken);
            this.groupBox1.Controls.Add(this.tbxSalt);
            this.groupBox1.Controls.Add(this.lblFilePath);
            this.groupBox1.Controls.Add(this.tbxFilePath);
            this.groupBox1.Controls.Add(this.lblSalt);
            this.groupBox1.Controls.Add(this.tbxCDNLink);
            this.groupBox1.Controls.Add(this.lblWindow);
            this.groupBox1.Controls.Add(this.lblToken);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 216);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CDN Edge URL Check";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxError);
            this.groupBox2.Controls.Add(this.tbxDst);
            this.groupBox2.Controls.Add(this.lblDst);
            this.groupBox2.Controls.Add(this.progressBar);
            this.groupBox2.Controls.Add(this.btnOrigin);
            this.groupBox2.Controls.Add(this.lblOrigin);
            this.groupBox2.Controls.Add(this.tbxCookie);
            this.groupBox2.Controls.Add(this.lblFP);
            this.groupBox2.Controls.Add(this.tbxFP);
            this.groupBox2.Controls.Add(this.lblCookie);
            this.groupBox2.Controls.Add(this.tbxOrigin);
            this.groupBox2.Location = new System.Drawing.Point(16, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(618, 195);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CDN Origin Box Check";
            // 
            // btnOrigin
            // 
            this.btnOrigin.Location = new System.Drawing.Point(19, 132);
            this.btnOrigin.Name = "btnOrigin";
            this.btnOrigin.Size = new System.Drawing.Size(106, 27);
            this.btnOrigin.TabIndex = 16;
            this.btnOrigin.Text = "Origin Check";
            this.btnOrigin.UseVisualStyleBackColor = true;
            this.btnOrigin.Click += new System.EventHandler(this.btnOrigin_Click);
            // 
            // lblOrigin
            // 
            this.lblOrigin.AutoSize = true;
            this.lblOrigin.Location = new System.Drawing.Point(16, 32);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(93, 13);
            this.lblOrigin.TabIndex = 10;
            this.lblOrigin.Text = "Origin Server URL";
            // 
            // tbxCookie
            // 
            this.tbxCookie.Location = new System.Drawing.Point(156, 78);
            this.tbxCookie.Name = "tbxCookie";
            this.tbxCookie.Size = new System.Drawing.Size(191, 20);
            this.tbxCookie.TabIndex = 15;
            this.tbxCookie.Text = "Cookie Value";
            // 
            // lblFP
            // 
            this.lblFP.AutoSize = true;
            this.lblFP.Location = new System.Drawing.Point(16, 57);
            this.lblFP.Name = "lblFP";
            this.lblFP.Size = new System.Drawing.Size(66, 13);
            this.lblFP.TabIndex = 11;
            this.lblFP.Text = "Source Path";
            // 
            // tbxFP
            // 
            this.tbxFP.Location = new System.Drawing.Point(156, 54);
            this.tbxFP.Name = "tbxFP";
            this.tbxFP.Size = new System.Drawing.Size(191, 20);
            this.tbxFP.TabIndex = 14;
            this.tbxFP.Text = "/monitor.txt";
            // 
            // lblCookie
            // 
            this.lblCookie.AutoSize = true;
            this.lblCookie.Location = new System.Drawing.Point(16, 81);
            this.lblCookie.Name = "lblCookie";
            this.lblCookie.Size = new System.Drawing.Size(40, 13);
            this.lblCookie.TabIndex = 12;
            this.lblCookie.Text = "Cookie";
            // 
            // tbxOrigin
            // 
            this.tbxOrigin.Location = new System.Drawing.Point(156, 29);
            this.tbxOrigin.Name = "tbxOrigin";
            this.tbxOrigin.Size = new System.Drawing.Size(191, 20);
            this.tbxOrigin.TabIndex = 13;
            this.tbxOrigin.Text = "https://cdnorigin.domain.com";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(156, 132);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(191, 23);
            this.progressBar.TabIndex = 17;
            this.progressBar.Visible = false;
            // 
            // lblDst
            // 
            this.lblDst.AutoSize = true;
            this.lblDst.Location = new System.Drawing.Point(16, 104);
            this.lblDst.Name = "lblDst";
            this.lblDst.Size = new System.Drawing.Size(85, 13);
            this.lblDst.TabIndex = 18;
            this.lblDst.Text = "Destination Path";
            // 
            // tbxDst
            // 
            this.tbxDst.Location = new System.Drawing.Point(156, 101);
            this.tbxDst.Name = "tbxDst";
            this.tbxDst.Size = new System.Drawing.Size(191, 20);
            this.tbxDst.TabIndex = 19;
            this.tbxDst.Text = "c:\\\\Temp\\\\monitor.txt";
            // 
            // tbxError
            // 
            this.tbxError.Location = new System.Drawing.Point(362, 19);
            this.tbxError.Multiline = true;
            this.tbxError.Name = "tbxError";
            this.tbxError.Size = new System.Drawing.Size(243, 140);
            this.tbxError.TabIndex = 20;
            this.tbxError.Visible = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form";
            this.Text = "GSS CDN Troubleshooting Tool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenURL;
        private System.Windows.Forms.TextBox textBoxToken;
        private System.Windows.Forms.Label lblCDNLink;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Label lblSalt;
        private System.Windows.Forms.Label lblWindow;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.TextBox tbxCDNLink;
        private System.Windows.Forms.TextBox tbxFilePath;
        private System.Windows.Forms.TextBox tbxSalt;
        private System.Windows.Forms.TextBox tbxExpiration;
        private System.Windows.Forms.TextBox tbxTokenName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblOrigin;
        private System.Windows.Forms.TextBox tbxCookie;
        private System.Windows.Forms.Label lblFP;
        private System.Windows.Forms.TextBox tbxFP;
        private System.Windows.Forms.Label lblCookie;
        private System.Windows.Forms.TextBox tbxOrigin;
        private System.Windows.Forms.Button btnOrigin;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox tbxDst;
        private System.Windows.Forms.Label lblDst;
        private System.Windows.Forms.TextBox tbxError;
    }
}

