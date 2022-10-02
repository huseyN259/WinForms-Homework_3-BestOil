namespace WinForms_Homework_3_BestOil;

static class Program
{
	[STAThread]
	static void Main()
	{
		ApplicationConfiguration.Initialize();
		Application.Run(new Form1());
	}
}