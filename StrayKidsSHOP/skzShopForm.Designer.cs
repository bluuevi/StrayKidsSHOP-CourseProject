namespace StrayKidsSHOP
{
    partial class skzShopForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCLOSE = new System.Windows.Forms.Button();
            this.tabControlShopAndCart = new System.Windows.Forms.TabControl();
            this.tabPageShop = new System.Windows.Forms.TabPage();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboDetails = new System.Windows.Forms.ComboBox();
            this.richDescription = new System.Windows.Forms.RichTextBox();
            this.pictureBoxItem = new System.Windows.Forms.PictureBox();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.tabPageCart = new System.Windows.Forms.TabPage();
            this.panelEmptyCart = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.labelTotalText = new System.Windows.Forms.Label();
            this.panelPay = new System.Windows.Forms.Panel();
            this.checkBoxPoints = new System.Windows.Forms.CheckBox();
            this.labelPoints = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.buttonPay = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLogPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelSignup = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSignPassword = new System.Windows.Forms.TextBox();
            this.textBoxSignLogin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxCart = new System.Windows.Forms.ListBox();
            this.pictureBoxPhotos = new System.Windows.Forms.PictureBox();
            this.tabControlShopAndCart.SuspendLayout();
            this.tabPageShop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).BeginInit();
            this.tabPageCart.SuspendLayout();
            this.panelEmptyCart.SuspendLayout();
            this.panelPay.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.panelSignup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCLOSE
            // 
            this.buttonCLOSE.BackColor = System.Drawing.Color.Silver;
            this.buttonCLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCLOSE.Font = new System.Drawing.Font("Montserrat", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCLOSE.Location = new System.Drawing.Point(1496, 15);
            this.buttonCLOSE.Name = "buttonCLOSE";
            this.buttonCLOSE.Size = new System.Drawing.Size(30, 30);
            this.buttonCLOSE.TabIndex = 0;
            this.buttonCLOSE.Text = "X";
            this.buttonCLOSE.UseVisualStyleBackColor = false;
            this.buttonCLOSE.Click += new System.EventHandler(this.buttonCLOSE_Click);
            // 
            // tabControlShopAndCart
            // 
            this.tabControlShopAndCart.Controls.Add(this.tabPageShop);
            this.tabControlShopAndCart.Controls.Add(this.tabPageCart);
            this.tabControlShopAndCart.Location = new System.Drawing.Point(0, 30);
            this.tabControlShopAndCart.Name = "tabControlShopAndCart";
            this.tabControlShopAndCart.SelectedIndex = 0;
            this.tabControlShopAndCart.Size = new System.Drawing.Size(1556, 884);
            this.tabControlShopAndCart.TabIndex = 1;
            this.tabControlShopAndCart.SelectedIndexChanged += new System.EventHandler(this.tabControlShopAndCart_SelectedIndexChanged);
            // 
            // tabPageShop
            // 
            this.tabPageShop.BackColor = System.Drawing.Color.White;
            this.tabPageShop.Controls.Add(this.buttonAddToCart);
            this.tabPageShop.Controls.Add(this.labelPrice);
            this.tabPageShop.Controls.Add(this.label1);
            this.tabPageShop.Controls.Add(this.comboDetails);
            this.tabPageShop.Controls.Add(this.richDescription);
            this.tabPageShop.Controls.Add(this.pictureBoxItem);
            this.tabPageShop.Controls.Add(this.comboBoxItem);
            this.tabPageShop.Controls.Add(this.comboCategory);
            this.tabPageShop.Location = new System.Drawing.Point(4, 41);
            this.tabPageShop.Name = "tabPageShop";
            this.tabPageShop.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShop.Size = new System.Drawing.Size(1548, 839);
            this.tabPageShop.TabIndex = 0;
            this.tabPageShop.Text = "Shop";
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.BackColor = System.Drawing.Color.Silver;
            this.buttonAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddToCart.Font = new System.Drawing.Font("Montserrat", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddToCart.Location = new System.Drawing.Point(891, 689);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(468, 63);
            this.buttonAddToCart.TabIndex = 2;
            this.buttonAddToCart.Text = "Add to Cart";
            this.buttonAddToCart.UseVisualStyleBackColor = false;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Montserrat", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(872, 568);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(0, 55);
            this.labelPrice.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(717, 568);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "Price:";
            // 
            // comboDetails
            // 
            this.comboDetails.BackColor = System.Drawing.Color.White;
            this.comboDetails.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboDetails.FormattingEnabled = true;
            this.comboDetails.Location = new System.Drawing.Point(727, 525);
            this.comboDetails.Name = "comboDetails";
            this.comboDetails.Size = new System.Drawing.Size(396, 40);
            this.comboDetails.TabIndex = 4;
            this.comboDetails.SelectedIndexChanged += new System.EventHandler(this.comboDetails_SelectedIndexChanged);
            // 
            // richDescription
            // 
            this.richDescription.BackColor = System.Drawing.Color.White;
            this.richDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richDescription.Location = new System.Drawing.Point(727, 52);
            this.richDescription.Name = "richDescription";
            this.richDescription.ReadOnly = true;
            this.richDescription.Size = new System.Drawing.Size(795, 451);
            this.richDescription.TabIndex = 3;
            this.richDescription.Text = "";
            // 
            // pictureBoxItem
            // 
            this.pictureBoxItem.Location = new System.Drawing.Point(8, 52);
            this.pictureBoxItem.Name = "pictureBoxItem";
            this.pictureBoxItem.Size = new System.Drawing.Size(700, 700);
            this.pictureBoxItem.TabIndex = 2;
            this.pictureBoxItem.TabStop = false;
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.BackColor = System.Drawing.Color.White;
            this.comboBoxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Location = new System.Drawing.Point(138, 6);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(396, 40);
            this.comboBoxItem.TabIndex = 1;
            this.comboBoxItem.SelectedIndexChanged += new System.EventHandler(this.comboBoxItem_SelectedIndexChanged);
            // 
            // comboCategory
            // 
            this.comboCategory.BackColor = System.Drawing.Color.White;
            this.comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(6, 6);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(126, 40);
            this.comboCategory.TabIndex = 0;
            this.comboCategory.SelectedIndexChanged += new System.EventHandler(this.comboCategory_SelectedIndexChanged);
            // 
            // tabPageCart
            // 
            this.tabPageCart.BackColor = System.Drawing.Color.White;
            this.tabPageCart.Controls.Add(this.panelEmptyCart);
            this.tabPageCart.Controls.Add(this.labelTotalAmount);
            this.tabPageCart.Controls.Add(this.buttonBuy);
            this.tabPageCart.Controls.Add(this.buttonDeleteItem);
            this.tabPageCart.Controls.Add(this.labelTotalText);
            this.tabPageCart.Controls.Add(this.panelPay);
            this.tabPageCart.Controls.Add(this.panelLogin);
            this.tabPageCart.Controls.Add(this.panelSignup);
            this.tabPageCart.Controls.Add(this.listBoxCart);
            this.tabPageCart.Controls.Add(this.pictureBoxPhotos);
            this.tabPageCart.Location = new System.Drawing.Point(4, 41);
            this.tabPageCart.Name = "tabPageCart";
            this.tabPageCart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCart.Size = new System.Drawing.Size(1548, 839);
            this.tabPageCart.TabIndex = 1;
            this.tabPageCart.Text = "Cart";
            // 
            // panelEmptyCart
            // 
            this.panelEmptyCart.BackgroundImage = global::StrayKidsSHOP.Properties.Resources.skzNoCart;
            this.panelEmptyCart.Controls.Add(this.label3);
            this.panelEmptyCart.Location = new System.Drawing.Point(6, 6);
            this.panelEmptyCart.Name = "panelEmptyCart";
            this.panelEmptyCart.Size = new System.Drawing.Size(1516, 779);
            this.panelEmptyCart.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(600, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(888, 110);
            this.label3.TabIndex = 0;
            this.label3.Text = "Your Cart is empty!\r\nPlease go to Shop and add something <3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Font = new System.Drawing.Font("Montserrat", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalAmount.Location = new System.Drawing.Point(335, 609);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(0, 55);
            this.labelTotalAmount.TabIndex = 9;
            // 
            // buttonBuy
            // 
            this.buttonBuy.BackColor = System.Drawing.Color.Silver;
            this.buttonBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuy.Font = new System.Drawing.Font("Montserrat", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBuy.Location = new System.Drawing.Point(532, 721);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(249, 63);
            this.buttonBuy.TabIndex = 5;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = false;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.BackColor = System.Drawing.Color.Silver;
            this.buttonDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteItem.Font = new System.Drawing.Font("Montserrat", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteItem.Location = new System.Drawing.Point(18, 721);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(249, 63);
            this.buttonDeleteItem.TabIndex = 12;
            this.buttonDeleteItem.Text = "Delete item";
            this.buttonDeleteItem.UseVisualStyleBackColor = false;
            this.buttonDeleteItem.Click += new System.EventHandler(this.buttonDeleteItem_Click);
            // 
            // labelTotalText
            // 
            this.labelTotalText.AutoSize = true;
            this.labelTotalText.Font = new System.Drawing.Font("Montserrat", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalText.Location = new System.Drawing.Point(8, 613);
            this.labelTotalText.Name = "labelTotalText";
            this.labelTotalText.Size = new System.Drawing.Size(321, 55);
            this.labelTotalText.TabIndex = 8;
            this.labelTotalText.Text = "Total Amount:";
            // 
            // panelPay
            // 
            this.panelPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelPay.Controls.Add(this.checkBoxPoints);
            this.panelPay.Controls.Add(this.labelPoints);
            this.panelPay.Controls.Add(this.labelMoney);
            this.panelPay.Controls.Add(this.buttonPay);
            this.panelPay.Controls.Add(this.label13);
            this.panelPay.Controls.Add(this.label14);
            this.panelPay.Controls.Add(this.labelWelcome);
            this.panelPay.Location = new System.Drawing.Point(809, 398);
            this.panelPay.Name = "panelPay";
            this.panelPay.Size = new System.Drawing.Size(713, 386);
            this.panelPay.TabIndex = 10;
            // 
            // checkBoxPoints
            // 
            this.checkBoxPoints.AutoSize = true;
            this.checkBoxPoints.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxPoints.Font = new System.Drawing.Font("Montserrat", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxPoints.Location = new System.Drawing.Point(211, 306);
            this.checkBoxPoints.Name = "checkBoxPoints";
            this.checkBoxPoints.Size = new System.Drawing.Size(200, 45);
            this.checkBoxPoints.TabIndex = 9;
            this.checkBoxPoints.Text = "use points";
            this.checkBoxPoints.UseVisualStyleBackColor = true;
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Font = new System.Drawing.Font("Montserrat", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPoints.Location = new System.Drawing.Point(222, 183);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(0, 41);
            this.labelPoints.TabIndex = 8;
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Font = new System.Drawing.Font("Montserrat", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMoney.Location = new System.Drawing.Point(222, 142);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(0, 41);
            this.labelMoney.TabIndex = 7;
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.Color.Silver;
            this.buttonPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPay.Font = new System.Drawing.Font("Montserrat", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPay.Location = new System.Drawing.Point(417, 235);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(256, 116);
            this.buttonPay.TabIndex = 6;
            this.buttonPay.Text = "PAY";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Montserrat", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(90, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 41);
            this.label13.TabIndex = 4;
            this.label13.Text = "points:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Montserrat", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(81, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 41);
            this.label14.TabIndex = 3;
            this.label14.Text = "money:";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Montserrat", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWelcome.Location = new System.Drawing.Point(95, 23);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(368, 51);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Have a great day,\r\n";
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelLogin.Controls.Add(this.label);
            this.panelLogin.Controls.Add(this.label6);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.label5);
            this.panelLogin.Controls.Add(this.label4);
            this.panelLogin.Controls.Add(this.textBoxLogPassword);
            this.panelLogin.Controls.Add(this.textBoxLogLogin);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Location = new System.Drawing.Point(809, 6);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(713, 386);
            this.panelLogin.TabIndex = 6;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Montserrat", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label.Location = new System.Drawing.Point(429, 334);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(107, 32);
            this.label.TabIndex = 8;
            this.label.Text = "Sign up";
            this.label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(181, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(337, 64);
            this.label6.TabIndex = 7;
            this.label6.Text = "Log in to enjoy convenient\r\nfeatures and benefits.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Silver;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Montserrat", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.Location = new System.Drawing.Point(563, 184);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(110, 110);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "LOG\r\nIN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(33, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(91, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "login";
            // 
            // textBoxLogPassword
            // 
            this.textBoxLogPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogPassword.Font = new System.Drawing.Font("Montserrat", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogPassword.Location = new System.Drawing.Point(172, 248);
            this.textBoxLogPassword.MaxLength = 32;
            this.textBoxLogPassword.Name = "textBoxLogPassword";
            this.textBoxLogPassword.Size = new System.Drawing.Size(364, 46);
            this.textBoxLogPassword.TabIndex = 2;
            this.textBoxLogPassword.TextChanged += new System.EventHandler(this.textBoxLogPassword_TextChanged);
            // 
            // textBoxLogLogin
            // 
            this.textBoxLogLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogLogin.Font = new System.Drawing.Font("Montserrat", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogLogin.Location = new System.Drawing.Point(172, 184);
            this.textBoxLogLogin.MaxLength = 32;
            this.textBoxLogLogin.Name = "textBoxLogLogin";
            this.textBoxLogLogin.Size = new System.Drawing.Size(364, 46);
            this.textBoxLogLogin.TabIndex = 1;
            this.textBoxLogLogin.TextChanged += new System.EventHandler(this.textBoxLogLogin_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(279, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 51);
            this.label2.TabIndex = 0;
            this.label2.Text = "LOG IN";
            // 
            // panelSignup
            // 
            this.panelSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelSignup.Controls.Add(this.label8);
            this.panelSignup.Controls.Add(this.textBoxName);
            this.panelSignup.Controls.Add(this.labelLogin);
            this.panelSignup.Controls.Add(this.buttonSignUp);
            this.panelSignup.Controls.Add(this.label9);
            this.panelSignup.Controls.Add(this.label10);
            this.panelSignup.Controls.Add(this.textBoxSignPassword);
            this.panelSignup.Controls.Add(this.textBoxSignLogin);
            this.panelSignup.Controls.Add(this.label7);
            this.panelSignup.Location = new System.Drawing.Point(809, 6);
            this.panelSignup.Name = "panelSignup";
            this.panelSignup.Size = new System.Drawing.Size(713, 386);
            this.panelSignup.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(82, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 32);
            this.label8.TabIndex = 16;
            this.label8.Text = "name";
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Montserrat", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(172, 120);
            this.textBoxName.MaxLength = 28;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(364, 46);
            this.textBoxName.TabIndex = 15;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Montserrat", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelLogin.Location = new System.Drawing.Point(441, 334);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(89, 32);
            this.labelLogin.TabIndex = 14;
            this.labelLogin.Text = "Log in";
            this.labelLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelLogin.Click += new System.EventHandler(this.labelLogin_Click);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BackColor = System.Drawing.Color.Silver;
            this.buttonSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignUp.Font = new System.Drawing.Font("Montserrat", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSignUp.Location = new System.Drawing.Point(563, 184);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(110, 110);
            this.buttonSignUp.TabIndex = 13;
            this.buttonSignUp.Text = "SIGN\r\nUP";
            this.buttonSignUp.UseVisualStyleBackColor = false;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(33, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 32);
            this.label9.TabIndex = 12;
            this.label9.Text = "password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(91, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 32);
            this.label10.TabIndex = 11;
            this.label10.Text = "login";
            // 
            // textBoxSignPassword
            // 
            this.textBoxSignPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSignPassword.Font = new System.Drawing.Font("Montserrat", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSignPassword.Location = new System.Drawing.Point(172, 248);
            this.textBoxSignPassword.MaxLength = 32;
            this.textBoxSignPassword.Name = "textBoxSignPassword";
            this.textBoxSignPassword.Size = new System.Drawing.Size(364, 46);
            this.textBoxSignPassword.TabIndex = 10;
            this.textBoxSignPassword.TextChanged += new System.EventHandler(this.textBoxSignPassword_TextChanged);
            // 
            // textBoxSignLogin
            // 
            this.textBoxSignLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSignLogin.Font = new System.Drawing.Font("Montserrat", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSignLogin.Location = new System.Drawing.Point(172, 184);
            this.textBoxSignLogin.MaxLength = 32;
            this.textBoxSignLogin.Name = "textBoxSignLogin";
            this.textBoxSignLogin.Size = new System.Drawing.Size(364, 46);
            this.textBoxSignLogin.TabIndex = 9;
            this.textBoxSignLogin.TextChanged += new System.EventHandler(this.textBoxSignLogin_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(267, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 51);
            this.label7.TabIndex = 1;
            this.label7.Text = "SIGN UP";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBoxCart
            // 
            this.listBoxCart.FormattingEnabled = true;
            this.listBoxCart.ItemHeight = 32;
            this.listBoxCart.Location = new System.Drawing.Point(6, 6);
            this.listBoxCart.Name = "listBoxCart";
            this.listBoxCart.Size = new System.Drawing.Size(797, 580);
            this.listBoxCart.TabIndex = 11;
            // 
            // pictureBoxPhotos
            // 
            this.pictureBoxPhotos.BackColor = System.Drawing.Color.White;
            this.pictureBoxPhotos.Location = new System.Drawing.Point(809, 6);
            this.pictureBoxPhotos.Name = "pictureBoxPhotos";
            this.pictureBoxPhotos.Size = new System.Drawing.Size(707, 779);
            this.pictureBoxPhotos.TabIndex = 1;
            this.pictureBoxPhotos.TabStop = false;
            // 
            // skzShopForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::StrayKidsSHOP.Properties.Resources.Stray_Kids_Logo_png;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1556, 884);
            this.Controls.Add(this.buttonCLOSE);
            this.Controls.Add(this.tabControlShopAndCart);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Montserrat", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "skzShopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "skzShopForm";
            this.tabControlShopAndCart.ResumeLayout(false);
            this.tabPageShop.ResumeLayout(false);
            this.tabPageShop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).EndInit();
            this.tabPageCart.ResumeLayout(false);
            this.tabPageCart.PerformLayout();
            this.panelEmptyCart.ResumeLayout(false);
            this.panelEmptyCart.PerformLayout();
            this.panelPay.ResumeLayout(false);
            this.panelPay.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelSignup.ResumeLayout(false);
            this.panelSignup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCLOSE;
        private System.Windows.Forms.TabControl tabControlShopAndCart;
        private System.Windows.Forms.TabPage tabPageShop;
        private System.Windows.Forms.TabPage tabPageCart;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.ComboBox comboBoxItem;
        private System.Windows.Forms.PictureBox pictureBoxItem;
        private System.Windows.Forms.RichTextBox richDescription;
        private System.Windows.Forms.ComboBox comboDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Label labelTotalText;
        private System.Windows.Forms.Panel panelSignup;
        private System.Windows.Forms.TextBox textBoxLogLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSignPassword;
        private System.Windows.Forms.TextBox textBoxSignLogin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLogPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Panel panelPay;
        private System.Windows.Forms.CheckBox checkBoxPoints;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonDeleteItem;
        private System.Windows.Forms.ListBox listBoxCart;
        private System.Windows.Forms.Panel panelEmptyCart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxPhotos;
    }
}

