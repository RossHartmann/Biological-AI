using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows;
using GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables;
using UtilityData;
using UtilityData.Database;
using UtilityData.Database.Rows;
using UtilityData.Database.Tables;
using UtilityData.Log;
using UtilityData.SQL;
using UtilityData.LINQ;

namespace GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables
{
    /// <summary>
    /// The Database Master
    /// </summary>
    public static partial class DM
    {
        public static bool Initialized { get; private set; }

        public static Database Database { get; private set; }

        public static DatabaseType DatabaseType { get { return DM.Database.DatabaseType; } }

        public static ISessionManager SessionManager { get; private set; }

        public static SQLConnectionDetails SQLConnectionDetails { get { return DM.Database.SQLConnectionDetails; } }




        private static void CreateDatabase(string databaseName, SQLConnectionDetails sqlConnectionDetails, ISessionManager sessionManager)
        {
            DM.SessionManager = sessionManager;

            var database = new Database(databaseName, sqlConnectionDetails, sessionManager, DM.GetAllTables());
            DM.Database = SM.Server.AddDatabase(database);
        }

        /// <summary>
        /// Gets the database name from this.ConnectionString.
        /// </summary>
        /// <param name="sqlConnectionDetails"></param>
        /// <param name="sessionManager"></param>
        public static void Initialize(SQLConnectionDetails sqlConnectionDetails, ISessionManager sessionManager)
        {
            Initialize(sqlConnectionDetails.GetDatabaseName(), sqlConnectionDetails, sessionManager);
        }

        public static void Initialize(string databaseName, SQLConnectionDetails sqlConnectionDetails, ISessionManager sessionManager)
        {
            // Define the tables that are in the database
            CreateDatabase(databaseName, sqlConnectionDetails, sessionManager);

            // Prepare the connection string to the database
            // ConfigureConnectionToDatabase(sqlConnectionDetails);
            Initialized = true;
        }


        /// <summary>
        /// Gets the specified column in the given table.
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public static Column GetColumn(string tableName, string columnName)
        {
            return DM.Database[tableName][columnName];
        }
        /// <summary>
        /// Gets the specified column in the given table.
        /// </summary>
        /// <param name="table"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public static Column GetColumn(TableDefinition table, string columnName)
        {
            return table[columnName];
        }

        /// <summary>
        /// Gets the specified Table.
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public static TableDefinition GetTable(string tableName)
        {
            return DM.Database[tableName];
        }

        public static List<Type> GetAllTableDefinitionTypes()
        {
            var tableDefinitions = new List<Type>();
            var typesInAssembly = typeof(GeneticCodeTable).Assembly.GetTypes();
            foreach (var type in typesInAssembly)
                if (type.BaseType == typeof(TableDefinition))
                    tableDefinitions.Add(type);

            return tableDefinitions;
        }

        /// <summary>
        /// Returns an instance of each TableDefinition defined in this Library.
        /// </summary>
        /// <returns></returns>
        public static List<TableDefinition> GetAllTables()
        {
            return GetAllTableDefinitionTypes().Select(type =>
                (TableDefinition)Activator.CreateInstance(type)).ToList();
        }

        public static List<string> GetAllTableNames()
        {
            return DM.GetAllTables().Select(t => t.TableName).ToList();
        }

        /// <summary>
        /// Returns all of the StrongRow Types defined in this library.
        /// </summary>
        /// <returns></returns>
        public static List<Type> GetAllStrongRowTypes()
        {
            var strongRows = new List<Type>();
            var typesInAssembly = typeof(GeneticCodeRow).Assembly.GetTypes();
            foreach (var type in typesInAssembly)
                if (type.BaseType == typeof(StrongRow))
                    strongRows.Add(type);

            return strongRows;
        }

        /// <summary>
        /// Gets an instance of the StrongRow with the specified StrongRowType name.
        /// For instance, if "MunicipalityRow" is given, an instance of a MunicipalityRow
        /// will be returned.
        /// </summary>
        /// <param name="strongRowTypeName">The name of the type of StrongRow</param>
        /// <returns></returns>
        public static StrongRow GetStrongRow(string strongRowTypeName)
        {
            var allStrongRowTypes = DM.GetAllStrongRowTypes();
            var type = allStrongRowTypes.First(t => t.Name == strongRowTypeName);
            return (StrongRow)Activator.CreateInstance(type);
        }

        /// <summary>
        /// Returns an instance of each StrongRow defined in this Library.
        /// </summary>
        /// <returns></returns>
        public static List<StrongRow> GetAllStrongRows()
        {
            return GetAllStrongRowTypes().Select(type =>
                (StrongRow)Activator.CreateInstance(type)).ToList();
        }


    }
}


