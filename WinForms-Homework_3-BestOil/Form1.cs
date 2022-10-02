namespace WinForms_Homework_3_BestOil;

public partial class Form1 : Form
{
	public Form1()
	{
		InitializeComponent();
	}

	List<string> petrolNames = new() { "AI-92", "AI-95", "AI-98" };
	List<string> price = new() { "0.90", "1.20", "1.90" };

	private void Form1_Load(object sender, EventArgs e)
	{
		cbox_Petrol.DataSource = petrolNames;
	}

	private void cbox_Petrol_SelectedIndexChanged(object sender, EventArgs e)
	{
		var choice = cbox_Petrol.SelectedItem;

		if (choice == petrolNames[0])
			tbox_PetrolPrice.Text = price[0].ToString();
		else if (choice == petrolNames[1])
			tbox_PetrolPrice.Text = price[1].ToString();
		else if (choice == petrolNames[2])
			tbox_PetrolPrice.Text = price[2].ToString();
	}

	private void tbox_Amount_TextChanged(object sender, EventArgs e)
	{
		lbl_TotalPetrolPrice.Text = tbox_Amount.Text;
	}

	private void tbox_Litr_TextChanged(object sender, EventArgs e)
	{
		lbl_TotalPetrolPrice.Text = (Convert.ToDouble(tbox_PetrolPrice.Text) * Convert.ToDouble(tbox_Litr.Text)).ToString();
	}

	private void rdbtn_Price_CheckedChanged(object sender, EventArgs e)
	{
		tbox_Litr.Text = "";
	}

	private void rdbtn_Litr_CheckedChanged(object sender, EventArgs e)
	{
		tbox_Amount.Text = "";
	}

	private void tbox_Hotdog_TextChanged(object sender, EventArgs e)
	{
		var price = double.Parse(lbl_TotalFoodPrice.Text) + (double.Parse(tbox_Hotdog.Text) * double.Parse(tbox_HotdogPrice.Text));

		if (chckbox_Hotdog.Checked == true)
			lbl_TotalFoodPrice.Text = price.ToString();
	}

	private void tbox_Hamburger_TextChanged(object sender, EventArgs e)
	{
		var price = double.Parse(lbl_TotalFoodPrice.Text) + (double.Parse(tbox_Hamburger.Text) * double.Parse(tbox_HamburgerPrice.Text));
		
		if (chckbox_Hamburger.Checked == true)
			lbl_TotalFoodPrice.Text = price.ToString();
	}

	private void tbox_FrenchFries_TextChanged(object sender, EventArgs e)
	{
		var price = double.Parse(lbl_TotalFoodPrice.Text) + (double.Parse(tbox_FrenchFries.Text) * double.Parse(tbox_FrenchFPrice.Text));
		
		if (chckbox_FrencFries.Checked == true)
			lbl_TotalFoodPrice.Text = price.ToString();
	}

	private void tbox_Cola_TextChanged(object sender, EventArgs e)
	{
		var price = double.Parse(lbl_TotalFoodPrice.Text) + (double.Parse(tbox_Cola.Text) * double.Parse(tbox_ColaPrice.Text));
		
		if (chckbox_Cola.Checked == true)
			lbl_TotalFoodPrice.Text = price.ToString();
	}

	private void btn_Calculate_Click(object sender, EventArgs e)
	{
		lbl_TotalPrice.Text = (Convert.ToDouble(lbl_TotalFoodPrice.Text) + Convert.ToDouble(lbl_TotalPetrolPrice.Text)).ToString();
	}
}