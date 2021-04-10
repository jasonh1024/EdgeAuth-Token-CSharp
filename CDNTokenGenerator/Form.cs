using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDNTokenGenerator
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void btnStartClick(object sender, EventArgs e)
        {
            string cdnLink = tbxCDNLink.Text;
            string filePath = tbxFilePath.Text;
            string salt = tbxSalt.Text;
            string tokenName = tbxTokenName.Text;
            long expiration = long.Parse(tbxExpiration.Text);

            string acl = filePath + "*";
            string token = TokenGenerator.GenerateMyToken(expiration, acl, salt);

            string url = cdnLink + filePath + "?" + tokenName + "=" + token;

            textBoxToken.Text = url;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOrigin_Click(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                string cookie = "AW-AUTH-KEY=" + tbxCookie.Text;
                client.Headers.Add("cookie", cookie);
                client.DownloadProgressChanged += DownloadProgressChanged;
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadFileCallback);

                string url = tbxOrigin.Text + tbxFP.Text;
                client.DownloadFileAsync(
                    // Param1 = Link of file
                    new System.Uri(url),
                    // Param2 = Path to save
                    tbxDst.Text
                ); 
            }
        }

        private void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Visible = true;
            progressBar.Value = e.ProgressPercentage;
        }

        private void DownloadFileCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                tbxError.Visible = true;
                tbxError.Text ="File download cancelled.";
            } else if (e.Error != null)
            {
                tbxError.Visible = true;
                tbxError.Text = e.Error.ToString();
            } else
            {
                tbxError.Visible = true;
                tbxError.Text = "Success. Pls check " + tbxDst.Text;
            }
        }
    }
}
