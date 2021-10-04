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


namespace Krypton.Navigator
{
    /// <summary>
    /// Custom type converter so that ContextButtonAction values appear as neat text at design time.
    /// </summary>
    public class ContextButtonActionConverter : StringLookupConverter
    {
        #region Static Fields

        #endregion
                                             
        #region Identity
        /// <summary>
        /// Initialize a new instance of the ContextButtonActionConverter clas.
        /// </summary>
        public ContextButtonActionConverter()
            : base(typeof(ContextButtonAction))
        {
        }
        #endregion

        #region Protected
        /// <summary>
        /// Gets an array of lookup pairs.
        /// </summary>
        protected override Pair[] Pairs { get; } =
        { new(ContextButtonAction.None,         "None (Do nothing)"),
            new(ContextButtonAction.SelectPage,   "Select Page") };

        #endregion
    }
}