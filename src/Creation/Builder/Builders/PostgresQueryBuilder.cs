namespace DesignPatterns.Creation.Builder.Builders
{
    /// <summary>
    /// Builder to threat SQL for postgres
    /// </summary>
    public class PostgresQueryBuilder : QueryBuilder
    {
        public PostgresQueryBuilder()
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
