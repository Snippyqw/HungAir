using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HungAirKezelő.Repositories;
using System.Data;
using HungAirKezelő.Classes;
using HungAirKezelő.Expections;

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
                throw new ExcpectionsGun(editedG.getFID() + " az adatbázisban már található ilyen azonosítójú rekord!");
            }
            else
            {
                rg.addGun(editedG);
            }
        }

        public void editGun(Gun editedG)
        {
            if (!rg.checkExist(editedG))
            {
                throw new ExcpectionsGun(editedG.getFID() + " az adatbázisban már található ilyen azonosítójú rekord!");
            }
            else
            {
                rg.editGun(editedG);
            }
        }

        internal void delGun(Gun delG)
        {
            if (!rg.checkExist(delG))
            {
                throw new ExcpectionsGun(delG.getFID() + " az adatbázisban nem található ilyen azonosítójú rekord!");
            }
            else
            {
                rg.deleteGun(delG);
            }
        }
    }
}
