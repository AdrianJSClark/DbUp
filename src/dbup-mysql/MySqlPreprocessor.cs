using System;
/* Unmerged change from project 'dbup-mysql (net45)'
Before:
using System;
After:
using DbUp.Engine;
*/

/* Unmerged change from project 'dbup-mysql (net35)'
Before:
using System;
After:
using DbUp.Engine;
*/

/* Unmerged change from project 'dbup-mysql (netstandard2.0)'
Before:
using System;
After:
using DbUp.Engine;
*/


namespace DbUp.MySql
{
    /// <summary>
    /// This preprocessor makes adjustments to your sql to make it compatible with MySql.
    /// </summary>
    public class MySqlPreprocessor : IScriptPreprocessor
    {
        /// <summary>
        /// Performs some preprocessing step on a PostgreSQL script.
        /// </summary>
        public string Process(string contents)
        {
            return contents;
        }
    }
}
