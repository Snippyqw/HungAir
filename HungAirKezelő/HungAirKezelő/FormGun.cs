using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HungAirKezelő.Service;

namespace HungAirKezelő
{
    public partial class FormGun : Form
    {
        ServiceGun sg;

        public FormGun()
        {
            InitializeComponent();
            sg = new ServiceGun();
            
        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            dTGVGun.DataSource = sg.LoadGunData();
        }
    }
}
