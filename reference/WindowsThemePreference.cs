using Microsoft.Win32;

namespace WKSorter.App.Theming;

internal sealed class WindowsThemePreference : IDisposable
{
    private const string PersonalizeKey =
        @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";

    public WindowsThemePreference()
    {
        SystemEvents.UserPreferenceChanged += OnUserPreferenceChanged;
    }

    public event EventHandler? ThemeChanged;

    public bool IsDarkTheme =>
        Registry.GetValue(PersonalizeKey, "AppsUseLightTheme", 1) is int value && value == 0;

    public void Dispose()
    {
        SystemEvents.UserPreferenceChanged -= OnUserPreferenceChanged;
    }

    private void OnUserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
    {
        if (e.Category is UserPreferenceCategory.Color or
            UserPreferenceCategory.General or
            UserPreferenceCategory.VisualStyle)
        {
            ThemeChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}