using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAdder.Dialog
{
    public class DBInfo
    {
        public string serverName;
        public string dataType;
        public string username;
        public string password;
        public string DBName;

        public DBInfo()
        {
            this.serverName = "";
            this.dataType = "";
            this.username = "";
            this.password = "";
            this.DBName = "";
        }

        public DBInfo(string username, string password, string dbName)
        {
            this.serverName = "Microsoft SQL Server";
            this.dataType = "MSSQL";
            this.username = username;
            this.password = password;
            this.DBName = dbName;
        }

        public DBInfo(string serverName, string dataType, string username, string password, string dbName)
        {
            this.serverName = serverName;
            this.dataType = dataType;
            this.username = username;
            this.password = password;
            this.DBName = dbName;
        }
    }
}
