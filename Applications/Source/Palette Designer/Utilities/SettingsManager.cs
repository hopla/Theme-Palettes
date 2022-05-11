using System.Windows.Forms;
using Krypton.Toolkit;
using PaletteDesigner.Properties;

namespace PaletteDesigner
{
    public class SettingsManager
    {
        #region Instance Fields

        private Settings _settings = null;

        #endregion

        #region Identity

        /// <summary>Initializes a new instance of the <see cref="SettingsManager" /> class.</summary>
        public SettingsManager()
        {
            _settings = new Settings();
        }

        #endregion

        #region Setters & Getters

        /// <summary>Sets the maximised.</summary>
        /// <param name="value">if set to <c>true</c> [value].</param>
        public void SetMaximised(bool value) => _settings.StartMaximised = value;

        /// <summary>Gets the maximised.</summary>
        public bool GetMaximised() => _settings.StartMaximised;

        /// <summary>Sets the selected theme mode.</summary>
        /// <param name="value">The value.</param>
        public void SetSelectedThemeMode(PaletteMode value) => _settings.SelectedThemeMode = value;

        /// <summary>Gets the selected theme mode.</summary>
        public PaletteMode GetSelectedThemeMode() => _settings.SelectedThemeMode;

        /// <summary>Sets the selected theme mode manager.</summary>
        /// <param name="value">The value.</param>
        public void SetSelectedThemeModeManager(PaletteModeManager value) => _settings.SelectedThemeModeManager = value;

        /// <summary>Gets the selected theme mode manager.</summary>
        public PaletteModeManager GetSelectedThemeModeManager() => _settings.SelectedThemeModeManager;

        #endregion

        #region Public

        /// <summary>Saves the settings.</summary>
        /// <param name="useConfirmation">if set to <c>true</c> [use confirmation].</param>
        public void SaveSettings(bool useConfirmation = false)
        {
            if (useConfirmation)
            {
                DialogResult result = KryptonMessageBox.Show("Do you want to save these settings with the current values?", "Save Settings", MessageBoxButtons.YesNo, KryptonMessageBoxIcon.QUESTION);

                if (result == DialogResult.Yes)
                {
                    _settings.Save();
                }
            }
            else
            {
                _settings.Save();
            }
        }

        /// <summary>Resets the settings.</summary>
        /// <param name="useConfirmation">if set to <c>true</c> [use confirmation].</param>
        public void ResetSettings(bool useConfirmation = false)
        {
            if (useConfirmation)
            {
                DialogResult result = KryptonMessageBox.Show("Do you want to reset these settings with the default values?", "Reset Settings", MessageBoxButtons.YesNo, KryptonMessageBoxIcon.QUESTION);

                if (result == DialogResult.Yes)
                {
                    SetMaximised(false);

                    SetSelectedThemeMode(PaletteMode.Office365Blue);

                    SetSelectedThemeModeManager(PaletteModeManager.Office365Blue);
                }
            }
            else
            {
                SetMaximised(false);

                SetSelectedThemeMode(PaletteMode.Office365Blue);

                SetSelectedThemeModeManager(PaletteModeManager.Office365Blue);
            }

            SaveSettings(useConfirmation);
        }

        #endregion
    }
}