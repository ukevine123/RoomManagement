using MudBlazor;

public class MyCustomTheme : MudTheme
{
    public MyCustomTheme()
    {
        PaletteLight = new PaletteLight()
        {
                // Primary Branding (Warm Peachy Tan)
                Primary = "#e3a387",
                PrimaryDarken = "#b05b46",
                PrimaryLighten = "#f5d6c9",

                // Secondary Branding (Complementary warm tan)
                Secondary = "#d4a574",
                
                // Tertiary / Accents (Warm taupe)
                Tertiary = "#c9b5a6",
                
                // Surfaces & Backgrounds
                Background = "#faf8f6",      // Warm off-white
                Surface = "#ffffff",
                AppbarBackground = "#5d3d2d", // Dark brown (complement to peachy)
                AppbarText = "#faf8f6",
                DrawerBackground = "#f0e8e0", // Light warm beige
                DrawerText = "#5d3d2d",
                
                // Typography & Interaction
                TextPrimary = "#3d2817",     // Dark brown
                TextSecondary = "#6b4423",   // Medium brown
                ActionDefault = "#b05b46",
                Divider = "#e8d9cc",         // Light tan
                
                Info = "#b08968",            // Warm muted brown
                Success = "#a89968",         // Warm golden tone
            };

            PaletteDark = new PaletteDark()
            {
                // Dark Mode Surfaces (Dark brown tones)
                Background = "#1a1410",      // Very dark brown
                Surface = "#2d1f15",         // Dark brown
                
                AppbarBackground = "#1a1410",
                DrawerBackground = "#2d1f15",

                // Primary Branding for Dark (Lighter peachy tones)
                Primary = "#f5c9a8",         // Light peachy
                Secondary = "#e8b896",       // Lighter tan
                Tertiary = "#d9cabb",        // Light taupe
                
                // Typography
                TextPrimary = "#faf8f6",     // Warm off-white
                TextSecondary = "#e8d9cc",   // Light tan
                Divider = "#3d2817",         // Dark brown
                ActionDefault = "#f5d6c9",
        };
    }
}