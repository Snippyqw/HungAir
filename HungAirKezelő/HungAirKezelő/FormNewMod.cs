using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HungAirKezelő.Classes;

namespace HungAirKezelő
{
    public partial class FormNewMod : Form
    {
        private Gun g;

        public FormNewMod(Gun g)
        {
            InitializeComponent();
            this.g = g;
            showData();
        }

        private void showData()
        {
            tBFID.Text = g.getFID().ToString();
            tBMan.Text = g.getManufact();
            tBNam.Text = g.getName();
            tBTyp.Text = g.getType().ToString();
            tBFPS.Text = g.getFps().ToString();
            tBWei.Text = g.getWeight().ToString();
            tBMat.Text = g.getMaterial();
            tBPri.Text = g.getPrice().ToString();
            tBVar.Text = g.getVariant().ToString();
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            g.setFID(Convert.ToInt32(tBFID.Text));
            g.setManufact(tBMan.Text);
            g.setName(tBNam.Text);
            g.setType(Convert.ToInt32(tBTyp.Text));
            g.setFps(Convert.ToInt32(tBFPS.Text));
            g.setWeight(Convert.ToInt32(tBWei.Text));
            g.setMaterial(tBMat.Text);
            g.setPrice(Convert.ToInt32(tBPri.Text));
            g.setVariant(Convert.ToInt32(tBVar.Text));
            this.Close();
        }

        public Gun editedG()
        {
            return g;
        }
    }
}
