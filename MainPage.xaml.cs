namespace MAUI_Layout_VHStackLayoutEx
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private async void btSubmit_Clicked(object? sender, EventArgs e)
		{
			string name = enFullName.Text?.Trim() ?? string.Empty;
			string email = enEmail.Text?.Trim() ?? string.Empty;
			if (name.Length == 0 || email.Length == 0)
			{
				await DisplayAlertAsync("Registration", "Please fill in both fields.", "OK");
				return;
			}
			await DisplayAlertAsync("Registration", $"Name: {name}\nEmail: {email}", "OK");
		}

		private void btCancel_Clicked(object? sender, EventArgs e)
		{
			enFullName.Text = string.Empty;
			enEmail.Text = string.Empty;
		}
	}
}
