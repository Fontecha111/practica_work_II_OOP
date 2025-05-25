using oppguidedpw;
namespace MAUI;

public partial class CalculatorPage : ContentPage
{

    private User currentUser = new User("", "", "");
    private Converter converter = new Converter();
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

    private async void OnDecimalToBinaryClicked(object sender, EventArgs e)
    {
        string input = inputEntry.Text;
        string result = converter.PerformConversion(1, input);
        resultLabel.Text = $"Binary: {result}";
    }

    private async void OnDecimalToOctalClicked(object sender, EventArgs e)
    {
        string input = inputEntry.Text;
        string result = converter.PerformConversion(2, input);
        resultLabel.Text = $"Octal: {result}";
    }

    private async void OnDecimalToHexadecimalClicked(object sender, EventArgs e)
    {
        string input = inputEntry.Text;
        string result = converter.PerformConversion(3, input);
        resultLabel.Text = $"Hexadecimal: {result}";
    }

    private async void OnDecimalToTwoComplementClicked(object sender, EventArgs e)
    {
        string input = inputEntry.Text;
        string result = converter.PerformConversion(4, input);
        resultLabel.Text = $"Two Complement: {result}";
    }

    private async void OnBinaryToDecimalClicked(object sender, EventArgs e)
    {
        string input = inputEntry.Text;
        string result = converter.PerformConversion(5, input);
        resultLabel.Text = $"Decimal: {result}";
    }

    private async void OnOctalToDecimalClicked(object sender, EventArgs e)
    {
        string input = inputEntry.Text;
        string result = converter.PerformConversion(6, input);
        resultLabel.Text = $"Decimal: {result}";
    }

    private async void OnHexadecimalToDecimalClicked(object sender, EventArgs e)
    {
        string input = inputEntry.Text;
        string result = converter.PerformConversion(7, input);
        resultLabel.Text = $"Decimal: {result}";
    }

    private async void OnTwoComplementToDecimalClicked(object sender, EventArgs e)
    {
        string input = inputEntry.Text;
        string result = converter.PerformConversion(8, input);
        resultLabel.Text = $"Decimal: {result}";
    }

    private async void OnShowUserInfoClicked(object sender, EventArgs e)
    {
        string info = $"Name: {currentUser.getName()}\n" + $"Username: {currentUser.getUsername()}\n" + $"Password: {currentUser.getPassword()}\n" + $"Operations: {currentUser.getOperationCount()}";

        await DisplayAlert("User Info", info, "OK");
    }
}