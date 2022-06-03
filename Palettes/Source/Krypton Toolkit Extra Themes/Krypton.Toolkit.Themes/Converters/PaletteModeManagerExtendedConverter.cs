namespace Krypton.Toolkit.Themes
{
    /// <summary>Custom type converter so that PaletteModeManagerExtended values appear as neat text at design time.</summary>
    internal class PaletteModeManagerExtendedConverter : StringLookupConverter
    {
        #region Static Fields

        private readonly Pair[] _pairs =
        {
            new(PaletteModeManagerExtended.ProfessionalSystem, "Professional - System"),
            new(PaletteModeManagerExtended.ProfessionalOffice2003, "Professional - Office 2003"),
            new(PaletteModeManagerExtended.Office2007DarkGray, "Office 2007 - Dark Grey"),
            new(PaletteModeManagerExtended.Office2007LightGray, "Office 2007 - Light Grey"),
            new(PaletteModeManagerExtended.Office2007Access, "Office 2007 - Access"),
            new(PaletteModeManagerExtended.Office2007Excel, "Office 2007 - Excel"),
            new(PaletteModeManagerExtended.Office2007Groove, "Office 2007 - Groove"),
            new(PaletteModeManagerExtended.Office2007InfoPath, "Office 2007 - InfoPath"),
            new(PaletteModeManagerExtended.Office2007OneNote, "Office 2007 - OneNote"),
            new(PaletteModeManagerExtended.Office2007Outlook, "Office 2007 - Outlook"),
            new(PaletteModeManagerExtended.Office2007PowerPoint, "Office 2007 - PowerPoint"),
            new(PaletteModeManagerExtended.Office2007Project, "Office 2007 - Project"),
            new(PaletteModeManagerExtended.Office2007Publisher, "Office 2007 - Publisher"),
            new(PaletteModeManagerExtended.Office2007Visio, "Office 2007 - Visio"),
            new(PaletteModeManagerExtended.Office2007Word, "Office 2007 - Word"),
            new(PaletteModeManagerExtended.Office2007Blue, "Office 2007 - Blue"),
            new(PaletteModeManagerExtended.Office2007BlueDarkMode, "Office 2007 - Blue (Dark Mode)"),
            new(PaletteModeManagerExtended.Office2007BlueLightMode, "Office 2007 - Blue (Light Mode)"),
            new(PaletteModeManagerExtended.Office2007Silver, "Office 2007 - Silver"),
            new(PaletteModeManagerExtended.Office2007SilverDarkMode, "Office 2007 - Silver (Dark Mode)"),
            new(PaletteModeManagerExtended.Office2007SilverLightMode, "Office 2007 - Silver (Light Mode)"),
            new(PaletteModeManagerExtended.Office2007White, "Office 2007 - White"),
            new(PaletteModeManagerExtended.Office2007Black, "Office 2007 - Black"),
            new(PaletteModeManagerExtended.Office2007BlackDarkMode, "Office 2007 - Black (Dark Mode)"),
            new(PaletteModeManagerExtended.Office2010DarkGray, "Office 2010 - Dark Grey"),
            new(PaletteModeManagerExtended.Office2010LightGray, "Office 2010 - Light Grey"),
            new(PaletteModeManagerExtended.Office2010Access, "Office 2010 - Access"),
            new(PaletteModeManagerExtended.Office2010Excel, "Office 2010 - Excel"),
            new(PaletteModeManagerExtended.Office2010InfoPath, "Office 2010 - InfoPath"),
            new(PaletteModeManagerExtended.Office2010OneNote, "Office 2010 - OneNote"),
            new(PaletteModeManagerExtended.Office2010Outlook, "Office 2010 - Outlook"),
            new(PaletteModeManagerExtended.Office2010PowerPoint, "Office 2010 - PowerPoint"),
            new(PaletteModeManagerExtended.Office2010Project, "Office 2010 - Project"),
            new(PaletteModeManagerExtended.Office2010Publisher, "Office 2010 - Publisher"),
            new(PaletteModeManagerExtended.Office2010SharePoint, "Office 2010 - SharePoint"),
            new(PaletteModeManagerExtended.Office2010Visio, "Office 2010 - Visio"),
            new(PaletteModeManagerExtended.Office2010Word, "Office 2010 - Word"),
            new(PaletteModeManagerExtended.Office2010Blue, "Office 2010 - Blue"),
            new(PaletteModeManagerExtended.Office2010BlueDarkMode, "Office 2010 - Blue (Dark Mode)"),
            new(PaletteModeManagerExtended.Office2010BlueLightMode, "Office 2010 - Blue (Light Mode)"),
            new(PaletteModeManagerExtended.Office2010Silver, "Office 2010 - Silver"),
            new(PaletteModeManagerExtended.Office2010SilverDarkMode, "Office 2010 - Silver (Dark Mode)"),
            new(PaletteModeManagerExtended.Office2010SilverLightMode, "Office 2010 - Silver (Light Mode)"),
            new(PaletteModeManagerExtended.Office2010White, "Office 2010 - White"),
            new(PaletteModeManagerExtended.Office2010Black, "Office 2010 - Black"),
            new(PaletteModeManagerExtended.Office2010BlackDarkMode, "Office 2010 - Black (Dark Mode)"),
            new(PaletteModeManagerExtended.Office2013DarkGray, "Office 2013 - Dark Grey"),
            new(PaletteModeManagerExtended.Office2013LightGray, "Office 2013 - Light Grey"),
            new(PaletteModeManagerExtended.Office2013Access, "Office 2013 - Access"),
            new(PaletteModeManagerExtended.Office2013AccessLegacy, "Office 2013 - Access (Pre-2013 colours)"),
            new(PaletteModeManagerExtended.Office2013Excel, "Office 2013 - Excel"),
            new(PaletteModeManagerExtended.Office2013InfoPath, "Office 2013 - InfoPath"),
            new(PaletteModeManagerExtended.Office2013Lync, "Office 2013 - Lync"),
            new(PaletteModeManagerExtended.Office2013OneNote, "Office 2013 - OneNote"),
            new(PaletteModeManagerExtended.Office2013Outlook, "Office 2013 - Outlook"),
            new(PaletteModeManagerExtended.Office2013PowerPoint, "Office 2013 - PowerPoint"),
            new(PaletteModeManagerExtended.Office2013Project, "Office 2013 - Project"),
            new(PaletteModeManagerExtended.Office2013Publisher, "Office 2013 - Publisher"),
            new(PaletteModeManagerExtended.Office2013SharePoint, "Office 2013 - SharePoint"),
            new(PaletteModeManagerExtended.Office2013Visio, "Office 2013 - Visio"),
            new(PaletteModeManagerExtended.Office2013Word, "Office 2013 - Word"),
            new(PaletteModeManagerExtended.Office2013White, "Office 2013 - White"),
            new(PaletteModeManagerExtended.Office365DarkGray, "Office 365 - Dark Grey"),
            new(PaletteModeManagerExtended.Office365LightGray, "Office 365 - Light Grey"),
            new(PaletteModeManagerExtended.Office365Access, "Office 365 - Access"),
            new(PaletteModeManagerExtended.Office2013AccessLegacy, "Office 365 - Access (Pre-2013 colours)"),
            new(PaletteModeManagerExtended.Office365Excel, "Office 365 - Excel"),
            new(PaletteModeManagerExtended.Office365InfoPath, "Office 365 - InfoPath"),
            new(PaletteModeManagerExtended.Office365Lync, "Office 365 - Lync"),
            new(PaletteModeManagerExtended.Office365OneNote, "Office 365 - OneNote"),
            new(PaletteModeManagerExtended.Office365Outlook, "Office 365 - Outlook"),
            new(PaletteModeManagerExtended.Office365PowerPoint, "Office 365 - PowerPoint"),
            new(PaletteModeManagerExtended.Office365Project, "Office 365 - Project"),
            new(PaletteModeManagerExtended.Office365Publisher, "Office 365 - Publisher"),
            new(PaletteModeManagerExtended.Office365SharePoint, "Office 365 - SharePoint"),
            new(PaletteModeManagerExtended.Office365Visio, "Office 365 - Visio"),
            new(PaletteModeManagerExtended.Office365Word, "Office 365 - Word"),
            new(PaletteModeManagerExtended.Office365Black, "Office 365 - Black"),
            new(PaletteModeManagerExtended.Office365BlackDarkMode, "Office 365 - Black (Dark Mode)"),
            new(PaletteModeManagerExtended.Office365Blue, "Office 365 - Blue"),
            new(PaletteModeManagerExtended.Office365BlueDarkMode, "Office 365 - Blue (Dark Mode)"),
            new(PaletteModeManagerExtended.Office365BlueLightMode, "Office 365 - Blue (Light Mode)"),
            new(PaletteModeManagerExtended.Office365Silver, "Office 365 - Silver"),
            new(PaletteModeManagerExtended.Office365SilverDarkMode, "Office 365 - Silver (Dark Mode)"),
            new(PaletteModeManagerExtended.Office365SilverLightMode, "Office 365 - Silver (Light Mode)"),
            new(PaletteModeManagerExtended.Office365White, "Office 365 - White"),
            new(PaletteModeManagerExtended.SparkleBlue, "Sparkle - Blue"),
            new(PaletteModeManagerExtended.SparkleBlueDarkMode, "Sparkle - Blue (Dark Mode)"),
            new(PaletteModeManagerExtended.SparkleBlueLightMode, "Sparkle - Blue (Light Mode)"),
            new(PaletteModeManagerExtended.SparkleOrange, "Sparkle - Orange"),
            new(PaletteModeManagerExtended.SparkleOrangeDarkMode, "Sparkle - Orange (Dark Mode)"),
            new(PaletteModeManagerExtended.SparkleOrangeLightMode, "Sparkle - Orange (Light Mode)"),
            new(PaletteModeManagerExtended.SparklePurple, "Sparkle - Purple"),
            new(PaletteModeManagerExtended.SparklePurpleDarkMode, "Sparkle - Purple (Dark Mode)"),
            new(PaletteModeManagerExtended.SparklePurpleLightMode, "Sparkle - Purple (Light Mode)")
            //new(PaletteModeManagerExtended.VisualStudioDark,      "Visual Studio (Dark Mode)"),
            //new(PaletteModeManagerExtended.VisualStudioLight,     "Visual Studio (Light Mode)")
        };
        #endregion

        #region Identity

        /// <summary>Initializes a new instance of the <see cref="PaletteModeManagerExtendedConverter" /> class.</summary>
        public PaletteModeManagerExtendedConverter() : base(typeof(PaletteModeManagerExtended))
        {
        }

        #endregion

        #region Protected

        /// <summary>Gets an array of lookup pairs.</summary>
        protected override Pair[] Pairs => _pairs;

        #endregion
    }
}