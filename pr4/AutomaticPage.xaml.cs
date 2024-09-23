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
        if (rb1.IsChecked) enVy.Text = "����";
        if (rb2.IsChecked) enVy.Text = "�����";
        if (rb3.IsChecked) enVy.Text = "�����";
        if (rb4.IsChecked) enVy.Text = "���";
        if (rb5.IsChecked) enVy.Text = "����";
        if (rb6.IsChecked) enVy.Text = "�������";
        if (rb7.IsChecked) enVy.Text = "�����";
        if (rb8.IsChecked) enVy.Text = "������";
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