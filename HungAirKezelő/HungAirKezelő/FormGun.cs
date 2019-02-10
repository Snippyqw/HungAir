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
using HungAirKezelő.Expections;

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
            catch (ExcpectionsGun eg)
            {
                ePNew.SetError(bNew, eg.Message);
            }
        }     

        private void bMod_Click(object sender, EventArgs e)
        {
            try
            {
                int fid = Convert.ToInt32(dTGVGun.SelectedRows[0].Cells["Azonosító"].Value);

                Gun g = new Gun(
                    fid,
                    dTGVGun.SelectedRows[0].Cells["Gyártó"].Value.ToString(),
                    dTGVGun.SelectedRows[0].Cells["Név"].Value.ToString(),
                    Convert.ToInt32(dTGVGun.SelectedRows[0].Cells["Típus"].Value),
                    Convert.ToInt32(dTGVGun.SelectedRows[0].Cells["FPS"].Value),
                    Convert.ToInt32(dTGVGun.SelectedRows[0].Cells["Súly"].Value),
                    dTGVGun.SelectedRows[0].Cells["Anyag"].Value.ToString(),
                    Convert.ToInt32(dTGVGun.SelectedRows[0].Cells["Ár"].Value),
                    Convert.ToInt32(dTGVGun.SelectedRows[0].Cells["Variáns"].Value));

                FormNewMod fnm = new FormNewMod(g);
                if (fnm.ShowDialog(this) == DialogResult.OK)
                {
                    Gun editedG = fnm.editedG();
                    sg.editGun(editedG);
                }
                dTGVGun.DataSource = null;
                dTGVGun.DataSource = sg.LoadGunData();

            }
            catch (ExcpectionsGun eg)
            {

            }
            
        }

        public int nextFID()
        {
            return sg.nextFID();
        }
    }
}
