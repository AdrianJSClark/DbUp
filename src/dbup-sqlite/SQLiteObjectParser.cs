using System;
/* Unmerged change from project 'dbup-sqlite-mono (net40)'
Before:
using System;
After:
using DbUp.Support;
*/

/* Unmerged change from project 'dbup-sqlite (net45)'
Before:
using System;
After:
using DbUp.Support;
*/

/* Unmerged change from project 'dbup-sqlite (net40)'
Before:
using System;
After:
using DbUp.Support;
*/

/* Unmerged change from project 'dbup-sqlite-mono (net45)'
Before:
using System;
After:
using DbUp.Support;
*/


namespace DbUp.SQLite
{
    /// <summary>
    /// Parses Sql Objects and performs quoting functions
    /// </summary>
    public class SQLiteObjectParser : SqlObjectParser
    {
        public SQLiteObjectParser() : base("[", "]")
        {
        }
    }
}
