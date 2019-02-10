using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectToMysqlDatabase;
using HungAirKezelő.Classes;

namespace HungAirKezelő.Repositories
{
    partial class RepoGuns
    {
        public void addGunToDB(Gun editedG)
        {
            MySQLDatabase msd = new MySQLDatabase();
            MySQLDatabaseInterface mdi = msd.getDatabaseInterface();
            string query = editedG.getInsertQuery();
            mdi.open();
            mdi.executeDMQuery(query); //insert update delete
            mdi.close();
        }

        public void editGunInDB(Gun editedG)
        {
            MySQLDatabase msd = new MySQLDatabase();
            MySQLDatabaseInterface mdi = msd.getDatabaseInterface();
            string query = editedG.getUpdateQuery();
            mdi.open();
            mdi.executeDMQuery(query); //insert update delete
            mdi.close();
        }
    }
}
