namespace Krypton.Toolkit.Themes
{
    #region Enum PaletteModeExtended
    /// <summary>
    /// Specifies the palette applied when drawing.
    /// </summary>
    [TypeConverter(typeof(PaletteModeExtendedConverter))]
    public enum PaletteModeExtended
    {
        /// <summary>
        /// Specifies the renderer defined by the KryptonManager be used.
        /// </summary>
        Global,

        /// <summary>
        /// Specifies a professional appearance based on system settings.
        /// </summary>
        ProfessionalSystem,

        /// <summary>
        /// Specifies a professional appearance with a preference to use theme colors.
        /// </summary>
        ProfessionalOffice2003,

        /// <summary>
        /// Specifies the dark Grey color variant of the Office 2007 appearance.
        /// </summary>
		Office2007DarkGray,

        /// <summary>
        /// Specifies the light Grey color variant of the Office 2007 appearance.
        /// </summary>
		Office2007LightGray,

        /// <summary>
        /// Specifies the Access color variant of the Office 2007 appearance.
        /// </summary>
		Office2007Access,

        /// <summary>
        /// Specifies the Excel color variant of the Office 2007 appearance.
        /// </summary>
		Office2007Excel,

        /// <summary>
        /// Specifies the Groove color variant of the Office 2007 appearance.
        /// </summary>
		Office2007Groove,

        /// <summary>
        /// Specifies the InfoPath color variant of the Office 2007 appearance.
        /// </summary>
		Office2007InfoPath,

        /// <summary>
        /// Specifies the OneNote color variant of the Office 2007 appearance.
        /// </summary>
		Office2007OneNote,

        /// <summary>
        /// Specifies the Outlook color variant of the Office 2007 appearance.
        /// </summary>
		Office2007Outlook,

        /// <summary>
        /// Specifies the PowerPoint color variant of the Office 2007 appearance.
        /// </summary>
		Office2007PowerPoint,

        /// <summary>
        /// Specifies the Project color variant of the Office 2007 appearance.
        /// </summary>
		Office2007Project,

        /// <summary>
        /// Specifies the Publisher color variant of the Office 2007 appearance.
        /// </summary>
		Office2007Publisher,

        /// <summary>
        /// Specifies the Visio color variant of the Office 2007 appearance.
        /// </summary>
		Office2007Visio,

        /// <summary>
        /// Specifies the Word color variant of the Office 2007 appearance.
        /// </summary>
		Office2007Word,

        /// <summary>
        /// Specifies the Blue color variant of the Office 2007 appearance.
        /// </summary>
        Office2007Blue,

        /// <summary>
        /// Specifies the dark Blue color variant of the Office 2007 appearance.
        /// </summary>
        Office2007BlueDarkMode,

        /// <summary>
        /// Specifies the light Blue color variant of the Office 2007 appearance.
        /// </summary>
        Office2007BlueLightMode,

        /// <summary>
        /// Specifies the Silver color variant of the Office 2007 appearance.
        /// </summary>
        Office2007Silver,

        /// <summary>
        /// Specifies the dark Silver color variant of the Office 2007 appearance.
        /// </summary>
        Office2007SilverDarkMode,

        /// <summary>
        /// Specifies the light Silver color variant of the Office 2007 appearance.
        /// </summary>
        Office2007SilverLightMode,

        /// <summary>
        /// Specifies the White color variant of the Office 2007 appearance.
        /// </summary>
        Office2007White,

        /// <summary>
        /// Specifies the Black color variant of the Office 2007 appearance.
        /// </summary>
        Office2007Black,

        /// <summary>
        /// Specifies the dark Black color variant of the Office 2007 appearance.
        /// </summary>
        Office2007BlackDarkMode,

        /// <summary>
        /// Specifies the dark Grey color variant of the Office 2010 appearance.
        /// </summary>
        Office2010DarkGray,

        /// <summary>
        /// Specifies the light Grey color variant of the Office 2010 appearance.
        /// </summary>
        Office2010LightGray,

        /// <summary>
        /// Specifies the Access color variant of the Office 2010 appearance.
        /// </summary>
        Office2010Access,

        /// <summary>
        /// Specifies the Excel color variant of the Office 2010 appearance.
        /// </summary>
        Office2010Excel,

        /// <summary>
        /// Specifies the InfoPath color variant of the Office 2010 appearance.
        /// </summary>
        Office2010InfoPath,

        /// <summary>
        /// Specifies the OneNote color variant of the Office 2010 appearance.
        /// </summary>
        Office2010OneNote,

        /// <summary>
        /// Specifies the Outlook color variant of the Office 2010 appearance.
        /// </summary>
        Office2010Outlook,

        /// <summary>
        /// Specifies the PowerPoint color variant of the Office 2010 appearance.
        /// </summary>
        Office2010PowerPoint,

        /// <summary>
        /// Specifies the Project color variant of the Office 2010 appearance.
        /// </summary>
        Office2010Project,

        /// <summary>
        /// Specifies the Publisher color variant of the Office 2010 appearance.
        /// </summary>
        Office2010Publisher,

        /// <summary>
        /// Specifies the SharePoint color variant of the Office 2010 appearance.
        /// </summary>
        Office2010SharePoint,

		/// <summary>
		/// Specifies the Visio color variant of the Office 2010 appearance.
		/// </summary>
		Office2010Visio,

		/// <summary>
		/// Specifies the Word color variant of the Office 2010 appearance.
		/// </summary>
		Office2010Word,

        /// <summary>
        /// Specifies the Blue color variant of the Office 2010 appearance.
        /// </summary>
        Office2010Blue,

        /// <summary>
        /// Specifies the dark Blue color variant of the Office 2010 appearance.
        /// </summary>
        Office2010BlueDarkMode,

        /// <summary>
        /// Specifies the light Blue color variant of the Office 2010 appearance.
        /// </summary>
        Office2010BlueLightMode,

        /// <summary>
        /// Specifies the Silver color variant of the Office 2010 appearance.
        /// </summary>
        Office2010Silver,

        /// <summary>
        /// Specifies the dark Silver color variant of the Office 2010 appearance.
        /// </summary>
		Office2010SilverDarkMode,

        /// <summary>
        /// Specifies the light Silver color variant of the Office 2010 appearance.
        /// </summary>
		Office2010SilverLightMode,

        /// <summary>
        /// Specifies the White color variant of the Office 2010 appearance.
        /// </summary>
        Office2010White,

        /// <summary>
        /// Specifies the Black color variant of the Office 2010 appearance.
        /// </summary>
        Office2010Black,

        /// <summary>
        /// Specifies the dark Black color variant of the Office 2010 appearance.
        /// </summary>
		Office2010BlackDarkMode,

        /// <summary>
        /// Specifies the dark Grey color variant of the Office 2013 appearance.
        /// </summary>
		Office2013DarkGray,

        /// <summary>
        /// Specifies the light Grey color variant of the Office 2013 appearance.
        /// </summary>
		Office2013LightGray,

        /// <summary>
        /// Specifies the Access color variant of the Office 2013 appearance.
        /// </summary>
		Office2013Access,

        /// <summary>
        /// Specifies the Access color variant of the Office 2013 appearance (In the pre-2013 colours).
        /// </summary>
        Office2013AccessLegacy,

        /// <summary>
        /// Specifies the Excel color variant of the Office 2013 appearance.
        /// </summary>
		Office2013Excel,

        /// <summary>
        /// Specifies the InfoPath color variant of the Office 2013 appearance.
        /// </summary>
		Office2013InfoPath,

        /// <summary>
        /// Specifies the Lync color variant of the Office 2013 appearance.
        /// </summary>
		Office2013Lync,

        /// <summary>
        /// Specifies the OneNote color variant of the Office 2013 appearance.
        /// </summary>
		Office2013OneNote,

        /// <summary>
        /// Specifies the Outlook color variant of the Office 2013 appearance.
        /// </summary>
		Office2013Outlook,

        /// <summary>
        /// Specifies the PowerPoint color variant of the Office 2013 appearance.
        /// </summary>
		Office2013PowerPoint,

        /// <summary>
        /// Specifies the Project color variant of the Office 2013 appearance.
        /// </summary>
		Office2013Project,

        /// <summary>
        /// Specifies the Publisher color variant of the Office 2013 appearance.
        /// </summary>
		Office2013Publisher,

        /// <summary>
        /// Specifies the SharePoint color variant of the Office 2013 appearance.
        /// </summary>
		Office2013SharePoint,

        /// <summary>
        /// Specifies the Visio color variant of the Office 2013 appearance.
        /// </summary>
		Office2013Visio,

        /// <summary>
        /// Specifies the Word color variant of the Office 2013 appearance.
        /// </summary>
		Office2013Word,

        /// <summary>
        /// Specifies the White color variant of the Office 2013 appearance.
        /// </summary>
        Office2013White,

        /// <summary>
        /// Specifies the dark Grey color variant of the Office 365 appearance.
        /// </summary>
        Office365DarkGray,

        /// <summary>
        /// Specifies the light Grey color variant of the Office 365 appearance.
        /// </summary>
        Office365LightGray,

        /// <summary>
		/// Specifies the Access color variant of the Office 365 appearance.
		/// </summary>
		Office365Access,

        /// <summary>
        /// Specifies the Access color variant of the Office 365 appearance (In the pre-2013 colours).
        /// </summary>
        Office365AccessLegacy,

		/// <summary>
		/// Specifies the Excel color variant of the Office 365 appearance.
		/// </summary>
		Office365Excel,

		/// <summary>
		/// Specifies the InfoPath color variant of the Office 365 appearance.
		/// </summary>
		Office365InfoPath,

		/// <summary>
		/// Specifies the Lync color variant of the Office 365 appearance.
		/// </summary>
		Office365Lync,

		/// <summary>
		/// Specifies the OneNote color variant of the Office 365 appearance.
		/// </summary>
		Office365OneNote,

		/// <summary>
		/// Specifies the Outlook color variant of the Office 365 appearance.
		/// </summary>
		Office365Outlook,

		/// <summary>
		/// Specifies the PowerPoint color variant of the Office 365 appearance.
		/// </summary>
		Office365PowerPoint,

		/// <summary>
		/// Specifies the Project color variant of the Office 365 appearance.
		/// </summary>
		Office365Project,

		/// <summary>
		/// Specifies the Publisher color variant of the Office 365 appearance.
		/// </summary>
		Office365Publisher,

		/// <summary>
		/// Specifies the SharePoint color variant of the Office 365 appearance.
		/// </summary>
		Office365SharePoint,

		/// <summary>
		/// Specifies the Visio color variant of the Office 365 appearance.
		/// </summary>
		Office365Visio,

		/// <summary>
		/// Specifies the Word color variant of the Office 365 appearance.
		/// </summary>
		Office365Word,

        /// <summary>
        /// Specifies the Black color variant of the Office 365 appearance.
        /// </summary>
        Office365Black,

        /// <summary>
        /// Specifies the dark Black color variant of the Office 365 appearance.
        /// </summary>
		Office365BlackDarkMode,

        /// <summary>
        /// Specifies the Blue color variant of the Office 365 appearance.
        /// </summary>
        Office365Blue,

        /// <summary>
        /// Specifies the dark Blue color variant of the Office 365 appearance.
        /// </summary>
		Office365BlueDarkMode,

        /// <summary>
        /// Specifies the light Blue color variant of the Office 365 appearance.
        /// </summary>
		Office365BlueLightMode,

        /// <summary>
        /// Specifies the Silver color variant of the Office 365 appearance.
        /// </summary>
        Office365Silver,

        /// <summary>
        /// Specifies the dark Silver color variant of the Office 365 appearance.
        /// </summary>
		Office365SilverDarkMode,

        /// <summary>
        /// Specifies the light Silver color variant of the Office 365 appearance.
        /// </summary>
		Office365SilverLightMode,

        /// <summary>
        /// Specifies the White color variant of the Office 365 appearance.
        /// </summary>
        Office365White,

        /// <summary>
        /// Specifies the Blue color variant on the Sparkle palette theme.
        /// </summary>
        SparkleBlue,

        /// <summary>
        /// Specifies the dark Blue color variant on the Sparkle palette theme.
        /// </summary>
		SparkleBlueDarkMode,

        /// <summary>
        /// Specifies the light Blue color variant on the Sparkle palette theme.
        /// </summary>
		SparkleBlueLightMode,

        /// <summary>
        /// Specifies the Orange color variant on the Sparkle palette theme.
        /// </summary>
        SparkleOrange,

        /// <summary>
        /// Specifies the dark Orange color variant on the Sparkle palette theme.
        /// </summary>
		SparkleOrangeDarkMode,

        /// <summary>
        /// Specifies the light Orange color variant on the Sparkle palette theme.
        /// </summary>
		SparkleOrangeLightMode,

        /// <summary>
        /// Specifies the Purple color variant on the Sparkle palette theme.
        /// </summary>
        SparklePurple,

        /// <summary>
        /// Specifies the dark Purple color variant on the Sparkle palette theme.
        /// </summary>
		SparklePurpleDarkMode,

        /// <summary>
        /// Specifies the light Purple color variant on the Sparkle palette theme.
        /// </summary>
		SparklePurpleLightMode,

        ///// <summary>
        ///// Specifies the visual studio dark palette theme.
        ///// </summary>
        //VisualStudioDark,

        ///// <summary>
        ///// Specifies the visual studio light palette theme.
        ///// </summary>
        //VisualStudioLight,

        /// <summary>
        /// Specifies a custom palette be used.
        /// </summary>
        Custom
    }
    #endregion

    #region PaletteModeManagerExtended
    /// <summary>
    /// Specifies the palette requested at the global level.
    /// </summary>
    [TypeConverter(typeof(PaletteModeManagerExtendedConverter))]
    public enum PaletteModeManagerExtended
    {
        /// <summary>
        /// Specifies a professional appearance based on system settings.
        /// </summary>
        ProfessionalSystem,

        /// <summary>
        /// Specifies a professional appearance with a preference to use theme colors.
        /// </summary>
        ProfessionalOffice2003,

        /// <summary>
        /// Specifies the dark Grey color variant of the Office 2007 appearance.
        /// </summary>
        Office2007DarkGray,

        /// <summary>
        /// Specifies the light Grey color variant of the Office 2007 appearance.
        /// </summary>
        Office2007LightGray,

        /// <summary>
		/// Specifies the Access color variant of the Office 2007 appearance.
		/// </summary>
		Office2007Access,

		/// <summary>
		/// Specifies the Excel color variant of the Office 2007 appearance.
		/// </summary>
		Office2007Excel,

		/// <summary>
		/// Specifies the Groove color variant of the Office 2007 appearance.
		/// </summary>
		Office2007Groove,

		/// <summary>
		/// Specifies the InfoPath color variant of the Office 2007 appearance.
		/// </summary>
		Office2007InfoPath,

		/// <summary>
		/// Specifies the OneNote color variant of the Office 2007 appearance.
		/// </summary>
		Office2007OneNote,

		/// <summary>
		/// Specifies the Outlook color variant of the Office 2007 appearance.
		/// </summary>
		Office2007Outlook,

		/// <summary>
		/// Specifies the PowerPoint color variant of the Office 2007 appearance.
		/// </summary>
		Office2007PowerPoint,

		/// <summary>
		/// Specifies the Project color variant of the Office 2007 appearance.
		/// </summary>
		Office2007Project,

		/// <summary>
		/// Specifies the Publisher color variant of the Office 2007 appearance.
		/// </summary>
		Office2007Publisher,

		/// <summary>
		/// Specifies the Visio color variant of the Office 2007 appearance.
		/// </summary>
		Office2007Visio,

		/// <summary>
		/// Specifies the Word color variant of the Office 2007 appearance.
		/// </summary>
		Office2007Word,

        /// <summary>
        /// Specifies the Blue color variant of the Office 2007 appearance.
        /// </summary>
        Office2007Blue,

        /// <summary>
        /// Specifies the dark Blue color variant of the Office 2007 appearance.
        /// </summary>
        Office2007BlueDarkMode,

        /// <summary>
        /// Specifies the light Blue color variant of the Office 2007 appearance.
        /// </summary>
        Office2007BlueLightMode,

        /// <summary>
        /// Specifies the Silver color variant of the Office 2007 appearance.
        /// </summary>
        Office2007Silver,

        /// <summary>
        /// Specifies the dark Silver color variant of the Office 2007 appearance.
        /// </summary>
        Office2007SilverDarkMode,

        /// <summary>
        /// Specifies the light Silver color variant of the Office 2007 appearance.
        /// </summary>
        Office2007SilverLightMode,

        /// <summary>
        /// Specifies the White color variant of the Office 2007 appearance.
        /// </summary>
        Office2007White,

        /// <summary>
        /// Specifies the Black color variant of the Office 2007 appearance.
        /// </summary>
        Office2007Black,

        /// <summary>
        /// Specifies the dark Black color variant of the Office 2007 appearance.
        /// </summary>
        Office2007BlackDarkMode,

        /// <summary>
        /// Specifies the dark Grey color variant of the Office 2010 appearance.
        /// </summary>
        Office2010DarkGray,

        /// <summary>
        /// Specifies the light Grey color variant of the Office 2010 appearance.
        /// </summary>
        Office2010LightGray,

        /// <summary>
		/// Specifies the Access color variant of the Office 2010 appearance.
		/// </summary>
		Office2010Access,

		/// <summary>
		/// Specifies the Excel color variant of the Office 2010 appearance.
		/// </summary>
		Office2010Excel,

		/// <summary>
		/// Specifies the InfoPath color variant of the Office 2010 appearance.
		/// </summary>
		Office2010InfoPath,

		/// <summary>
		/// Specifies the OneNote color variant of the Office 2010 appearance.
		/// </summary>
		Office2010OneNote,

		/// <summary>
		/// Specifies the Outlook color variant of the Office 2010 appearance.
		/// </summary>
		Office2010Outlook,

		/// <summary>
		/// Specifies the PowerPoint color variant of the Office 2010 appearance.
		/// </summary>
		Office2010PowerPoint,

		/// <summary>
		/// Specifies the Project color variant of the Office 2010 appearance.
		/// </summary>
		Office2010Project,

		/// <summary>
		/// Specifies the Publisher color variant of the Office 2010 appearance.
		/// </summary>
		Office2010Publisher,

		/// <summary>
		/// Specifies the SharePoint color variant of the Office 2010 appearance.
		/// </summary>
		Office2010SharePoint,

		/// <summary>
		/// Specifies the Visio color variant of the Office 2010 appearance.
		/// </summary>
		Office2010Visio,

		/// <summary>
		/// Specifies the Word color variant of the Office 2010 appearance.
		/// </summary>
		Office2010Word,

        /// <summary>
        /// Specifies the Blue color variant of the Office 2010 appearance.
        /// </summary>
        Office2010Blue,

        /// <summary>
        /// Specifies the dark Blue color variant of the Office 2010 appearance.
        /// </summary>
        Office2010BlueDarkMode,

        /// <summary>
        /// Specifies the light Blue color variant of the Office 2010 appearance.
        /// </summary>
        Office2010BlueLightMode,

        /// <summary>
        /// Specifies the Silver color variant of the Office 2010 appearance.
        /// </summary>
        Office2010Silver,

        /// <summary>
        /// Specifies the dark Silver color variant of the Office 2010 appearance.
        /// </summary>
        Office2010SilverDarkMode,

        /// <summary>
        /// Specifies the light Silver color variant of the Office 2010 appearance.
        /// </summary>
        Office2010SilverLightMode,

        /// <summary>
        /// Specifies the White color variant of the Office 2010 appearance.
        /// </summary>
        Office2010White,

        /// <summary>
        /// Specifies the Black color variant of the Office 2010 appearance.
        /// </summary>
        Office2010Black,

        /// <summary>
        /// Specifies the dark Black color variant of the Office 2010 appearance.
        /// </summary>
        Office2010BlackDarkMode,

        /// <summary>
        /// Specifies the dark Grey color variant of the Office 2013 appearance.
        /// </summary>
        Office2013DarkGray,

        /// <summary>
        /// Specifies the light Grey color variant of the Office 2013 appearance.
        /// </summary>
        Office2013LightGray,

        /// <summary>
		/// Specifies the Access color variant of the Office 2013 appearance.
		/// </summary>
		Office2013Access,

        /// <summary>
        /// Specifies the Access color variant of the Office 2013 appearance (In the pre-2013 colours).
        /// </summary>
        Office2013AccessLegacy,

        /// <summary>
        /// Specifies the Excel color variant of the Office 2013 appearance.
        /// </summary>
        Office2013Excel,

		/// <summary>
		/// Specifies the InfoPath color variant of the Office 2013 appearance.
		/// </summary>
		Office2013InfoPath,

		/// <summary>
		/// Specifies the Lync color variant of the Office 2013 appearance.
		/// </summary>
		Office2013Lync,

		/// <summary>
		/// Specifies the OneNote color variant of the Office 2013 appearance.
		/// </summary>
		Office2013OneNote,

		/// <summary>
		/// Specifies the Outlook color variant of the Office 2013 appearance.
		/// </summary>
		Office2013Outlook,

		/// <summary>
		/// Specifies the PowerPoint color variant of the Office 2013 appearance.
		/// </summary>
		Office2013PowerPoint,

		/// <summary>
		/// Specifies the Project color variant of the Office 2013 appearance.
		/// </summary>
		Office2013Project,

		/// <summary>
		/// Specifies the Publisher color variant of the Office 2013 appearance.
		/// </summary>
		Office2013Publisher,

		/// <summary>
		/// Specifies the SharePoint color variant of the Office 2013 appearance.
		/// </summary>
		Office2013SharePoint,

		/// <summary>
		/// Specifies the Visio color variant of the Office 2013 appearance.
		/// </summary>
		Office2013Visio,

		/// <summary>
		/// Specifies the Word color variant of the Office 2013 appearance.
		/// </summary>
		Office2013Word,

        /// <summary>
        /// Specifies the White color variant of the Office 2013 appearance.
        /// </summary>
        Office2013White,

        /// <summary>
        /// Specifies the dark Grey color variant of the Office 365 appearance.
        /// </summary>
        Office365DarkGray,

        /// <summary>
        /// Specifies the light Grey color variant of the Office 365 appearance.
        /// </summary>
        Office365LightGray,

        /// <summary>
		/// Specifies the Access color variant of the Office 365 appearance.
		/// </summary>
		Office365Access,

        /// <summary>
        /// Specifies the Access color variant of the Office 365 appearance (In the pre-2013 colours).
        /// </summary>
        Office365AccessLegacy,

        /// <summary>
        /// Specifies the Excel color variant of the Office 365 appearance.
        /// </summary>
        Office365Excel,

		/// <summary>
		/// Specifies the InfoPath color variant of the Office 365 appearance.
		/// </summary>
		Office365InfoPath,

		/// <summary>
		/// Specifies the Lync color variant of the Office 365 appearance.
		/// </summary>
		Office365Lync,

		/// <summary>
		/// Specifies the OneNote color variant of the Office 365 appearance.
		/// </summary>
		Office365OneNote,

		/// <summary>
		/// Specifies the Outlook color variant of the Office 365 appearance.
		/// </summary>
		Office365Outlook,

		/// <summary>
		/// Specifies the PowerPoint color variant of the Office 365 appearance.
		/// </summary>
		Office365PowerPoint,

		/// <summary>
		/// Specifies the Project color variant of the Office 365 appearance.
		/// </summary>
		Office365Project,

		/// <summary>
		/// Specifies the Publisher color variant of the Office 365 appearance.
		/// </summary>
		Office365Publisher,

		/// <summary>
		/// Specifies the SharePoint color variant of the Office 365 appearance.
		/// </summary>
		Office365SharePoint,

		/// <summary>
		/// Specifies the Visio color variant of the Office 365 appearance.
		/// </summary>
		Office365Visio,

		/// <summary>
		/// Specifies the Word color variant of the Office 365 appearance.
		/// </summary>
		Office365Word,

        /// <summary>
        /// Specifies the Black color variant of the Office 365 appearance.
        /// </summary>
        Office365Black,

        /// <summary>
        /// Specifies the dark Black color variant of the Office 365 appearance.
        /// </summary>
        Office365BlackDarkMode,

        /// <summary>
        /// Specifies the Blue color variant of the Office 365 appearance.
        /// </summary>
        Office365Blue,

        /// <summary>
        /// Specifies the dark Blue color variant of the Office 365 appearance.
        /// </summary>
        Office365BlueDarkMode,

        /// <summary>
        /// Specifies the light Blue color variant of the Office 365 appearance.
        /// </summary>
        Office365BlueLightMode,

        /// <summary>
        /// Specifies the Silver color variant of the Office 365 appearance.
        /// </summary>
        Office365Silver,

        /// <summary>
        /// Specifies the dark Silver color variant of the Office 365 appearance.
        /// </summary>
        Office365SilverDarkMode,

        /// <summary>
        /// Specifies the light Silver color variant of the Office 365 appearance.
        /// </summary>
        Office365SilverLightMode,

        /// <summary>
        /// Specifies the White color variant of the Office 365 appearance.
        /// </summary>
        Office365White,

        /// <summary>
        /// Specifies the Blue color variant on the Sparkle palette theme.
        /// </summary>
        SparkleBlue,

        /// <summary>
        /// Specifies the dark Blue color variant on the Sparkle palette theme.
        /// </summary>
        SparkleBlueDarkMode,

        /// <summary>
        /// Specifies the light Blue color variant on the Sparkle palette theme.
        /// </summary>
        SparkleBlueLightMode,

        /// <summary>
        /// Specifies the Orange color variant on the Sparkle palette theme.
        /// </summary>
        SparkleOrange,

        /// <summary>
        /// Specifies the dark Orange color variant on the Sparkle palette theme.
        /// </summary>
        SparkleOrangeDarkMode,

        /// <summary>
        /// Specifies the light Orange color variant on the Sparkle palette theme.
        /// </summary>
        SparkleOrangeLightMode,

        /// <summary>
        /// Specifies the Purple color variant on the Sparkle palette theme.
        /// </summary>
        SparklePurple,

        /// <summary>
        /// Specifies the dark Purple color variant on the Sparkle palette theme.
        /// </summary>
        SparklePurpleDarkMode,

        /// <summary>
        /// Specifies the light Purple color variant on the Sparkle palette theme.
        /// </summary>
        SparklePurpleLightMode,

        ///// <summary>
        ///// Specifies the visual studio dark palette theme.
        ///// </summary>
        //VisualStudioDark,

        ///// <summary>
        ///// Specifies the visual studio light palette theme.
        ///// </summary>
        //VisualStudioLight,

        /// <summary>
        /// Specifies a custom palette be used.
        /// </summary>
        Custom
    }
    #endregion
}