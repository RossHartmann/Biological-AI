using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityData.Database;
using UtilityData.Log;
using UtilityData.SQL;

namespace GeneticFaradayDatabaseLibrary
{
    /// <summary>
    /// The SQL Server
    /// </summary>
    public static class SM
    {
        public static bool Initialized { get; private set; }

        public static Server Server { get; private set; }

        private static void CreateServer(string serverName)
        {
            Server = new Server(serverName);
        }

        public static void Initialize(SQLConnectionDetails sqlConnectionDetails, bool recordAllSQLTransactions = false)
        {
            Initialize(sqlConnectionDetails.GetServerName(), recordAllSQLTransactions);
        }

        public static void Initialize(string serverName, bool recordAllSQLTransactions = false)
        {
            SQLer.Initialize(recordAllSQLTransactions, convertNaNToNull: true);
            Logger.Initialize();

            CreateServer(serverName);
            Initialized = true;
        }
    }
}
