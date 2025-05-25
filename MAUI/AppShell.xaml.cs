using oppguidedpw;

namespace MAUI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
		Routing.RegisterRoute(nameof(CalculatorPage), typeof(CalculatorPage));
		Routing.RegisterRoute(nameof(ForgotPasswordPage), typeof(ForgotPasswordPage));
		Routing.RegisterRoute(nameof(Operations), typeof(Operations));

	}
}
