using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungAirKezelő.Classes
{
    partial class Gun
    {
        public string getInsertQuery()
        {
            string queryInsert = "INSERT INTO `fegyverek` (`FID`, `gyarto`, `nev`, `tipus`, `FPS`, `suly`, `anyag`, `ar`, `varians`) VALUES " +
                "(NULL, '"+getManufact()+"', '"+getName()+"', '"+getType()+"', '"+getFps()+"', '"+getWeight()+"', '"+getMaterial()+"', '"+getPrice()+"', '"+getVariant()+"');";
            
            return queryInsert;
        }

        public string getUpdateQuery()
        {
            string queryUpdate = "UPDATE `fegyverek` SET gyarto = '" + getManufact() + "', " +
                "nev = '" + getName() + "', " +
                "tipus = '"+getType()+"', " +
                "FPS = '"+getFps()+"', " +
                "suly = '"+getWeight()+"', " +
                "anyag = '"+getMaterial()+"', " +
                "ar = '"+getPrice()+"', " +
                "varians = '"+getVariant()+"' " +
                "WHERE FID = '" + getFID() + "' ;";
            return queryUpdate;
        }

        public string getDeleteQuery()
        {
            string queryDelete = "DELETE FROM `fegyverek` WHERE `fegyverek`.`FID` = "+getFID()+";";
            return queryDelete;
        }

    }
}
