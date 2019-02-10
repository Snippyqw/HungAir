using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HungAirKezelő.Repositories;
using System.Data;
using HungAirKezelő.Classes;

namespace HungAirKezelő.Service
{
    class ServiceGun
    {
        RepoGuns rg;

        public ServiceGun()
        {
            rg = new RepoGuns();
        }

        public DataTable LoadGunData()
        {
            return rg.getGunsDT();
        }

        public int nextFID()
        {
            return rg.getFID();
        }

        public void addGun(Gun editedG)
        {
            if (rg.checkExist(editedG))
            {

            }
            else
            {
                rg.addGun(editedG);
            }
        }
    }
}
