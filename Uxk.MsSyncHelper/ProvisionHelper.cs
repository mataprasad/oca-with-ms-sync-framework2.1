using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Synchronization.Data;
using Microsoft.Synchronization.Data.SqlServer;

namespace Uxk.MsSyncHelper
{
    public class ProvisionHelper
    {
        public const string DEFAULT_SCOPE_NAME = "MySyncScope";

        public static bool ApplyServerAndClientProvision(string serverConnectionString, string clientConnectionString, List<string> tableNames, string scopeName = DEFAULT_SCOPE_NAME)
        {
            ApplyServerProvision(serverConnectionString, tableNames, scopeName);

            ApplyClientProvision(serverConnectionString, clientConnectionString, scopeName);

            return true;
        }

        public static bool ApplyServerProvision(string serverConnectionString, List<string> tableNames, string scopeName = DEFAULT_SCOPE_NAME)
        {
            // connect to server database
            SqlConnection serverConn = new SqlConnection(serverConnectionString);

            // define a new scope named MySyncScope
            DbSyncScopeDescription scopeDesc = new DbSyncScopeDescription(scopeName);

            // get the description of the tables from SERVER database
            List<DbSyncTableDescription> syncTablesDescriptions = new List<DbSyncTableDescription>();
            foreach (string tableName in tableNames)
            {
                syncTablesDescriptions.Add(SqlSyncDescriptionBuilder.GetDescriptionForTable(tableName, serverConn));
            }

            // add the table description to the sync scope definition
            foreach (var syncTableDescription in syncTablesDescriptions)
            {
                scopeDesc.Tables.Add(syncTableDescription);
            }

            // create a server scope provisioning object based on the MySyncScope
            SqlSyncScopeProvisioning serverProvision = new SqlSyncScopeProvisioning(serverConn, scopeDesc);

            // skipping the creation of table since table already exists on server
            serverProvision.SetCreateTableDefault(DbSyncCreationOption.Skip);

            // start the provisioning process
            serverProvision.Apply();
            return true;
        }

        public static bool ApplyClientProvision(string serverConnectionString, string clientConnectionString, string scopeName = DEFAULT_SCOPE_NAME)
        {
            // create a connection to the client database
            SqlConnection clientConn = new SqlConnection(clientConnectionString);

            // create a connection to the server database
            SqlConnection serverConn = new SqlConnection(serverConnectionString);

            // get the description of SyncScope from the server database
            DbSyncScopeDescription scopeDesc = SqlSyncDescriptionBuilder.GetDescriptionForScope(scopeName, serverConn);

            // create server provisioning object based on the SyncScope
            SqlSyncScopeProvisioning clientProvision = new SqlSyncScopeProvisioning(clientConn, scopeDesc);

            // starts the provisioning process
            clientProvision.Apply();

            return true;
        }
    }
}