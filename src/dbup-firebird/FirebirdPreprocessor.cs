﻿using System;
/* Unmerged change from project 'dbup-firebird (net45)'
Before:
using System;
After:
using DbUp.Engine;
*/


namespace DbUp.Firebird
{
    /// <summary>
    /// This preprocessor makes adjustments to your sql to make it compatible with Firebird.
    /// </summary>
    public class FirebirdPreprocessor : IScriptPreprocessor
    {
        /// <summary>
        /// Performs some preprocessing step on a Firebird script.
        /// </summary>
        public string Process(string contents)
        {
            return contents;
        }
    }
}
