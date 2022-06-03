using System.Collections.Generic;

namespace Krypton.Toolkit.Themes
{
    [ToolboxItem(true)]
    [ToolboxBitmap(typeof(KryptonManager), "ToolboxBitmaps.KryptonManager.bmp")]
    [Designer("Krypton.Toolkit.Themes.KryptonManagerDesigner, Krypton.Toolkit.Themes")]
    [DefaultProperty("GlobalPaletteMode")]
    [Description(@"Access 'Global' Krypton settings.")]
    public sealed class KryptonManager : Component
    {
        #region Static Fields
        // Initialize the global state
        private static bool _globalApplyToolStrips = true;
        private static bool _globalAllowFormChrome = true;

        // Initialize the default modes

        // Initialize instances to match the default modes

        // Singleton instances are created on demand

        #region Original Palettes

        private static PaletteProfessionalOffice2003 _paletteProfessionalOffice2003;
        private static PaletteProfessionalSystem _paletteProfessionalSystem;
        private static PaletteOffice2007Blue _paletteOffice2007Blue;
        private static PaletteOffice2007BlueDarkMode _paletteOffice2007BlueDarkMode;
        private static PaletteOffice2007BlueLightMode _paletteOffice2007BlueLightMode;
        private static PaletteOffice2007Silver _paletteOffice2007Silver;
        private static PaletteOffice2007SilverDarkMode _paletteOffice2007SilverDarkMode;
        private static PaletteOffice2007SilverLightMode _paletteOffice2007SilverLightMode;
        private static PaletteOffice2007White _paletteOffice2007White;
        private static PaletteOffice2007Black _paletteOffice2007Black;
        private static PaletteOffice2007BlackDarkMode _paletteOffice2007BlackDarkMode;

        private static PaletteOffice2010Blue _paletteOffice2010Blue;
        private static PaletteOffice2010BlueDarkMode _paletteOffice2010BlueDarkMode;
        private static PaletteOffice2010BlueLightMode _paletteOffice2010BlueLightMode;
        private static PaletteOffice2010White _paletteOffice2010White;
        private static PaletteOffice2010Black _paletteOffice2010Black;
        private static PaletteOffice2010BlackDarkMode _paletteOffice2010BlackDarkMode;
        private static PaletteOffice2010Silver _paletteOffice2010Silver;
        private static PaletteOffice2010SilverDarkMode _paletteOffice2010SilverDarkMode;
        private static PaletteOffice2010SilverLightMode _paletteOffice2010SilverLightMode;

        private static PaletteOffice2013White _paletteOffice2013White;

        private static PaletteSparkleBlue _paletteSparkleBlue;
        private static PaletteSparkleBlueDarkMode _paletteSparkleBlueDarkMode;
        private static PaletteSparkleBlueLightMode _paletteSparkleBlueLightMode;
        private static PaletteSparkleOrange _paletteSparkleOrange;
        private static PaletteSparkleOrangeDarkMode _paletteSparkleOrangeDarkMode;
        private static PaletteSparkleOrangeLightMode _paletteSparkleOrangeLightMode;
        private static PaletteSparklePurple _paletteSparklePurple;
        private static PaletteSparklePurpleDarkMode _paletteSparklePurpleDarkMode;
        private static PaletteSparklePurpleLightMode _paletteSparklePurpleLightMode;
        private static PaletteOffice365Black _paletteOffice365Black;
        private static PaletteOffice365BlackDarkMode _paletteOffice365BlackDarkMode;
        private static PaletteOffice365Blue _paletteOffice365Blue;
        private static PaletteOffice365BlueDarkMode _paletteOffice365BlueDarkMode;
        private static PaletteOffice365BlueLightMode _paletteOffice365BlueLightMode;
        private static PaletteOffice365Silver _paletteOffice365Silver;
        private static PaletteOffice365SilverDarkMode _paletteOffice365SilverDarkMode;
        private static PaletteOffice365SilverLightMode _paletteOffice365SilverLightMode;
        private static PaletteOffice365White _paletteOffice365White;

        #endregion

        #region Bonus Palettes

        #region Office 2007

        private static PaletteOffice2007Access _paletteOffice2007Access;

        #endregion

        #region Office 2010

        private static PaletteOffice2010Access _paletteOffice2010Access;

        #endregion

        #region Office 2013

        private static PaletteOffice2013Access _paletteOffice2013Access;
        private static PaletteOffice2013AccessLegacy _paletteOffice2013AccessLegacy;

        #endregion

        #region Office 365

        private static PaletteOffice365Access _paletteOffice365Access;
        private static PaletteOffice365AccessLegacy _paletteOffice365AccessLegacy;

        #endregion

        #endregion

        private static RenderStandard _renderStandard;
        private static RenderProfessional _renderProfessional;
        private static RenderOffice2007 _renderOffice2007;
        private static RenderOffice2010 _renderOffice2010;
        private static RenderOffice2013 _renderOffice2013;
        private static RenderOffice365 _renderOffice365;
        private static RenderSparkle _renderSparkle;
        #endregion

        #region Static Events
        /// <summary>
        /// Occurs when the palette changes.
        /// </summary>
        [Category(@"Property Changed")]
        [Description(@"Occurs when the value of the GlobalPalette property is changed.")]
        public static event EventHandler GlobalPaletteChanged;

        /// <summary>
        /// Occurs when the AllowFormChrome property changes.
        /// </summary>
        [Category(@"Property Changed")]
        [Description(@"Occurs when the value of the GlobalAllowFormChrome property is changed.")]
        public static event EventHandler GlobalAllowFormChromeChanged;
        #endregion

        #region Identity
        static KryptonManager()
        {
            // We need to notice when system color settings change
            SystemEvents.UserPreferenceChanged += OnUserPreferenceChanged;

            // Update the tool strip global renderer with the default setting
            UpdateToolStripManager();
        }

        /// <summary>
        /// Initialize a new instance of the KryptonManagerExtended class.
        /// </summary>
        public KryptonManager() =>
            // This may not be the first form / object to init, so set to the global static
            GlobalPaletteMode = InternalGlobalPaletteMode;

        /// <summary>
        /// Initialize a new instance of the KryptonManagerExtended class.
        /// </summary>
        /// <param name="container">Container that owns the component.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public KryptonManager(IContainer container)
            : this()
        {
            Debug.Assert(container != null);

            // Validate reference parameter
            if (container == null)
            {
                throw new ArgumentNullException(nameof(container));
            }

            container.Add(this);
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }

            base.Dispose(disposing);
        }
        #endregion

        #region Public

        /// <summary>
        /// Have any of the global values been modified
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsDefault => !(ShouldSerializeGlobalPaletteMode()
                                   || ShouldSerializeGlobalPalette()
                                   || ShouldSerializeGlobalApplyToolstrips()
                                   || ShouldSerializeGlobalAllowFormChrome()
                                   || ShouldSerializeGlobalStrings()
                                );

        /// <summary>
        /// Reset All values
        /// </summary>
        public void Reset()
        {
            ResetGlobalPaletteMode();
            ResetGlobalPalette();
            ResetGlobalApplyToolstrips();
            ResetGlobalAllowFormChrome();
            ResetGlobalStrings();
        }

        /// <summary>
        /// Gets or sets the global palette used for drawing.
        /// </summary>
        [Category(@"Visuals")]
        [Description(@"Global palette applied to drawing.")]
        //[DefaultValue(typeof(PaletteModeManagerExtended), "Office365Blue")]
        public PaletteModeManagerExtended GlobalPaletteMode
        {
            get => InternalGlobalPaletteMode;

            set
            {
                // Only interested in changes of value
                if (InternalGlobalPaletteMode != value)
                {
                    // Action depends on the value
                    switch (value)
                    {
                        case PaletteModeManagerExtended.Custom:
                            // Do nothing, you must assign a palette to the 
                            // 'GlobalPalette' property in order to get the custom mode
                            break;
                        default:
                            // Cache the new values
                            PaletteModeManagerExtended tempMode = InternalGlobalPaletteMode;
                            IPalette tempPalette = InternalGlobalPalette;

                            // Use the new value
                            InternalGlobalPaletteMode = value;
                            InternalGlobalPalette = null;

                            // If the new value creates a circular reference
                            if (HasCircularReference())
                            {
                                // Restore the original values before throwing
                                InternalGlobalPaletteMode = tempMode;
                                InternalGlobalPalette = tempPalette;

                                throw new ArgumentOutOfRangeException(nameof(value),
                                    @"Cannot use palette that would create a circular reference");
                            }
                            else
                            {
                                // Restore the original global palette as 'SetPalette' will not 
                                // work correctly unless it still has the old value in place
                                InternalGlobalPalette = tempPalette;
                            }

                            // Get a reference to the standard palette from its name
                            SetPalette(CurrentGlobalPalette);

                            // Raise the palette changed event
                            OnGlobalPaletteChanged(EventArgs.Empty);
                            break;
                    }
                }
            }
        }

        private bool ShouldSerializeGlobalPaletteMode() => GlobalPaletteMode != PaletteModeManagerExtended.Office365Blue;

        private void ResetGlobalPaletteMode() => GlobalPaletteMode = PaletteModeManagerExtended.Office365Blue;

        /// <summary>
        /// Gets and sets the global custom applied to drawing.
        /// </summary>
        [Category(@"Visuals")]
        [Description(@"Global custom palette applied to drawing.")]
        [DefaultValue(null)]
        public IPalette GlobalPalette
        {
            get => InternalGlobalPalette;

            set
            {
                // Only interested in changes of value
                if (InternalGlobalPalette != value)
                {
                    // Cache the current values
                    PaletteModeManagerExtended tempMode = InternalGlobalPaletteMode;
                    IPalette tempPalette = InternalGlobalPalette;

                    // Use the new values
                    InternalGlobalPaletteMode = (value == null) ? PaletteModeManagerExtended.Office365Blue : PaletteModeManagerExtended.Custom;
                    InternalGlobalPalette = value;

                    // If the new value creates a circular reference
                    if (HasCircularReference())
                    {
                        // Restore the original values
                        InternalGlobalPaletteMode = tempMode;
                        InternalGlobalPalette = tempPalette;

                        throw new ArgumentOutOfRangeException(nameof(value), @"Cannot use palette that would create a circular reference");
                    }
                    else
                    {
                        // Restore the original global palette as 'SetPalette' will not 
                        // work correctly unless it still has the old value in place
                        InternalGlobalPalette = tempPalette;
                    }

                    // Use the provided palette value
                    SetPalette(value);

                    // If no custom palette is required
                    if (value == null)
                    {
                        // Get a reference to current global palette defined by the mode
                        SetPalette(CurrentGlobalPalette);
                    }
                    else
                    {
                        // No longer using a standard palette
                        InternalGlobalPaletteMode = PaletteModeManagerExtended.Custom;
                    }

                    // Raise the palette changed event
                    OnGlobalPaletteChanged(EventArgs.Empty);
                }
            }
        }

        private bool ShouldSerializeGlobalPalette() => GlobalPalette != null;

        private void ResetGlobalPalette() => GlobalPaletteMode = PaletteModeManagerExtended.Office365Blue;

        /// <summary>
        /// Gets or sets a value indicating if the palette colors are applied to the tool-strips.
        /// </summary>
        [Category(@"Visuals")]
        [Description(@"Should the palette colors be applied to the toolstrips.")]
        [DefaultValue(true)]
        public bool GlobalApplyToolStrips
        {
            get => ApplyToolStrips;
            set => ApplyToolStrips = value;
        }

        private bool ShouldSerializeGlobalApplyToolstrips() => !GlobalApplyToolStrips;

        private void ResetGlobalApplyToolstrips() => GlobalApplyToolStrips = true;

        /// <summary>
        /// Gets or sets a value indicating if KryptonForm instances are allowed to show custom chrome.
        /// </summary>
        [Category(@"Visuals")]
        [Description(@"Should KryptonForm instances be allowed to show custom chrome.")]
        [DefaultValue(true)]
        public bool GlobalAllowFormChrome
        {
            get => AllowFormChrome;
            set => AllowFormChrome = value;
        }

        private bool ShouldSerializeGlobalAllowFormChrome() => !GlobalAllowFormChrome;

        private void ResetGlobalAllowFormChrome() => GlobalAllowFormChrome = true;

        /// <summary>
        /// Gets a set of global strings used by Krypton that can be localized.
        /// </summary>
        [Category(@"Visuals")]
        [Description(@"Collection of global strings.")]
        [MergableProperty(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Localizable(true)]
        public GlobalStrings GlobalStrings => Strings;

        private bool ShouldSerializeGlobalStrings() => !Strings.IsDefault;

        /// <summary>
        /// Resets the GlobalStrings property to its default value.
        /// </summary>
        public void ResetGlobalStrings() => Strings.Reset();
        #endregion

        #region Static ApplyToolstrips
        /// <summary>
        /// Gets and sets the global flag that decides if palette colors are applied to toolstrips.
        /// </summary>
        public static bool ApplyToolStrips
        {
            get => _globalApplyToolStrips;

            set
            {
                // Only interested if the value changes
                if (_globalApplyToolStrips != value)
                {
                    // Use new value
                    _globalApplyToolStrips = value;

                    // Change the toolstrip manager renderer as required
                    if (_globalApplyToolStrips)
                    {
                        UpdateToolStripManager();
                    }
                    else
                    {
                        ResetToolStripManager();
                    }
                }
            }
        }
        #endregion

        #region Static AllowFormChrome
        /// <summary>
        /// Gets and sets the global flag that decides if form chrome should be customized.
        /// </summary>
        public static bool AllowFormChrome
        {
            get => _globalAllowFormChrome;

            set
            {
                // Only interested if the value changes
                if (_globalAllowFormChrome != value)
                {
                    // Use new value
                    _globalAllowFormChrome = value;

                    // Fire change event
                    OnGlobalAllowFormChromeChanged(EventArgs.Empty);
                }
            }
        }
        #endregion

        #region Static Strings
        /// <summary>
        /// Gets access to the set of global strings.
        /// </summary>
        public static GlobalStrings Strings { get; } = new();

        #endregion

        #region Static Palette
        /// <summary>
        /// Gets the current global palette instance given the manager settings.
        /// </summary>
        public static IPalette CurrentGlobalPalette
        {
            get
            {
                switch (InternalGlobalPaletteMode)
                {
                    case PaletteModeManagerExtended.ProfessionalSystem:
                        return PaletteProfessionalSystem;
                    case PaletteModeManagerExtended.ProfessionalOffice2003:
                        return PaletteProfessionalOffice2003;
                    case PaletteModeManagerExtended.Office2007DarkGray:
                    case PaletteModeManagerExtended.Office2007LightGray:
                    case PaletteModeManagerExtended.Office2007Access:
                    case PaletteModeManagerExtended.Office2007Excel:
                    case PaletteModeManagerExtended.Office2007Groove:
                    case PaletteModeManagerExtended.Office2007InfoPath:
                    case PaletteModeManagerExtended.Office2007OneNote:
                    case PaletteModeManagerExtended.Office2007Outlook:
                    case PaletteModeManagerExtended.Office2007PowerPoint:
                    case PaletteModeManagerExtended.Office2007Project:
                    case PaletteModeManagerExtended.Office2007Publisher:
                    case PaletteModeManagerExtended.Office2007Visio:
                    case PaletteModeManagerExtended.Office2007Word:
                    case PaletteModeManagerExtended.Office2007Blue:
                        return PaletteOffice2007Blue;
                    case PaletteModeManagerExtended.Office2007BlueDarkMode:
                        return PaletteOffice2007BlueDarkMode;
                    case PaletteModeManagerExtended.Office2007BlueLightMode:
                        return PaletteOffice2007BlueLightMode;
                    case PaletteModeManagerExtended.Office2007Silver:
                        return PaletteOffice2007Silver;
                    case PaletteModeManagerExtended.Office2007SilverDarkMode:
                        return PaletteOffice2007SilverDarkMode;
                    case PaletteModeManagerExtended.Office2007SilverLightMode:
                        return PaletteOffice2007SilverLightMode;
                    case PaletteModeManagerExtended.Office2007White:
                        return PaletteOffice2007White;
                    case PaletteModeManagerExtended.Office2007Black:
                        return PaletteOffice2007Black;
                    case PaletteModeManagerExtended.Office2007BlackDarkMode:
                        return PaletteOffice2007BlackDarkMode;
                    case PaletteModeManagerExtended.Office2010DarkGray:
                    case PaletteModeManagerExtended.Office2010Blue:
                        return PaletteOffice2010Blue;
                    case PaletteModeManagerExtended.Office2010BlueDarkMode:
                        return PaletteOffice2010BlueDarkMode;
                    case PaletteModeManagerExtended.Office2010BlueLightMode:
                        return PaletteOffice2010BlueLightMode;
                    case PaletteModeManagerExtended.Office2010Silver:
                        return PaletteOffice2010Silver;
                    case PaletteModeManagerExtended.Office2010SilverDarkMode:
                        return PaletteOffice2010SilverDarkMode;
                    case PaletteModeManagerExtended.Office2010SilverLightMode:
                        return PaletteOffice2010SilverLightMode;
                    case PaletteModeManagerExtended.Office2010White:
                        return PaletteOffice2010White;
                    case PaletteModeManagerExtended.Office2010Black:
                        return PaletteOffice2010Black;
                    case PaletteModeManagerExtended.Office2010BlackDarkMode:
                        return PaletteOffice2010BlackDarkMode;
                    /*case PaletteModeManagerExtended.Office2013:
                        return PaletteOffice2013;*/
                    case PaletteModeManagerExtended.Office2013White:
                        return PaletteOffice2013White;
                    case PaletteModeManagerExtended.SparkleBlue:
                        return PaletteSparkleBlue;
                    case PaletteModeManagerExtended.SparkleBlueDarkMode:
                        return PaletteSparkleBlueDarkMode;
                    case PaletteModeManagerExtended.SparkleBlueLightMode:
                        return PaletteSparkleBlueLightMode;
                    case PaletteModeManagerExtended.SparkleOrange:
                        return PaletteSparkleOrange;
                    case PaletteModeManagerExtended.SparkleOrangeDarkMode:
                        return PaletteSparkleOrangeDarkMode;
                    case PaletteModeManagerExtended.SparkleOrangeLightMode:
                        return PaletteSparkleOrangeLightMode;
                    case PaletteModeManagerExtended.SparklePurple:
                        return PaletteSparklePurple;
                    case PaletteModeManagerExtended.SparklePurpleDarkMode:
                        return PaletteSparklePurpleDarkMode;
                    case PaletteModeManagerExtended.SparklePurpleLightMode:
                        return PaletteSparklePurpleLightMode;
                    case PaletteModeManagerExtended.Office365Black:
                        return PaletteOffice365Black;
                    case PaletteModeManagerExtended.Office365BlackDarkMode:
                        return PaletteOffice365BlackDarkMode;
                    case PaletteModeManagerExtended.Office365Blue:
                        return PaletteOffice365Blue;
                    case PaletteModeManagerExtended.Office365BlueDarkMode:
                        return PaletteOffice365BlueDarkMode;
                    case PaletteModeManagerExtended.Office365BlueLightMode:
                        return PaletteOffice365BlueLightMode;
                    case PaletteModeManagerExtended.Office365Silver:
                        return PaletteOffice365Silver;
                    case PaletteModeManagerExtended.Office365SilverDarkMode:
                        return PaletteOffice365SilverDarkMode;
                    case PaletteModeManagerExtended.Office365SilverLightMode:
                        return PaletteOffice365SilverLightMode;
                    case PaletteModeManagerExtended.Office365White:
                        return PaletteOffice365White;
                    case PaletteModeManagerExtended.Custom:
                        return InternalGlobalPalette;
                    default:
                        Debug.Assert(false);
                        return null;
                }
            }
        }

        /// <summary>
        /// Gets the implementation for the requested palette mode.
        /// </summary>
        /// <param name="mode">Requested palette mode.</param>
        /// <returns>IPalette reference is available; otherwise false.</returns>
        public static IPalette GetPaletteForMode(PaletteModeExtended mode)
        {
            switch (mode)
            {
                case PaletteModeExtended.ProfessionalSystem:
                    return PaletteProfessionalSystem;
                case PaletteModeExtended.ProfessionalOffice2003:
                    return PaletteProfessionalOffice2003;
                case PaletteModeExtended.Office2007Blue:
                    return PaletteOffice2007Blue;
                case PaletteModeExtended.Office2007BlueDarkMode:
                    return PaletteOffice2007BlueDarkMode;
                case PaletteModeExtended.Office2007BlueLightMode:
                    return PaletteOffice2007BlueLightMode;
                case PaletteModeExtended.Office2007Silver:
                    return PaletteOffice2007Silver;
                case PaletteModeExtended.Office2007SilverDarkMode:
                    return PaletteOffice2007SilverDarkMode;
                case PaletteModeExtended.Office2007SilverLightMode:
                    return PaletteOffice2007SilverLightMode;
                case PaletteModeExtended.Office2007White:
                    return PaletteOffice2007White;
                case PaletteModeExtended.Office2007Black:
                    return PaletteOffice2007Black;
                case PaletteModeExtended.Office2007BlackDarkMode:
                    return PaletteOffice2007BlackDarkMode;
                case PaletteModeExtended.Office2010Blue:
                    return PaletteOffice2010Blue;
                case PaletteModeExtended.Office2010BlueDarkMode:
                    return PaletteOffice2010BlueDarkMode;
                case PaletteModeExtended.Office2010BlueLightMode:
                    return PaletteOffice2010BlueLightMode;
                case PaletteModeExtended.Office2010Silver:
                    return PaletteOffice2010Silver;
                case PaletteModeExtended.Office2010SilverDarkMode:
                    return PaletteOffice2010SilverDarkMode;
                case PaletteModeExtended.Office2010SilverLightMode:
                    return PaletteOffice2010SilverLightMode;
                case PaletteModeExtended.Office2010White:
                    return PaletteOffice2010White;
                case PaletteModeExtended.Office2010Black:
                    return PaletteOffice2010Black;
                case PaletteModeExtended.Office2010BlackDarkMode:
                    return PaletteOffice2010BlackDarkMode;
                /*case PaletteModeExtended.Office2013:
                    return PaletteOffice2013;*/
                case PaletteModeExtended.Office2013White:
                    return PaletteOffice2013White;
                case PaletteModeExtended.SparkleBlue:
                    return PaletteSparkleBlue;
                case PaletteModeExtended.SparkleBlueDarkMode:
                    return PaletteSparkleBlueDarkMode;
                case PaletteModeExtended.SparkleBlueLightMode:
                    return PaletteSparkleBlueLightMode;
                case PaletteModeExtended.SparkleOrange:
                    return PaletteSparkleOrange;
                case PaletteModeExtended.SparkleOrangeDarkMode:
                    return PaletteSparkleOrangeDarkMode;
                case PaletteModeExtended.SparkleOrangeLightMode:
                    return PaletteSparkleOrangeLightMode;
                case PaletteModeExtended.SparklePurple:
                    return PaletteSparklePurple;
                case PaletteModeExtended.SparklePurpleDarkMode:
                    return PaletteSparklePurpleDarkMode;
                case PaletteModeExtended.SparklePurpleLightMode:
                    return PaletteSparklePurpleLightMode;
                case PaletteModeExtended.Office365Black:
                    return PaletteOffice365Black;
                case PaletteModeExtended.Office365BlackDarkMode:
                    return PaletteOffice365BlackDarkMode;
                case PaletteModeExtended.Office365BlueDarkMode:
                    return PaletteOffice365BlueDarkMode;
                case PaletteModeExtended.Office365BlueLightMode:
                    return PaletteOffice365BlueLightMode;
                case PaletteModeExtended.Office365Blue:
                    return PaletteOffice365Blue;
                case PaletteModeExtended.Office365Silver:
                    return PaletteOffice365Silver;
                case PaletteModeExtended.Office365SilverDarkMode:
                    return PaletteOffice365SilverDarkMode;
                case PaletteModeExtended.Office365SilverLightMode:
                    return PaletteOffice365SilverLightMode;
                case PaletteModeExtended.Office365White:
                    return PaletteOffice365White;
                case PaletteModeExtended.Global:
                    return CurrentGlobalPalette;
                case PaletteModeExtended.Custom:
                default:
                    Debug.Assert(false);
                    return null;
            }
        }

        /// <summary>
        /// Gets the single instance of the professional system palette.
        /// </summary>
        public static PaletteProfessionalSystem PaletteProfessionalSystem => _paletteProfessionalSystem ??= new PaletteProfessionalSystem();

        /// <summary>
        /// Gets the single instance of the professional office palette.
        /// </summary>
        public static PaletteProfessionalOffice2003 PaletteProfessionalOffice2003 => _paletteProfessionalOffice2003 ??= new PaletteProfessionalOffice2003();

        /// <summary>
        /// Gets the single instance of the Blue variant Office 2007 palette.
        /// </summary>
        public static PaletteOffice2007Blue PaletteOffice2007Blue => _paletteOffice2007Blue ??= new PaletteOffice2007Blue();

        /// <summary>
        /// Gets the single instance of the ### palette.
        /// </summary>
        public static PaletteOffice2007BlueDarkMode PaletteOffice2007BlueDarkMode => _paletteOffice2007BlueDarkMode ??= new PaletteOffice2007BlueDarkMode();

        /// <summary>
        /// Gets the single instance of the ### palette.
        /// </summary>
        public static PaletteOffice2007BlueLightMode PaletteOffice2007BlueLightMode => _paletteOffice2007BlueLightMode ??= new PaletteOffice2007BlueLightMode();

        /// <summary>
        /// Gets the single instance of the Silver variant Office 2007 palette.
        /// </summary>
        public static PaletteOffice2007Silver PaletteOffice2007Silver => _paletteOffice2007Silver ??= new PaletteOffice2007Silver();

        /// <summary>
        /// Gets the single instance of the ### palette.
        /// </summary>
        public static PaletteOffice2007SilverDarkMode PaletteOffice2007SilverDarkMode => _paletteOffice2007SilverDarkMode ??= new PaletteOffice2007SilverDarkMode();

        /// <summary>
        /// Gets the single instance of the ### palette.
        /// </summary>
        public static PaletteOffice2007SilverLightMode PaletteOffice2007SilverLightMode => _paletteOffice2007SilverLightMode ??= new PaletteOffice2007SilverLightMode();

        /// <summary>
        /// Gets the single instance of the ### palette.
        /// </summary>
        public static PaletteOffice2007White PaletteOffice2007White => _paletteOffice2007White ??= new PaletteOffice2007White();

        /// <summary>
        /// Gets the single instance of the Black variant Office 2007 palette.
        /// </summary>
        public static PaletteOffice2007Black PaletteOffice2007Black => _paletteOffice2007Black ??= new PaletteOffice2007Black();

        /// <summary>
        /// Gets the single instance of the ### palette.
        /// </summary>
        public static PaletteOffice2007BlackDarkMode PaletteOffice2007BlackDarkMode => _paletteOffice2007BlackDarkMode ??= new PaletteOffice2007BlackDarkMode();


        /// <summary>
        /// Gets the single instance of the Blue variant Office 2010 palette.
        /// </summary>
        public static PaletteOffice2010Blue PaletteOffice2010Blue => _paletteOffice2010Blue ??= new PaletteOffice2010Blue();

        /// <summary>
        /// Gets the single instance of the ### palette.
        /// </summary>
        public static PaletteOffice2010BlueDarkMode PaletteOffice2010BlueDarkMode => _paletteOffice2010BlueDarkMode ??= new PaletteOffice2010BlueDarkMode();

        /// <summary>
        /// Gets the single instance of the ### palette.
        /// </summary>
        public static PaletteOffice2010BlueLightMode PaletteOffice2010BlueLightMode => _paletteOffice2010BlueLightMode ??= new PaletteOffice2010BlueLightMode();

        /// <summary>
        /// Gets the single instance of the Silver variant Office 2010 palette.
        /// </summary>
        public static PaletteOffice2010Silver PaletteOffice2010Silver => _paletteOffice2010Silver ??= new PaletteOffice2010Silver();

        /// <summary>
        /// Gets the single instance of the ### palette.
        /// </summary>
        public static PaletteOffice2010SilverDarkMode PaletteOffice2010SilverDarkMode => _paletteOffice2010SilverDarkMode ??= new PaletteOffice2010SilverDarkMode();

        /// <summary>
        /// Gets the single instance of the ### palette.
        /// </summary>
        public static PaletteOffice2010SilverLightMode PaletteOffice2010SilverLightMode => _paletteOffice2010SilverLightMode ??= new PaletteOffice2010SilverLightMode();

        /// <summary>
        /// Gets the single instance of the Black variant Office 2010 palette.
        /// </summary>
        public static PaletteOffice2010Black PaletteOffice2010Black => _paletteOffice2010Black ??= new PaletteOffice2010Black();

        /// <summary>
        /// Gets the single instance of the ### palette.
        /// </summary>
        public static PaletteOffice2010BlackDarkMode PaletteOffice2010BlackDarkMode => _paletteOffice2010BlackDarkMode ??= new PaletteOffice2010BlackDarkMode();

        /// <summary>
        /// Gets the single instance of the ### palette.
        /// </summary>
        public static PaletteOffice2010White PaletteOffice2010White => _paletteOffice2010White ??= new PaletteOffice2010White();

        /// <summary>
        /// Gets the single instance of the Office 2013 palette.
        /// </summary>
        public static PaletteOffice2013White PaletteOffice2013White => _paletteOffice2013White ??= new PaletteOffice2013White();

        /// <summary>
        /// Gets the palette office365 black.
        /// </summary>
        /// <value>
        /// The palette office365 black.
        /// </value>
        public static PaletteOffice365Black PaletteOffice365Black => _paletteOffice365Black ??= new PaletteOffice365Black();

        /// <summary>
        /// Gets the single instance of the ### palette.
        /// </summary>
        public static PaletteOffice365BlackDarkMode PaletteOffice365BlackDarkMode => _paletteOffice365BlackDarkMode ??= new PaletteOffice365BlackDarkMode();

        /// <summary>
        /// Gets the palette office365 blue.
        /// </summary>
        /// <value>
        /// The palette office365 blue.
        /// </value>
        public static PaletteOffice365Blue PaletteOffice365Blue => _paletteOffice365Blue ??= new PaletteOffice365Blue();

        /// <summary>
        /// Gets the single instance of the ### palette.
        /// </summary>
        public static PaletteOffice365BlueDarkMode PaletteOffice365BlueDarkMode => _paletteOffice365BlueDarkMode ??= new PaletteOffice365BlueDarkMode();

        /// <summary>
        /// Gets the single instance of the ### palette.
        /// </summary>
        public static PaletteOffice365BlueLightMode PaletteOffice365BlueLightMode => _paletteOffice365BlueLightMode ??= new PaletteOffice365BlueLightMode();

        /// <summary>
        /// Gets the palette office365 silver.
        /// </summary>
        /// <value>
        /// The palette office365 silver.
        /// </value>
        public static PaletteOffice365Silver PaletteOffice365Silver => _paletteOffice365Silver ??= new PaletteOffice365Silver();

        /// <summary>
        /// Gets the single instance of the ### palette.
        /// </summary>
        public static PaletteOffice365SilverDarkMode PaletteOffice365SilverDarkMode => _paletteOffice365SilverDarkMode ??= new PaletteOffice365SilverDarkMode();

        /// <summary>
        /// Gets the single instance of the ### palette.
        /// </summary>
        public static PaletteOffice365SilverLightMode PaletteOffice365SilverLightMode => _paletteOffice365SilverLightMode ??= new PaletteOffice365SilverLightMode();

        /// <summary>
        /// Gets the single instance of the ### palette.
        /// </summary>
        public static PaletteOffice365White PaletteOffice365White => _paletteOffice365White ??= new PaletteOffice365White();

        /// <summary>
        /// Gets the single instance of the Blue variant sparkle palette.
        /// </summary>
        public static PaletteSparkleBlue PaletteSparkleBlue => _paletteSparkleBlue ??= new PaletteSparkleBlue();

        /// <summary>
        /// Gets the single instance of the ### palette.
        /// </summary>
        public static PaletteSparkleBlueDarkMode PaletteSparkleBlueDarkMode => _paletteSparkleBlueDarkMode ??= new PaletteSparkleBlueDarkMode();

        /// <summary>
        /// Gets the single instance of the ### palette.
        /// </summary>
        public static PaletteSparkleBlueLightMode PaletteSparkleBlueLightMode => _paletteSparkleBlueLightMode ??= new PaletteSparkleBlueLightMode();

        /// <summary>
        /// Gets the single instance of the Orange variant sparkle palette.
        /// </summary>
        public static PaletteSparkleOrange PaletteSparkleOrange => _paletteSparkleOrange ??= new PaletteSparkleOrange();

        /// <summary>
        /// Gets the single instance of the ### palette.
        /// </summary>
        public static PaletteSparkleOrangeDarkMode PaletteSparkleOrangeDarkMode => _paletteSparkleOrangeDarkMode ??= new PaletteSparkleOrangeDarkMode();

        /// <summary>
        /// Gets the single instance of the ### palette.
        /// </summary>
        public static PaletteSparkleOrangeLightMode PaletteSparkleOrangeLightMode => _paletteSparkleOrangeLightMode ??= new PaletteSparkleOrangeLightMode();

        /// <summary>
        /// Gets the single instance of the Purple variant sparkle palette.
        /// </summary>
        public static PaletteSparklePurple PaletteSparklePurple => _paletteSparklePurple ??= new PaletteSparklePurple();

        /// <summary>
        /// Gets the single instance of the ### palette.
        /// </summary>
        public static PaletteSparklePurpleDarkMode PaletteSparklePurpleDarkMode => _paletteSparklePurpleDarkMode ??= new PaletteSparklePurpleDarkMode();

        /// <summary>
        /// Gets the single instance of the ### palette.
        /// </summary>
        public static PaletteSparklePurpleLightMode PaletteSparklePurpleLightMode => _paletteSparklePurpleLightMode ??= new PaletteSparklePurpleLightMode();


        /// <summary>
        /// Gets the implementation for the requested renderer mode.
        /// </summary>
        /// <param name="mode">Requested renderer mode.</param>
        /// <returns>IRenderer reference is available; otherwise false.</returns>
        public static IRenderer GetRendererForMode(RendererMode mode)
        {
            switch (mode)
            {
                case RendererMode.Sparkle:
                    return RenderSparkle;
                case RendererMode.Office2007:
                    return RenderOffice2007;
                case RendererMode.Office2010:
                    return RenderOffice2010;
                case RendererMode.Office2013:
                    return RenderOffice2013;
                case RendererMode.Office365:
                    return RenderOffice365;
                case RendererMode.Professional:
                    return RenderProfessional;
                case RendererMode.Standard:
                    return RenderStandard;
                case RendererMode.Inherit:
                case RendererMode.Custom:
                default:
                    // Should never be passed
                    Debug.Assert(false);
                    return null;
            }
        }

        /// <summary>
        /// Gets the single instance of the Sparkle renderer.
        /// </summary>
        public static RenderSparkle RenderSparkle => _renderSparkle ??= new RenderSparkle();

        /// <summary>
        /// Gets the single instance of the Office 2007 renderer.
        /// </summary>
        public static RenderOffice2007 RenderOffice2007 => _renderOffice2007 ??= new RenderOffice2007();

        /// <summary>
        /// Gets the single instance of the Office 2010 renderer.
        /// </summary>
        public static RenderOffice2010 RenderOffice2010 => _renderOffice2010 ??= new RenderOffice2010();

        /// <summary>
        /// Gets the single instance of the Office 2013 renderer.
        /// </summary>
        public static RenderOffice2013 RenderOffice2013 => _renderOffice2013 ??= new RenderOffice2013();

        /// <summary>
        /// Gets the single instance of the 365 2013 renderer.
        /// </summary>
        public static RenderOffice365 RenderOffice365 => _renderOffice365 ??= new RenderOffice365();

        /// <summary>
        /// Gets the single instance of the professional renderer.
        /// </summary>
        public static RenderProfessional RenderProfessional => _renderProfessional ??= new RenderProfessional();

        /// <summary>
        /// Gets the single instance of the standard renderer.
        /// </summary>
        public static RenderStandard RenderStandard => _renderStandard ??= new RenderStandard();

        #endregion

        #region Static Internal
        internal static PaletteModeManagerExtended InternalGlobalPaletteMode { get; private set; } = PaletteModeManagerExtended.Office365Blue;

        internal static IPalette InternalGlobalPalette { get; private set; } = CurrentGlobalPalette;

        internal static bool HasCircularReference()
        {
            // Use a dictionary as a set to check for existence
            var paletteSet = new Dictionary<IPalette, bool>();

            IPalette palette = null;

            // Get the next palette up in hierarchy
            if (InternalGlobalPaletteMode == PaletteModeManagerExtended.Custom)
            {
                palette = InternalGlobalPalette;
            }

            // Keep searching until no more palettes found
            while (palette != null)
            {
                // If the palette has already been encountered then it is a circular reference
                if (paletteSet.ContainsKey(palette))
                {
                    return true;
                }
                else
                {
                    // Otherwise, add to the set
                    paletteSet.Add(palette, true);
                    // Cast to correct type

                    // If this is a KryptonPalette instance
                    if (palette is KryptonPalette owner)
                    {
                        // Get the next palette up in hierarchy
                        palette = owner.BasePaletteMode switch
                        {
                            PaletteModeExtended.Custom => owner.BasePalette,
                            PaletteModeExtended.Global => InternalGlobalPalette,
                            _ => null
                        };
                    }
                    else
                    {
                        palette = null;
                    }
                }
            }

            // No circular reference encountered
            return false;
        }
        #endregion

        #region Static Implementation
        private static void OnUserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            // Because we are static this event is fired before any instance controls are updated, so we need to
            // tell the palette instances to update now so that when the instance controls are updated the new fonts
            // and other resources are recreated as needed.

            _paletteProfessionalOffice2003?.UserPreferenceChanged();

            _paletteProfessionalSystem?.UserPreferenceChanged();

            _paletteOffice2007Blue?.UserPreferenceChanged();

            _paletteOffice2007Silver?.UserPreferenceChanged();

            _paletteOffice2007White?.UserPreferenceChanged();

            _paletteOffice2007Black?.UserPreferenceChanged();

            _paletteOffice2010Blue?.UserPreferenceChanged();

            _paletteOffice2010Silver?.UserPreferenceChanged();

            _paletteOffice2010Black?.UserPreferenceChanged();

            _paletteOffice2010White?.UserPreferenceChanged();

            _paletteOffice2013White?.UserPreferenceChanged();

            _paletteSparkleBlue?.UserPreferenceChanged();

            _paletteSparkleOrange?.UserPreferenceChanged();

            _paletteSparklePurple?.UserPreferenceChanged();

            _paletteOffice365Black?.UserPreferenceChanged();

            _paletteOffice365Blue?.UserPreferenceChanged();

            _paletteOffice365Silver?.UserPreferenceChanged();

            _paletteOffice365White?.UserPreferenceChanged();



            UpdateToolStripManager();
        }

        private static void OnPalettePaint(object sender, PaletteLayoutEventArgs e)
        {
            // If the color table has changed then need to update tool strip immediately
            if (e.NeedColorTable)
            {
                UpdateToolStripManager();
            }
        }

        private static void SetPalette(IPalette globalPalette)
        {
            if (globalPalette != InternalGlobalPalette)
            {
                // Unhook from current palette events
                if (InternalGlobalPalette != null)
                {
                    InternalGlobalPalette.PalettePaint -= OnPalettePaint;
                }

                // Remember the new palette
                InternalGlobalPalette = globalPalette;

                // Hook to new palette events
                if (InternalGlobalPalette != null)
                {
                    InternalGlobalPalette.PalettePaint += OnPalettePaint;
                }
            }
        }

        private static void OnGlobalAllowFormChromeChanged(EventArgs e) => GlobalAllowFormChromeChanged?.Invoke(null, e);

        private static void OnGlobalPaletteChanged(EventArgs e)
        {
            UpdateToolStripManager();

            GlobalPaletteChanged?.Invoke(null, e);
        }

        private static void UpdateToolStripManager()
        {
            if (_globalApplyToolStrips)
            {
                ToolStripManager.Renderer = InternalGlobalPalette.GetRenderer().RenderToolStrip(InternalGlobalPalette);
            }
        }

        private static void ResetToolStripManager() => ToolStripManager.RenderMode = ToolStripManagerRenderMode.Professional;

        #endregion
    }
}