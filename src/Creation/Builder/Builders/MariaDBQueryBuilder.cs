namespace DesignPatterns.Creation.Builder.Builders
{
    /// <summary>
    /// Builder to threat SQL for maria DB
    /// </summary>
    public class MariaDBQueryBuilder : QueryBuilder
    {
        public MariaDBQueryBuilder()
        {
            query.Append("SELECT ");
        }

        public override QueryBuilder Select(params string[] columns)
        {
            query.Append(string.Join(", ", columns));
            return this;
        }

        public override QueryBuilder From(string table)
        {
            query.Append($" FROM {table}");
            return this;
        }

        public override QueryBuilder Where(string condition)
        {
            query.Append($" WHERE {condition}");
            return this;
        }

        public override string Build()
        {
            return query.ToString();
        }
    }
}
