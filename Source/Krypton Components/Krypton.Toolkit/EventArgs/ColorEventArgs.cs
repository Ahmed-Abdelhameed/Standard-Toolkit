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


namespace Krypton.Toolkit
{
    /// <summary>
    /// Color event data.
    /// </summary>
    public class ColorEventArgs : EventArgs
    {
        #region Instance Fields

        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ColorEventArgs class.
        /// </summary>
        /// <param name="color">Color associated with the event.</param>
        public ColorEventArgs(Color color)
        {
            Color = color;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets the color.
        /// </summary>
        public Color Color { get; }

        #endregion
    }
}