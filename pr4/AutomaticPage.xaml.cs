namespace pr4;

public partial class AutomaticPage : ContentPage
{
	public AutomaticPage()
	{
		InitializeComponent();
	}
    private void ClearEntry(object sender, CheckedChangedEventArgs e)
    {
        enVy.Text = "";
        if (rb1.IsChecked) enVy.Text = "Вена";
        if (rb2.IsChecked) enVy.Text = "София";
        if (rb3.IsChecked) enVy.Text = "Афины";
        if (rb4.IsChecked) enVy.Text = "Рим";
        if (rb5.IsChecked) enVy.Text = "Осло";
        if (rb6.IsChecked) enVy.Text = "Варшава";
        if (rb7.IsChecked) enVy.Text = "Париж";
        if (rb8.IsChecked) enVy.Text = "Мадрид";
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