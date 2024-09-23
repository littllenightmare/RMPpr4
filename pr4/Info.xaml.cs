
namespace pr4;

public partial class Info : ContentPage
{
	public Info()
	{
		InitializeComponent();
	}
    private void ShowItems(object sender, ToggledEventArgs e)
    {
        if (sw.IsToggled == false)
        {
            slmain.IsVisible = false;
        }
        else slmain.IsVisible = true;
    }
}