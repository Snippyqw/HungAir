using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HungAirKezelő.Classes;
using ConnectToMysqlDatabase;
using System.Data;

namespace HungAirKezelő.Repositories
{
    partial class RepoGuns
    {
        List<Gun> guns;

        public RepoGuns()
        {
            guns = new List<Gun>();
            fillGunsList();
        }

        private void fillGunsList()
        {
            MySQLDatabase md = new MySQLDatabase();
            MySQLDatabaseInterface mdi = md.getDatabaseInterface();

            mdi.open();
            string query = "SELECT * FROM fegyverek";
            DataTable dTGuns = mdi.getToDataTable(query);
            mdi.close();

            foreach (DataRow row in dTGuns.Rows)
            {
                int gunID = Convert.ToInt32(row["FID"].ToString());
                string gunManufact = row["gyarto"].ToString();
                string gunName = row["nev"].ToString();
                int gunType = Convert.ToInt32(row["tipus"].ToString());
                int gunFps = Convert.ToInt32(row["FPS"].ToString());
                int gunWeight = Convert.ToInt32(row["suly"].ToString());
                string gunMaterial = row["anyag"].ToString();
                int gunPrice = Convert.ToInt32(row["ar"].ToString());
                int gunVariant = Convert.ToInt32(row["varians"].ToString());
                Gun g = new Gun(gunID, gunManufact, gunName, gunType, gunFps, gunWeight, gunMaterial, gunPrice, gunVariant);
                guns.Add(g);
            }
        }

        public void addGun(Gun editedG)
        {
            guns.Add(editedG);
            addGunToDB(editedG);

        }

        public void editGun(Gun editedG)
        {
            foreach (Gun g in guns)
            {
                if (g.getFID() == editedG.getFID())
                {
                    g.setManufact(editedG.getManufact());
                    g.setName(editedG.getName());
                    g.setType(editedG.getType());
                    g.setFps(editedG.getFps());
                    g.setWeight(editedG.getWeight());
                    g.setMaterial(editedG.getMaterial());
                    g.setPrice(editedG.getPrice());
                    g.setVariant(editedG.getVariant());

                    editGunInDB(editedG);
                }
            }
        }

        public bool checkExist(Gun editedG)
        {
            foreach (Gun gu in guns)
            {
                if (gu.getFID() == editedG.getFID())
                {
                    return true;
                }
            }
            return false;
                //customers.Exists(x => x.getID() == c.getID())
            
        }

        public int getFID()
        {
            MySQLDatabase ujID = new MySQLDatabase();
            MySQLDatabaseInterface mdujid = ujID.getDatabaseInterface();
            mdujid.open();
            int max;
            bool siker = int.TryParse(mdujid.executeScalarQuery("SELECT MAX(FID) FROM fegyverek"), out max);
            if (!siker)
            {
                //MessageBox.Show("Nem lehet megállapítani a következő rekord kulcsát. Adatbázis lekérdezési hiba.", "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mdujid.close();
            return max + 1;
        }

        public DataTable getGunsDT()
        {
            DataTable gDT = new DataTable();
            gDT.Columns.Add("Azonosító", typeof(int));
            gDT.Columns.Add("Gyártó", typeof(string));
            gDT.Columns.Add("Név", typeof(string));
            gDT.Columns.Add("Típus", typeof(int));
            gDT.Columns.Add("FPS", typeof(int));
            gDT.Columns.Add("Súly", typeof(int));
            gDT.Columns.Add("Anyag", typeof(string));
            gDT.Columns.Add("Ár", typeof(int));
            gDT.Columns.Add("Variáns", typeof(int));

            foreach (Gun g in guns)
            {
                gDT.Rows.Add(g.getFID(), g.getManufact(), g.getName(), g.getType(), g.getFps(), g.getWeight(), g.getMaterial(), g.getPrice(), g.getVariant());
            }

            return gDT;
        }


    }
}
