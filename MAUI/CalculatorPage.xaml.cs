namespace MAUI;

public partial class CalculatorPage : ContentPage
{
    public CalculatorPage()
    {
        InitializeComponent();
    }


    private void OnNumberClicked(object sender, EventArgs e)
    {
        if (sender is Button button)
        {
            inputEntry.Text += button.Text;
        }
    }

    private void OnSymbolClicked(object sender, EventArgs e)
    {
        if (sender is Button button)
        {
            inputEntry.Text += button.Text;
        }
    }


    private void OnClearClicked(object sender, EventArgs e)
    {
        inputEntry.Text = string.Empty;
    }
}