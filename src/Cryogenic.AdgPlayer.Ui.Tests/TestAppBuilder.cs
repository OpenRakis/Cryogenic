using Avalonia;
using Avalonia.Headless;

using Cryogenic.AdgPlayer.Ui.Tests;

[assembly: AvaloniaTestApplication(typeof(TestAppBuilder))]

namespace Cryogenic.AdgPlayer.Ui.Tests;

/// <summary>
/// Avalonia headless test bootstrap. Reuses the production
/// <see cref="Cryogenic.AdgPlayer.Ui.App"/> XAML resources but
/// substitutes the headless platform for windowing so that
/// <c>[AvaloniaFact]</c>/<c>[AvaloniaTheory]</c> tests can
/// instantiate windows in CI without a display.
/// </summary>
public static class TestAppBuilder {
	/// <summary>Builds the Avalonia <see cref="AppBuilder"/> used by the test runner.</summary>
	public static AppBuilder BuildAvaloniaApp() {
		return AppBuilder.Configure<Cryogenic.AdgPlayer.Ui.App>()
			.UseHeadless(new AvaloniaHeadlessPlatformOptions());
	}
}