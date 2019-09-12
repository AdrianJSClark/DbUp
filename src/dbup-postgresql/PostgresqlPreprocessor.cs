using System;
/* Unmerged change from project 'dbup-postgresql (net45)'
Before:
using System;
After:
using DbUp.Engine;
*/

/* Unmerged change from project 'dbup-postgresql (netstandard2.0)'
Before:
using System;
After:
using DbUp.Engine;
*/

/* Unmerged change from project 'dbup-postgresql (net35)'
Before:
using System;
After:
using DbUp.Engine;
*/


namespace DbUp.Postgresql
{
    /// <summary>
    /// This preprocessor makes adjustments to your sql to make it compatible with PostgreSQL.
    /// </summary>
    public class PostgresqlPreprocessor : IScriptPreprocessor
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
