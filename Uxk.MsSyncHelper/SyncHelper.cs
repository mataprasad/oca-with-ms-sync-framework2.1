using System;
using System.Data.SqlClient;
using Microsoft.Synchronization;
using Microsoft.Synchronization.Data;
using Microsoft.Synchronization.Data.SqlServer;

namespace Uxk.MsSyncHelper
{
    public static class SyncHelper
    {
        public static SyncOperationStatistics ExecuteSync(string serverConnectionString, string clientConnectionString, string scopeName = ProvisionHelper.DEFAULT_SCOPE_NAME, EventHandler<DbApplyChangeFailedEventArgs> OnApplyChangeFailed = null)
        {
            SqlConnection clientConn = new SqlConnection(clientConnectionString);

            SqlConnection serverConn = new SqlConnection(serverConnectionString);

            if (OnApplyChangeFailed == null)
            {
                OnApplyChangeFailed = new EventHandler<DbApplyChangeFailedEventArgs>((o, e) =>
                {
                    // display conflict type
                    Console.WriteLine(e.Conflict.Type);

                    // display error message 
                    Console.WriteLine(e.Error);
                });
            }

            // create the sync orhcestrator
            SyncOrchestrator syncOrchestrator = new SyncOrchestrator();

            // set local provider of orchestrator to a sync provider associated with the 
            // MySyncScope in the client database
            syncOrchestrator.LocalProvider = new SqlSyncProvider(scopeName, clientConn);

            // set the remote provider of orchestrator to a server sync provider associated with
            // the MySyncScope in the server database
            syncOrchestrator.RemoteProvider = new SqlSyncProvider(scopeName, serverConn);

            // set the direction of sync session to Upload and Download
            syncOrchestrator.Direction = SyncDirectionOrder.UploadAndDownload;

            // subscribe for errors that occur when applying changes to the client
            ((SqlSyncProvider)syncOrchestrator.LocalProvider).ApplyChangeFailed += OnApplyChangeFailed;

            // execute the synchronization process
            SyncOperationStatistics syncStats = syncOrchestrator.Synchronize();

            // print statistics
            Console.WriteLine("Start Time: " + syncStats.SyncStartTime);
            Console.WriteLine("Total Changes Uploaded: " + syncStats.UploadChangesTotal);
            Console.WriteLine("Total Changes Downloaded: " + syncStats.DownloadChangesTotal);
            Console.WriteLine("Complete Time: " + syncStats.SyncEndTime);
            return syncStats;
        }
    }
}
