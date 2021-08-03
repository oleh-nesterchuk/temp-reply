using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace Querier
{
    internal static class Program
    {
        private static async Task Main(string[] args)
        {
            const string connectionString = "";
            const string query = "";

            var sw = Stopwatch.StartNew();
            
            var connection = new SqlConnection(connectionString);
            var results = await connection.QueryAsync<EmailReportModel>(query);

            var list = results.ToList();
            
            sw.Stop();

            Console.WriteLine(sw.Elapsed.TotalSeconds);
        }
    }
}