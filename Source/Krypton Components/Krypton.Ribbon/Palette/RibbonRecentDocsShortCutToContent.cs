﻿#region BSD License
/*
 * 
 * Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
 *  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
 * 
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2021. All rights reserved. 
 *  
 */
#endregion


namespace Krypton.Ribbon
{
    internal class RibbonRecentDocsShortcutToContent : RibbonRecentDocsEntryToContent
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the RibbonRecentDocsShortcutToContent class.
        /// </summary>
        /// <param name="ribbonGeneral">Source for general ribbon settings.</param>
        /// <param name="ribbonRecentDocEntryText">Source for ribbon recent document entry settings.</param>
        public RibbonRecentDocsShortcutToContent(PaletteRibbonGeneral ribbonGeneral,
                                                 IPaletteRibbonText ribbonRecentDocEntryText)
            : base(ribbonGeneral, ribbonRecentDocEntryText)
        {
        }
        #endregion

        #region IPaletteContent
        /// <summary>
        /// Gets the prefix drawing setting for short text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>PaletteTextPrefix value.</returns>
        public override PaletteTextHotkeyPrefix GetContentShortTextPrefix(PaletteState state)
        {
            return PaletteTextHotkeyPrefix.Show;
        }
        #endregion
    }
}