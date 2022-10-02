namespace WinForms_Homework_3_BestOil;

partial class Form1
{
	private System.ComponentModel.IContainer components = null;

	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
			components.Dispose();
		
		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	private void InitializeComponent()
	{
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.rdbtn_Price = new System.Windows.Forms.RadioButton();
			this.rdbtn_Litr = new System.Windows.Forms.RadioButton();
			this.cbox_Petrol = new System.Windows.Forms.ComboBox();
			this.tbox_PetrolPrice = new System.Windows.Forms.TextBox();
			this.tbox_Amount = new System.Windows.Forms.TextBox();
			this.tbox_Litr = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lbl_TotalPetrolPrice = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.tbox_ColaPrice = new System.Windows.Forms.TextBox();
			this.tbox_FrenchFPrice = new System.Windows.Forms.TextBox();
			this.tbox_HamburgerPrice = new System.Windows.Forms.TextBox();
			this.tbox_HotdogPrice = new System.Windows.Forms.TextBox();
			this.tbox_Cola = new System.Windows.Forms.TextBox();
			this.tbox_FrenchFries = new System.Windows.Forms.TextBox();
			this.tbox_Hamburger = new System.Windows.Forms.TextBox();
			this.tbox_Hotdog = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.chckbox_Cola = new System.Windows.Forms.CheckBox();
			this.chckbox_FrencFries = new System.Windows.Forms.CheckBox();
			this.chckbox_Hamburger = new System.Windows.Forms.CheckBox();
			this.chckbox_Hotdog = new System.Windows.Forms.CheckBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.lbl_TotalFoodPrice = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.btn_Calculate = new System.Windows.Forms.Button();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.lbl_TotalPrice = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(16, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 31);
			this.label2.TabIndex = 1;
			this.label2.Text = "Petrol";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(16, 157);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 31);
			this.label3.TabIndex = 2;
			this.label3.Text = "Price";
			// 
			// rdbtn_Price
			// 
			this.rdbtn_Price.AutoSize = true;
			this.rdbtn_Price.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.rdbtn_Price.Location = new System.Drawing.Point(7, 202);
			this.rdbtn_Price.Name = "rdbtn_Price";
			this.rdbtn_Price.Size = new System.Drawing.Size(131, 35);
			this.rdbtn_Price.TabIndex = 3;
			this.rdbtn_Price.Text = "Amount";
			this.rdbtn_Price.UseVisualStyleBackColor = true;
			this.rdbtn_Price.CheckedChanged += new System.EventHandler(this.rdbtn_Price_CheckedChanged);
			// 
			// rdbtn_Litr
			// 
			this.rdbtn_Litr.AutoSize = true;
			this.rdbtn_Litr.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.rdbtn_Litr.Location = new System.Drawing.Point(6, 255);
			this.rdbtn_Litr.Name = "rdbtn_Litr";
			this.rdbtn_Litr.Size = new System.Drawing.Size(80, 35);
			this.rdbtn_Litr.TabIndex = 4;
			this.rdbtn_Litr.Text = "Litr";
			this.rdbtn_Litr.UseVisualStyleBackColor = true;
			this.rdbtn_Litr.CheckedChanged += new System.EventHandler(this.rdbtn_Litr_CheckedChanged);
			// 
			// cbox_Petrol
			// 
			this.cbox_Petrol.FormattingEnabled = true;
			this.cbox_Petrol.Location = new System.Drawing.Point(122, 101);
			this.cbox_Petrol.Name = "cbox_Petrol";
			this.cbox_Petrol.Size = new System.Drawing.Size(165, 44);
			this.cbox_Petrol.TabIndex = 5;
			this.cbox_Petrol.SelectedIndexChanged += new System.EventHandler(this.cbox_Petrol_SelectedIndexChanged);
			// 
			// tbox_PetrolPrice
			// 
			this.tbox_PetrolPrice.Location = new System.Drawing.Point(122, 157);
			this.tbox_PetrolPrice.Name = "tbox_PetrolPrice";
			this.tbox_PetrolPrice.Size = new System.Drawing.Size(125, 43);
			this.tbox_PetrolPrice.TabIndex = 6;
			// 
			// tbox_Amount
			// 
			this.tbox_Amount.Location = new System.Drawing.Point(151, 208);
			this.tbox_Amount.Name = "tbox_Amount";
			this.tbox_Amount.Size = new System.Drawing.Size(96, 43);
			this.tbox_Amount.TabIndex = 7;
			this.tbox_Amount.TextChanged += new System.EventHandler(this.tbox_Amount_TextChanged);
			// 
			// tbox_Litr
			// 
			this.tbox_Litr.Location = new System.Drawing.Point(122, 255);
			this.tbox_Litr.Name = "tbox_Litr";
			this.tbox_Litr.Size = new System.Drawing.Size(125, 43);
			this.tbox_Litr.TabIndex = 8;
			this.tbox_Litr.TextChanged += new System.EventHandler(this.tbox_Litr_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(257, 211);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 31);
			this.label4.TabIndex = 9;
			this.label4.Text = "AZN";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label6.Location = new System.Drawing.Point(257, 257);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 31);
			this.label6.TabIndex = 11;
			this.label6.Text = "L";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label7.Location = new System.Drawing.Point(257, 159);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(75, 31);
			this.label7.TabIndex = 12;
			this.label7.Text = "AZN";
			// 
			// lbl_TotalPetrolPrice
			// 
			this.lbl_TotalPetrolPrice.AutoSize = true;
			this.lbl_TotalPetrolPrice.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbl_TotalPetrolPrice.Location = new System.Drawing.Point(106, 78);
			this.lbl_TotalPetrolPrice.Name = "lbl_TotalPetrolPrice";
			this.lbl_TotalPetrolPrice.Size = new System.Drawing.Size(27, 31);
			this.lbl_TotalPetrolPrice.TabIndex = 13;
			this.lbl_TotalPetrolPrice.Text = "0";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label8.Location = new System.Drawing.Point(196, 78);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(75, 31);
			this.label8.TabIndex = 14;
			this.label8.Text = "AZN";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.rdbtn_Price);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.rdbtn_Litr);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cbox_Petrol);
			this.groupBox1.Controls.Add(this.tbox_Litr);
			this.groupBox1.Controls.Add(this.tbox_PetrolPrice);
			this.groupBox1.Controls.Add(this.tbox_Amount);
			this.groupBox1.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.groupBox1.Location = new System.Drawing.Point(6, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(455, 481);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Oil Station";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lbl_TotalPetrolPrice);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Location = new System.Drawing.Point(16, 316);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(414, 125);
			this.groupBox2.TabIndex = 16;
			this.groupBox2.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Yellow;
			this.groupBox3.Controls.Add(this.tbox_ColaPrice);
			this.groupBox3.Controls.Add(this.tbox_FrenchFPrice);
			this.groupBox3.Controls.Add(this.tbox_HamburgerPrice);
			this.groupBox3.Controls.Add(this.tbox_HotdogPrice);
			this.groupBox3.Controls.Add(this.tbox_Cola);
			this.groupBox3.Controls.Add(this.tbox_FrenchFries);
			this.groupBox3.Controls.Add(this.tbox_Hamburger);
			this.groupBox3.Controls.Add(this.tbox_Hotdog);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.chckbox_Cola);
			this.groupBox3.Controls.Add(this.chckbox_FrencFries);
			this.groupBox3.Controls.Add(this.chckbox_Hamburger);
			this.groupBox3.Controls.Add(this.chckbox_Hotdog);
			this.groupBox3.Controls.Add(this.groupBox4);
			this.groupBox3.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.groupBox3.Location = new System.Drawing.Point(467, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(470, 481);
			this.groupBox3.TabIndex = 16;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Mini Cafe";
			// 
			// tbox_ColaPrice
			// 
			this.tbox_ColaPrice.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tbox_ColaPrice.Location = new System.Drawing.Point(260, 245);
			this.tbox_ColaPrice.Name = "tbox_ColaPrice";
			this.tbox_ColaPrice.ReadOnly = true;
			this.tbox_ColaPrice.Size = new System.Drawing.Size(59, 34);
			this.tbox_ColaPrice.TabIndex = 30;
			this.tbox_ColaPrice.Text = "5.40";
			// 
			// tbox_FrenchFPrice
			// 
			this.tbox_FrenchFPrice.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tbox_FrenchFPrice.Location = new System.Drawing.Point(260, 194);
			this.tbox_FrenchFPrice.Name = "tbox_FrenchFPrice";
			this.tbox_FrenchFPrice.ReadOnly = true;
			this.tbox_FrenchFPrice.Size = new System.Drawing.Size(59, 34);
			this.tbox_FrenchFPrice.TabIndex = 29;
			this.tbox_FrenchFPrice.Text = "7.20";
			// 
			// tbox_HamburgerPrice
			// 
			this.tbox_HamburgerPrice.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tbox_HamburgerPrice.Location = new System.Drawing.Point(260, 145);
			this.tbox_HamburgerPrice.Name = "tbox_HamburgerPrice";
			this.tbox_HamburgerPrice.ReadOnly = true;
			this.tbox_HamburgerPrice.Size = new System.Drawing.Size(59, 34);
			this.tbox_HamburgerPrice.TabIndex = 28;
			this.tbox_HamburgerPrice.Text = "5.40";
			// 
			// tbox_HotdogPrice
			// 
			this.tbox_HotdogPrice.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tbox_HotdogPrice.Location = new System.Drawing.Point(260, 96);
			this.tbox_HotdogPrice.Name = "tbox_HotdogPrice";
			this.tbox_HotdogPrice.ReadOnly = true;
			this.tbox_HotdogPrice.Size = new System.Drawing.Size(59, 34);
			this.tbox_HotdogPrice.TabIndex = 27;
			this.tbox_HotdogPrice.Text = "4.00";
			// 
			// tbox_Cola
			// 
			this.tbox_Cola.Location = new System.Drawing.Point(360, 245);
			this.tbox_Cola.Name = "tbox_Cola";
			this.tbox_Cola.Size = new System.Drawing.Size(94, 43);
			this.tbox_Cola.TabIndex = 26;
			this.tbox_Cola.TextChanged += new System.EventHandler(this.tbox_Cola_TextChanged);
			// 
			// tbox_FrenchFries
			// 
			this.tbox_FrenchFries.Location = new System.Drawing.Point(360, 194);
			this.tbox_FrenchFries.Name = "tbox_FrenchFries";
			this.tbox_FrenchFries.Size = new System.Drawing.Size(94, 43);
			this.tbox_FrenchFries.TabIndex = 25;
			this.tbox_FrenchFries.TextChanged += new System.EventHandler(this.tbox_FrenchFries_TextChanged);
			// 
			// tbox_Hamburger
			// 
			this.tbox_Hamburger.Location = new System.Drawing.Point(360, 145);
			this.tbox_Hamburger.Name = "tbox_Hamburger";
			this.tbox_Hamburger.Size = new System.Drawing.Size(94, 43);
			this.tbox_Hamburger.TabIndex = 24;
			this.tbox_Hamburger.TextChanged += new System.EventHandler(this.tbox_Hamburger_TextChanged);
			// 
			// tbox_Hotdog
			// 
			this.tbox_Hotdog.Location = new System.Drawing.Point(360, 96);
			this.tbox_Hotdog.Name = "tbox_Hotdog";
			this.tbox_Hotdog.Size = new System.Drawing.Size(94, 43);
			this.tbox_Hotdog.TabIndex = 23;
			this.tbox_Hotdog.TextChanged += new System.EventHandler(this.tbox_Hotdog_TextChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Ravie", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.label11.Location = new System.Drawing.Point(348, 48);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(106, 32);
			this.label11.TabIndex = 22;
			this.label11.Text = "Count";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Ravie", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.label10.Location = new System.Drawing.Point(218, 48);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(101, 32);
			this.label10.TabIndex = 21;
			this.label10.Text = "Price";
			// 
			// chckbox_Cola
			// 
			this.chckbox_Cola.AutoSize = true;
			this.chckbox_Cola.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.chckbox_Cola.Location = new System.Drawing.Point(32, 245);
			this.chckbox_Cola.Name = "chckbox_Cola";
			this.chckbox_Cola.Size = new System.Drawing.Size(149, 30);
			this.chckbox_Cola.TabIndex = 20;
			this.chckbox_Cola.Text = "Coca-Cola";
			this.chckbox_Cola.UseVisualStyleBackColor = true;
			// 
			// chckbox_FrencFries
			// 
			this.chckbox_FrencFries.AutoSize = true;
			this.chckbox_FrencFries.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.chckbox_FrencFries.Location = new System.Drawing.Point(32, 194);
			this.chckbox_FrencFries.Name = "chckbox_FrencFries";
			this.chckbox_FrencFries.Size = new System.Drawing.Size(180, 30);
			this.chckbox_FrencFries.TabIndex = 19;
			this.chckbox_FrencFries.Text = "French Fries";
			this.chckbox_FrencFries.UseVisualStyleBackColor = true;
			// 
			// chckbox_Hamburger
			// 
			this.chckbox_Hamburger.AutoSize = true;
			this.chckbox_Hamburger.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.chckbox_Hamburger.Location = new System.Drawing.Point(32, 145);
			this.chckbox_Hamburger.Name = "chckbox_Hamburger";
			this.chckbox_Hamburger.Size = new System.Drawing.Size(167, 30);
			this.chckbox_Hamburger.TabIndex = 18;
			this.chckbox_Hamburger.Text = "Hamburger";
			this.chckbox_Hamburger.UseVisualStyleBackColor = true;
			// 
			// chckbox_Hotdog
			// 
			this.chckbox_Hotdog.AutoSize = true;
			this.chckbox_Hotdog.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.chckbox_Hotdog.Location = new System.Drawing.Point(32, 96);
			this.chckbox_Hotdog.Name = "chckbox_Hotdog";
			this.chckbox_Hotdog.Size = new System.Drawing.Size(122, 30);
			this.chckbox_Hotdog.TabIndex = 17;
			this.chckbox_Hotdog.Text = "HotDog";
			this.chckbox_Hotdog.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.lbl_TotalFoodPrice);
			this.groupBox4.Controls.Add(this.label9);
			this.groupBox4.Location = new System.Drawing.Point(32, 316);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(398, 125);
			this.groupBox4.TabIndex = 16;
			this.groupBox4.TabStop = false;
			// 
			// lbl_TotalFoodPrice
			// 
			this.lbl_TotalFoodPrice.AutoSize = true;
			this.lbl_TotalFoodPrice.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbl_TotalFoodPrice.Location = new System.Drawing.Point(120, 78);
			this.lbl_TotalFoodPrice.Name = "lbl_TotalFoodPrice";
			this.lbl_TotalFoodPrice.Size = new System.Drawing.Size(27, 31);
			this.lbl_TotalFoodPrice.TabIndex = 13;
			this.lbl_TotalFoodPrice.Text = "0";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label9.Location = new System.Drawing.Point(228, 78);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(75, 31);
			this.label9.TabIndex = 14;
			this.label9.Text = "AZN";
			// 
			// groupBox5
			// 
			this.groupBox5.BackgroundImage = global::WinForms_Homework_3_BestOil.Properties.Resources.OIP;
			this.groupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.groupBox5.Controls.Add(this.btn_Calculate);
			this.groupBox5.Controls.Add(this.groupBox6);
			this.groupBox5.Font = new System.Drawing.Font("Garamond", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.groupBox5.Location = new System.Drawing.Point(13, 499);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(914, 198);
			this.groupBox5.TabIndex = 17;
			this.groupBox5.TabStop = false;
			// 
			// btn_Calculate
			// 
			this.btn_Calculate.BackColor = System.Drawing.Color.Lime;
			this.btn_Calculate.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_Calculate.Location = new System.Drawing.Point(254, 50);
			this.btn_Calculate.Name = "btn_Calculate";
			this.btn_Calculate.Size = new System.Drawing.Size(194, 142);
			this.btn_Calculate.TabIndex = 18;
			this.btn_Calculate.Text = "Calculate";
			this.btn_Calculate.UseVisualStyleBackColor = false;
			this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
			// 
			// groupBox6
			// 
			this.groupBox6.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.groupBox6.Controls.Add(this.lbl_TotalPrice);
			this.groupBox6.Controls.Add(this.label14);
			this.groupBox6.Location = new System.Drawing.Point(504, 50);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(404, 137);
			this.groupBox6.TabIndex = 17;
			this.groupBox6.TabStop = false;
			// 
			// lbl_TotalPrice
			// 
			this.lbl_TotalPrice.AutoSize = true;
			this.lbl_TotalPrice.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbl_TotalPrice.Location = new System.Drawing.Point(102, 80);
			this.lbl_TotalPrice.Name = "lbl_TotalPrice";
			this.lbl_TotalPrice.Size = new System.Drawing.Size(27, 31);
			this.lbl_TotalPrice.TabIndex = 13;
			this.lbl_TotalPrice.Text = "0";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label14.Location = new System.Drawing.Point(210, 80);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(75, 31);
			this.label14.TabIndex = 14;
			this.label14.Text = "AZN";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(938, 698);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.ResumeLayout(false);

	}

	#endregion
	private Label label2;
	private Label label3;
	private RadioButton rdbtn_Price;
	private RadioButton rdbtn_Litr;
	private ComboBox cbox_Petrol;
	private TextBox tbox_PetrolPrice;
	private TextBox tbox_Amount;
	private TextBox tbox_Litr;
	private Label label4;
	private Label label6;
	private Label label7;
	private Label lbl_TotalPetrolPrice;
	private Label label8;
	private GroupBox groupBox1;
	private GroupBox groupBox2;
	private GroupBox groupBox3;
	private TextBox tbox_ColaPrice;
	private TextBox tbox_FrenchFPrice;
	private TextBox tbox_HamburgerPrice;
	private TextBox tbox_HotdogPrice;
	private TextBox tbox_Cola;
	private TextBox tbox_FrenchFries;
	private TextBox tbox_Hamburger;
	private TextBox tbox_Hotdog;
	private Label label11;
	private Label label10;
	private CheckBox chckbox_Cola;
	private CheckBox chckbox_FrencFries;
	private CheckBox chckbox_Hamburger;
	private CheckBox chckbox_Hotdog;
	private GroupBox groupBox4;
	private Label lbl_TotalFoodPrice;
	private Label label9;
	private GroupBox groupBox5;
	private GroupBox groupBox6;
	private Label lbl_TotalPrice;
	private Label label14;
	private Button btn_Calculate;
}