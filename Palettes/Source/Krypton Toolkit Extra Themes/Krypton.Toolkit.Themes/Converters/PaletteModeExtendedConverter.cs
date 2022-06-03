namespace Krypton.Toolkit.Themes
{
    /// <summary>Custom type converter so that PaletteModeExtended values appear as neat text at design time.</summary>
    internal class PaletteModeExtendedConverter : StringLookupConverter
    {
        #region Static Fields

        /// <summary>Converts the <see cref="Toolkit.PaletteMode"/> values into a human readable format.</summary>
        private readonly Pair[] _pairs =
        {
            new(PaletteModeExtended.ProfessionalSystem, "Professional - System"),
            new(PaletteModeExtended.ProfessionalOffice2003, "Professional - Office 2003"),
            new(PaletteModeExtended.Office2007DarkGray, "Office 2007 - Dark Grey"),
            new(PaletteModeExtended.Office2007LightGray, "Office 2007 - Light Grey"),
            new(PaletteModeExtended.Office2007Access, "Office 2007 - Access"),
            new(PaletteModeExtended.Office2007Excel, "Office 2007 - Excel"),
            new(PaletteModeExtended.Office2007Groove, "Office 2007 - Groove"),
            new(PaletteModeExtended.Office2007InfoPath, "Office 2007 - InfoPath"),
            new(PaletteModeExtended.Office2007OneNote, "Office 2007 - OneNote"),
            new(PaletteModeExtended.Office2007Outlook, "Office 2007 - Outlook"),
            new(PaletteModeExtended.Office2007PowerPoint, "Office 2007 - PowerPoint"),
            new(PaletteModeExtended.Office2007Project, "Office 2007 - Project"),
            new(PaletteModeExtended.Office2007Publisher, "Office 2007 - Publisher"),
            new(PaletteModeExtended.Office2007Visio, "Office 2007 - Visio"),
            new(PaletteModeExtended.Office2007Word, "Office 2007 - Word"),
            new(PaletteModeExtended.Office2007Blue, "Office 2007 - Blue"),
            new(PaletteModeExtended.Office2007BlueDarkMode, "Office 2007 - Blue (Dark Mode)"),
            new(PaletteModeExtended.Office2007BlueLightMode, "Office 2007 - Blue (Light Mode)"),
            new(PaletteModeExtended.Office2007Silver, "Office 2007 - Silver"),
            new(PaletteModeExtended.Office2007SilverDarkMode, "Office 2007 - Silver (Dark Mode)"),
            new(PaletteModeExtended.Office2007SilverLightMode, "Office 2007 - Silver (Light Mode)"),
            new(PaletteModeExtended.Office2007White, "Office 2007 - White"),
            new(PaletteModeExtended.Office2007Black, "Office 2007 - Black"),
            new(PaletteModeExtended.Office2007BlackDarkMode, "Office 2007 - Black (Dark Mode)"),
            new(PaletteModeExtended.Office2010DarkGray, "Office 2010 - Dark Grey"),
            new(PaletteModeExtended.Office2010LightGray, "Office 2010 - Light Grey"),
            new(PaletteModeExtended.Office2010Access, "Office 2010 - Access"),
            new(PaletteModeExtended.Office2010Excel, "Office 2010 - Excel"),
            new(PaletteModeExtended.Office2010InfoPath, "Office 2010 - InfoPath"),
            new(PaletteModeExtended.Office2010OneNote, "Office 2010 - OneNote"),
            new(PaletteModeExtended.Office2010Outlook, "Office 2010 - Outlook"),
            new(PaletteModeExtended.Office2010PowerPoint, "Office 2010 - PowerPoint"),
            new(PaletteModeExtended.Office2010Project, "Office 2010 - Project"),
            new(PaletteModeExtended.Office2010Publisher, "Office 2010 - Publisher"),
            new(PaletteModeExtended.Office2010SharePoint, "Office 2010 - SharePoint"),
            new(PaletteModeExtended.Office2010Visio, "Office 2010 - Visio"),
            new(PaletteModeExtended.Office2010Word, "Office 2010 - Word"),
            new(PaletteModeExtended.Office2010Blue, "Office 2010 - Blue"),
            new(PaletteModeExtended.Office2010BlueDarkMode, "Office 2010 - Blue (Dark Mode)"),
            new(PaletteModeExtended.Office2010BlueLightMode, "Office 2010 - Blue (Light Mode)"),
            new(PaletteModeExtended.Office2010Silver, "Office 2010 - Silver"),
            new(PaletteModeExtended.Office2010SilverDarkMode, "Office 2010 - Silver (Dark Mode)"),
            new(PaletteModeExtended.Office2010SilverLightMode, "Office 2010 - Silver (Light Mode)"),
            new(PaletteModeExtended.Office2010White, "Office 2010 - White"),
            new(PaletteModeExtended.Office2010Black, "Office 2010 - Black"),
            new(PaletteModeExtended.Office2010BlackDarkMode, "Office 2010 - Black (Dark Mode)"),
            new(PaletteModeExtended.Office2013DarkGray, "Office 2013 - Dark Grey"),
            new(PaletteModeExtended.Office2013LightGray, "Office 2013 - Light Grey"),
            new(PaletteModeExtended.Office2013Access, "Office 2013 - Access"),
            new(PaletteModeExtended.Office2013AccessLegacy, "Office 2013 - Access (Pre-2013 colours)"),
            new(PaletteModeExtended.Office2013Excel, "Office 2013 - Excel"),
            new(PaletteModeExtended.Office2013InfoPath, "Office 2013 - InfoPath"),
            new(PaletteModeExtended.Office2013Lync, "Office 2013 - Lync"),
            new(PaletteModeExtended.Office2013OneNote, "Office 2013 - OneNote"),
            new(PaletteModeExtended.Office2013Outlook, "Office 2013 - Outlook"),
            new(PaletteModeExtended.Office2013PowerPoint, "Office 2013 - PowerPoint"),
            new(PaletteModeExtended.Office2013Project, "Office 2013 - Project"),
            new(PaletteModeExtended.Office2013Publisher, "Office 2013 - Publisher"),
            new(PaletteModeExtended.Office2013SharePoint, "Office 2013 - SharePoint"),
            new(PaletteModeExtended.Office2013Visio, "Office 2013 - Visio"),
            new(PaletteModeExtended.Office2013Word, "Office 2013 - Word"),
            new(PaletteModeExtended.Office2013White, "Office 2013 - White"),
            new(PaletteModeExtended.Office365DarkGray, "Office 365 - Dark Grey"),
            new(PaletteModeExtended.Office365LightGray, "Office 365 - Light Grey"),
            new(PaletteModeExtended.Office365Access, "Office 365 - Access"),
            new(PaletteModeExtended.Office2013AccessLegacy, "Office 365 - Access (Pre-2013 colours)"),
            new(PaletteModeExtended.Office365Excel, "Office 365 - Excel"),
            new(PaletteModeExtended.Office365InfoPath, "Office 365 - InfoPath"),
            new(PaletteModeExtended.Office365Lync, "Office 365 - Lync"),
            new(PaletteModeExtended.Office365OneNote, "Office 365 - OneNote"),
            new(PaletteModeExtended.Office365Outlook, "Office 365 - Outlook"),
            new(PaletteModeExtended.Office365PowerPoint, "Office 365 - PowerPoint"),
            new(PaletteModeExtended.Office365Project, "Office 365 - Project"),
            new(PaletteModeExtended.Office365Publisher, "Office 365 - Publisher"),
            new(PaletteModeExtended.Office365SharePoint, "Office 365 - SharePoint"),
            new(PaletteModeExtended.Office365Visio, "Office 365 - Visio"),
            new(PaletteModeExtended.Office365Word, "Office 365 - Word"),
            new(PaletteModeExtended.Office365Black, "Office 365 - Black"),
            new(PaletteModeExtended.Office365BlackDarkMode, "Office 365 - Black (Dark Mode)"),
            new(PaletteModeExtended.Office365Blue, "Office 365 - Blue"),
            new(PaletteModeExtended.Office365BlueDarkMode, "Office 365 - Blue (Dark Mode)"),
            new(PaletteModeExtended.Office365BlueLightMode, "Office 365 - Blue (Light Mode)"),
            new(PaletteModeExtended.Office365Silver, "Office 365 - Silver"),
            new(PaletteModeExtended.Office365SilverDarkMode, "Office 365 - Silver (Dark Mode)"),
            new(PaletteModeExtended.Office365SilverLightMode, "Office 365 - Silver (Light Mode)"),
            new(PaletteModeExtended.Office365White, "Office 365 - White"),
            new(PaletteModeExtended.SparkleBlue, "Sparkle - Blue"),
            new(PaletteModeExtended.SparkleBlueDarkMode, "Sparkle - Blue (Dark Mode)"),
            new(PaletteModeExtended.SparkleBlueLightMode, "Sparkle - Blue (Light Mode)"),
            new(PaletteModeExtended.SparkleOrange, "Sparkle - Orange"),
            new(PaletteModeExtended.SparkleOrangeDarkMode, "Sparkle - Orange (Dark Mode)"),
            new(PaletteModeExtended.SparkleOrangeLightMode, "Sparkle - Orange (Light Mode)"),
            new(PaletteModeExtended.SparklePurple, "Sparkle - Purple"),
            new(PaletteModeExtended.SparklePurpleDarkMode, "Sparkle - Purple (Dark Mode)"),
            new(PaletteModeExtended.SparklePurpleLightMode, "Sparkle - Purple (Light Mode)")
            //new(PaletteModeExtended.VisualStudioDark,      "Visual Studio (Dark Mode)"),
            //new(PaletteModeExtended.VisualStudioLight,     "Visual Studio (Light Mode)")
        };
        #endregion

        #region Identity

        /// <summary>Initializes a new instance of the <see cref="PaletteModeExtendedConverter" /> class.</summary>
        public PaletteModeExtendedConverter() : base(typeof(PaletteModeExtended))
        {
        }

        #endregion

        #region Protected

        /// <summary>Gets an array of lookup pairs.</summary>
        protected override Pair[] Pairs => _pairs;

        #endregion
    }
}
