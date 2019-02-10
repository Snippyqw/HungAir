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

    }
}
