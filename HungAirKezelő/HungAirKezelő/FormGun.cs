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
using HungAirKezelő.Classes;

namespace HungAirKezelő
{
    public partial class FormGun : Form
    {
        ServiceGun sg;

        public FormGun()
        {
            InitializeComponent();
            sg = new ServiceGun();
            dTGVGun.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            dTGVGun.DataSource = sg.LoadGunData();
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            try
            {
                Gun ng = new Gun(nextFID());

                FormNewMod fnm = new FormNewMod(ng);
                if (fnm.ShowDialog(this) == DialogResult.OK)
                {
                    Gun editedG = fnm.editedG();

                    sg.addGun(editedG);
                    
                }
                dTGVGun.DataSource = null;
                dTGVGun.DataSource = sg.LoadGunData();

            }
            catch (Exception ex)
            {

            }
        }

        public int nextFID()
        {
            return sg.nextFID();
        }
    }
}
