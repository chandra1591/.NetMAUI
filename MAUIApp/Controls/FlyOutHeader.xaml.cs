
namespace MyMAUIApp.Controls;
public partial class FlyOutHeader : StackLayout
{
	public FlyOutHeader()
	{
		InitializeComponent();
		SetValues();
	}

    private void SetValues()
    {
        if(App.CurrentUser != null)
		{
			lblUserName.Text = App.CurrentUser.Username;
			lblRole.Text = App.CurrentUser.Role;
		}
    }
}