using Microsoft.Extensions.Logging;
using System.Data.SqlClient;
using TrainingAPI.Model;

namespace TrainingAPI.Data
{
    public class SQLRepository : IRepository
    {
        // Fields
        private readonly string _connectionString;
        private readonly ILogger<SQLRepository> _logger;

        // Constructor
        public SQLRepository(string connectionString, ILogger<SQLRepository> logger)
        {
            _connectionString = connectionString;
            _logger = logger;
        }

        // Methods
        public async Task<IEnumerable<Associate>> GetAllAssociatesAsync()
        {
            List<Associate> result = new();

            using SqlConnection connection = new(_connectionString);
            await connection.OpenAsync();

            string cmdText = "SELECT Id, username, password, song, lyrics FROM Musicians;";

            using SqlCommand cmd = new(cmdText, connection);

            using SqlDataReader reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                int id = reader.GetInt32(0);
                string username = reader.GetString(1);
                string password = reader.GetString(2);
                string song = reader.GetString(3);
                string? lyrics = reader.IsDBNull(4) ? "" : reader.GetString(4);

                Associate tmpAssociate = new Associate(id, username, password, song, lyrics);
                result.Add(tmpAssociate);
            }

            await connection.CloseAsync();

            _logger.LogInformation("Executed GetAllAssociatesAsync, returned {0} results", result.Count);

            return result;
        }

    }
}
