using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HungAirKezelő.Repositories;
using System.Data;

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

    }
}
