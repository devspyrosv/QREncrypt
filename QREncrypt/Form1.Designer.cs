namespace QREncrypt
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MyInfoLabel = new System.Windows.Forms.Label();
            this.CustomerInfoLabel = new System.Windows.Forms.Label();
            this.TimologioLabel = new System.Windows.Forms.Label();
            this.AmountsLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOHELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mySurnameInput = new System.Windows.Forms.TextBox();
            this.myAFMInput = new System.Windows.Forms.TextBox();
            this.myNameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.customerAFMInput = new System.Windows.Forms.TextBox();
            this.customerNameInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.invoiceNumberInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fPAInput = new System.Windows.Forms.TextBox();
            this.cleanMoneyInput = new System.Windows.Forms.TextBox();
            this.createQR = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.decryptButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.encryptedTextBox = new System.Windows.Forms.TextBox();
            this.decryptedTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.clearAllInputsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // MyInfoLabel
            // 
            this.MyInfoLabel.AutoSize = true;
            this.MyInfoLabel.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.MyInfoLabel.Location = new System.Drawing.Point(12, 42);
            this.MyInfoLabel.Name = "MyInfoLabel";
            this.MyInfoLabel.Size = new System.Drawing.Size(130, 22);
            this.MyInfoLabel.TabIndex = 0;
            this.MyInfoLabel.Text = "Στοιχεία μου";
            // 
            // CustomerInfoLabel
            // 
            this.CustomerInfoLabel.AutoSize = true;
            this.CustomerInfoLabel.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CustomerInfoLabel.Location = new System.Drawing.Point(7, 160);
            this.CustomerInfoLabel.Name = "CustomerInfoLabel";
            this.CustomerInfoLabel.Size = new System.Drawing.Size(160, 22);
            this.CustomerInfoLabel.TabIndex = 2;
            this.CustomerInfoLabel.Text = "Στοιχεία Πελάτη";
            // 
            // TimologioLabel
            // 
            this.TimologioLabel.AutoSize = true;
            this.TimologioLabel.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.TimologioLabel.Location = new System.Drawing.Point(7, 246);
            this.TimologioLabel.Name = "TimologioLabel";
            this.TimologioLabel.Size = new System.Drawing.Size(200, 22);
            this.TimologioLabel.TabIndex = 12;
            this.TimologioLabel.Text = "Στοιχεία Τιμολογίου";
            // 
            // AmountsLabel
            // 
            this.AmountsLabel.AutoSize = true;
            this.AmountsLabel.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AmountsLabel.Location = new System.Drawing.Point(7, 332);
            this.AmountsLabel.Name = "AmountsLabel";
            this.AmountsLabel.Size = new System.Drawing.Size(50, 22);
            this.AmountsLabel.TabIndex = 13;
            this.AmountsLabel.Text = "Ποσά";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(672, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllInputsToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nOHELPToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // nOHELPToolStripMenuItem
            // 
            this.nOHELPToolStripMenuItem.Name = "nOHELPToolStripMenuItem";
            this.nOHELPToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nOHELPToolStripMenuItem.Text = "NO HELP!";
            // 
            // mySurnameInput
            // 
            this.mySurnameInput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.mySurnameInput.Location = new System.Drawing.Point(99, 67);
            this.mySurnameInput.Name = "mySurnameInput";
            this.mySurnameInput.Size = new System.Drawing.Size(168, 26);
            this.mySurnameInput.TabIndex = 15;
            this.mySurnameInput.Text = "LYMPERTATOS";
            // 
            // myAFMInput
            // 
            this.myAFMInput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.myAFMInput.Location = new System.Drawing.Point(99, 131);
            this.myAFMInput.Name = "myAFMInput";
            this.myAFMInput.Size = new System.Drawing.Size(168, 26);
            this.myAFMInput.TabIndex = 17;
            this.myAFMInput.Text = "074208919";
            // 
            // myNameInput
            // 
            this.myNameInput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.myNameInput.Location = new System.Drawing.Point(99, 99);
            this.myNameInput.Name = "myNameInput";
            this.myNameInput.Size = new System.Drawing.Size(168, 26);
            this.myNameInput.TabIndex = 18;
            this.myNameInput.Text = "ANASTASIOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(31, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Επώνυμο";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(45, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Όνομα";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(54, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "ΑΦΜ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(54, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "ΑΦΜ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(28, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Ονομασία";
            // 
            // customerAFMInput
            // 
            this.customerAFMInput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.customerAFMInput.Location = new System.Drawing.Point(99, 217);
            this.customerAFMInput.Name = "customerAFMInput";
            this.customerAFMInput.Size = new System.Drawing.Size(168, 26);
            this.customerAFMInput.TabIndex = 23;
            // 
            // customerNameInput
            // 
            this.customerNameInput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.customerNameInput.Location = new System.Drawing.Point(99, 185);
            this.customerNameInput.Name = "customerNameInput";
            this.customerNameInput.Size = new System.Drawing.Size(168, 26);
            this.customerNameInput.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(14, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Ημερομηνία";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.Location = new System.Drawing.Point(10, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "#Τιμολογίου";
            // 
            // invoiceNumberInput
            // 
            this.invoiceNumberInput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.invoiceNumberInput.Location = new System.Drawing.Point(99, 271);
            this.invoiceNumberInput.Name = "invoiceNumberInput";
            this.invoiceNumberInput.Size = new System.Drawing.Size(168, 26);
            this.invoiceNumberInput.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.Location = new System.Drawing.Point(18, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Ποσό ΦΠΑ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label9.Location = new System.Drawing.Point(29, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 32);
            this.label9.TabIndex = 32;
            this.label9.Text = "Ποσό\r\n(Καθαρό) ";
            // 
            // fPAInput
            // 
            this.fPAInput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.fPAInput.Location = new System.Drawing.Point(99, 392);
            this.fPAInput.Name = "fPAInput";
            this.fPAInput.Size = new System.Drawing.Size(168, 26);
            this.fPAInput.TabIndex = 31;
            // 
            // cleanMoneyInput
            // 
            this.cleanMoneyInput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cleanMoneyInput.Location = new System.Drawing.Point(99, 360);
            this.cleanMoneyInput.Name = "cleanMoneyInput";
            this.cleanMoneyInput.Size = new System.Drawing.Size(168, 26);
            this.cleanMoneyInput.TabIndex = 30;
            // 
            // createQR
            // 
            this.createQR.BackColor = System.Drawing.Color.DarkRed;
            this.createQR.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createQR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createQR.Location = new System.Drawing.Point(13, 513);
            this.createQR.Name = "createQR";
            this.createQR.Size = new System.Drawing.Size(100, 36);
            this.createQR.TabIndex = 34;
            this.createQR.Text = "Create QR";
            this.createQR.UseVisualStyleBackColor = false;
            this.createQR.Click += new System.EventHandler(this.createQR_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(99, 303);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 20);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.passwordLabel.Location = new System.Drawing.Point(7, 441);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(86, 20);
            this.passwordLabel.TabIndex = 37;
            this.passwordLabel.Text = "Password";
            // 
            // passwordInput
            // 
            this.passwordInput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.passwordInput.Location = new System.Drawing.Point(11, 464);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(168, 26);
            this.passwordInput.TabIndex = 36;
            this.passwordInput.UseSystemPasswordChar = true;
            // 
            // decryptButton
            // 
            this.decryptButton.BackColor = System.Drawing.Color.Green;
            this.decryptButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.decryptButton.Location = new System.Drawing.Point(119, 513);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(100, 36);
            this.decryptButton.TabIndex = 38;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = false;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label10.Location = new System.Drawing.Point(287, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "Encrypted Text";
            // 
            // encryptedTextBox
            // 
            this.encryptedTextBox.Location = new System.Drawing.Point(291, 71);
            this.encryptedTextBox.Multiline = true;
            this.encryptedTextBox.Name = "encryptedTextBox";
            this.encryptedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.encryptedTextBox.Size = new System.Drawing.Size(343, 200);
            this.encryptedTextBox.TabIndex = 40;
            // 
            // decryptedTextBox
            // 
            this.decryptedTextBox.Location = new System.Drawing.Point(290, 307);
            this.decryptedTextBox.Multiline = true;
            this.decryptedTextBox.Name = "decryptedTextBox";
            this.decryptedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.decryptedTextBox.Size = new System.Drawing.Size(343, 200);
            this.decryptedTextBox.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label11.Location = new System.Drawing.Point(286, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 20);
            this.label11.TabIndex = 41;
            this.label11.Text = "Decrypted Text";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // clearAllInputsToolStripMenuItem
            // 
            this.clearAllInputsToolStripMenuItem.Name = "clearAllInputsToolStripMenuItem";
            this.clearAllInputsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.clearAllInputsToolStripMenuItem.Text = "Clear All Inputs";
            this.clearAllInputsToolStripMenuItem.Click += new System.EventHandler(this.clearAllInputsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 730);
            this.Controls.Add(this.decryptedTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.encryptedTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.createQR);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.fPAInput);
            this.Controls.Add(this.cleanMoneyInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.invoiceNumberInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.customerAFMInput);
            this.Controls.Add(this.customerNameInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myNameInput);
            this.Controls.Add(this.myAFMInput);
            this.Controls.Add(this.mySurnameInput);
            this.Controls.Add(this.AmountsLabel);
            this.Controls.Add(this.TimologioLabel);
            this.Controls.Add(this.CustomerInfoLabel);
            this.Controls.Add(this.MyInfoLabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "QREncrypt";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MyInfoLabel;
        private System.Windows.Forms.Label CustomerInfoLabel;
        private System.Windows.Forms.Label TimologioLabel;
        private System.Windows.Forms.Label AmountsLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOHELPToolStripMenuItem;
        private System.Windows.Forms.TextBox mySurnameInput;
        private System.Windows.Forms.TextBox myAFMInput;
        private System.Windows.Forms.TextBox myNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox customerAFMInput;
        private System.Windows.Forms.TextBox customerNameInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox invoiceNumberInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox fPAInput;
        private System.Windows.Forms.TextBox cleanMoneyInput;
        private System.Windows.Forms.Button createQR;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox encryptedTextBox;
        private System.Windows.Forms.TextBox decryptedTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem clearAllInputsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

