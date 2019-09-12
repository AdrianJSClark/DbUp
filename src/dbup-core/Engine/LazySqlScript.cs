using System;

namespace DbUp.Engine
{
    /// <summary>
    /// Represents a SQL Server script that is fetched at execution time, rather than discovery time
    /// </summary>
    public class LazySqlScript : SqlScript
    {
        private readonly Func<string> contentProvider;
        private string content;

        /// <summary>
        /// Initializes a new instance of the <see cref="LazySqlScript"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="contentProvider">The delegate which creates the content at execution time.</param>
        public LazySqlScript(string name, Func<string> contentProvider)
            : this(name, new SqlScriptOptions(), contentProvider)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LazySqlScript"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="sqlScriptOptions">The sql script options.</param>        
        /// <param name="contentProvider">The delegate which creates the content at execution time.</param>
        public LazySqlScript(string name, SqlScriptOptions sqlScriptOptions, Func<string> contentProvider)
            : base(name, null, sqlScriptOptions)
        {
            this.contentProvider = contentProvider;
        }

        /// <summary>
        /// Gets the contents of the script.
        /// </summary>
        /// <value></value>

/* Unmerged change from project 'dbup-core (net45)'
Before:
        public override string Contents
        {
            get { return content ?? (content = contentProvider()); }
After:
        public override string Contents => content ?? (content = contentProvider()); }
*/

/* Unmerged change from project 'dbup-core (net35)'
Before:
        public override string Contents
        {
            get { return content ?? (content = contentProvider()); }
After:
        public override string Contents => content ?? (content = contentProvider()); }
*/

/* Unmerged change from project 'dbup-core (netstandard2.0)'
Before:
        public override string Contents
        {
            get { return content ?? (content = contentProvider()); }
After:
        public override string Contents => content ?? (content = contentProvider()); }
*/
        public override string Contents => content ?? (content = contentProvider());
    }
}