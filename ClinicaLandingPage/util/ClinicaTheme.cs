using MudBlazor;
using MudBlazor.Utilities;

namespace ClinicaLandingPage;

public class ClinicaTheme : MudTheme
{
    public ClinicaTheme()
    {
        // Paleta Clara (Ya funciona)
        PaletteLight.Primary = new MudColor("#3f65ff");
        PaletteLight.Secondary = new MudColor("#e4a4bb");
        PaletteLight.Background = new MudColor("#f6f8fc");
        PaletteLight.Surface = new MudColor("#ffffff");
        PaletteLight.AppbarBackground = new MudColor("#ffffff");
        PaletteLight.AppbarText = new MudColor("#1e2430");

        // Paleta Oscura (Mejorada para tu marca)
        PaletteDark.Primary = new MudColor("#3f65ff");
        PaletteDark.Secondary = new MudColor("#e4a4bb");
        PaletteDark.Background = new MudColor("#121212"); // Fondo casi negro
        PaletteDark.Surface = new MudColor("#1e1e1e");    // Tarjetas gris oscuro
        PaletteDark.AppbarBackground = new MudColor("#121212");
        PaletteDark.AppbarText = new MudColor("#ffffff");
        PaletteDark.DrawerBackground = new MudColor("#1e1e1e");
        PaletteDark.DrawerText = new MudColor("#ffffff");
        PaletteDark.TextPrimary = new MudColor("#ffffff");
        PaletteDark.TextSecondary = new MudColor("#a0aabf");
        
        Typography.Default.FontFamily = new[] { "Inter", "system-ui", "sans-serif" };
    }
}