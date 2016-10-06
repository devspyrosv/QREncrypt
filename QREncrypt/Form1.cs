using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using QRCoder;

namespace QREncrypt
{
    public partial class Form1 : Form
    {
        private string _mySurname;
        private string _myName;
        private string _myAfm;
        private string _customerAfm;
        private string _customerName;
        private string _invoiceNumber;
        private string _invoiceDate;
        private string _cleanMoney;
        private string _afmMoney;

        private string _password;

        private string _fullText;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void createQR_Click(object sender, EventArgs e)
        {
            //collect all textboxes
            var boxes = Controls.OfType<TextBox>();

            //Check for empty fields
            foreach (var box in boxes)
            {
                if (box.Name == "encryptedTextBox" || box.Name == "decryptedTextBox")
                {
                    continue;
                }
                else if (string.IsNullOrWhiteSpace(box.Text))
                {
                    errorProvider1.SetError(box, "Please fill the required field");
                }
                else
                {
                    errorProvider1.SetError(box, "");
                }
            }



            //In the end of the day, just require the password.
            if (!string.IsNullOrWhiteSpace(passwordInput.Text))
            {
                _mySurname = mySurnameInput.Text;
                _myName = myNameInput.Text;
                _myAfm = myAFMInput.Text;
                _customerAfm = customerAFMInput.Text;
                _customerName = customerNameInput.Text;
                _invoiceNumber = invoiceNumberInput.Text;
                _invoiceDate = dateTimePicker1.Text;
                _cleanMoney = cleanMoneyInput.Text;
                _afmMoney = fPAInput.Text;

                _password = passwordInput.Text;

                _fullText =
                    "ME:"
                    + _mySurname
                    + "#"
                    + _myName
                    + "#MY_VAT:"
                    + _myAfm
                    + "#CUSTOMER_VAT:"
                    + _customerAfm
                    + "#CUSTOMER_NAME:"
                    + _customerName
                    + "#INVOICE:"
                    + _invoiceNumber
                    + "#INVOICE_DATE:"
                    + _invoiceDate
                    + "#PRICE:"
                    + _cleanMoney
                    + "#VAT:"
                    + _afmMoney;

                string encryptedString = HttpUtility.HtmlEncode(StringCipher.Base64Encode(StringCipher.Encrypt(_fullText, _password)));
                encryptedTextBox.Text = encryptedString;
                string textToBecomeQR = @"http://taxpros.gr?qr=" + encryptedString;

                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(textToBecomeQR, QRCodeGenerator.ECCLevel.Q,true);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(20);

                SaveFileDialog dialog = new SaveFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    int width = Convert.ToInt32(qrCodeImage.Width);
                    int height = Convert.ToInt32(qrCodeImage.Height);
                    qrCodeImage.Save(dialog.FileName+".jpg", ImageFormat.Jpeg);
                }
            }
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrWhiteSpace(passwordInput.Text) && !string.IsNullOrEmpty(encryptedTextBox.Text))
            {
                try
                {
                    decryptedTextBox.Text = HttpUtility.HtmlDecode(StringCipher.Decrypt(StringCipher.Base64Decode(encryptedTextBox.Text), passwordInput.Text));
                    errorProvider1.SetError(passwordInput, "");
                    errorProvider1.SetError(encryptedTextBox, "");
                }
                catch
                {
                    decryptedTextBox.Text = @"NICE TRY! Wrong password!";
                }
                
                
            }
            else
            {
                errorProvider1.SetError(passwordInput, "Please fill the required field");
                errorProvider1.SetError(encryptedTextBox, "Please fill the required field");
            }
        }

        private void clearAllInputsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //collect all textboxes
            var boxes = Controls.OfType<TextBox>();

            //Check for empty fields
            foreach (var box in boxes)
            {
                if (box.Name == "mySurnameInput" || box.Name == "myNameInput" || box.Name == "myAFMInput")
                {
                    continue;
                }
                else
                {
                    box.Text = "";
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (About box = new About())
            {
                box.ShowDialog(this);
            }
        }
    }
}
