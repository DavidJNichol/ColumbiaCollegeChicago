using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualPetAngelo.Forms;

namespace VirtualPetAngelo
{
    public partial class MainMenu : Form
    {
        VirtualGame vg;

        public MainMenu()
        {
            InitializeComponent();
        }

        public MainMenu(VirtualGame vg) : this()
        {
            this.vg = vg;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            txt_mainMenu.Text = this.vg.showFirstBanner();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileForm pf = new ProfileForm(vg);
            pf.Show();
        }

        private void makeMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakeMoneyForm mmf = new MakeMoneyForm(vg);
            mmf.Show();
        }

        private void playWithPetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayPetForm ppf = new PlayPetForm(vg);
            ppf.Show();
        }

        private void buyItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuyItemForm bif = new BuyItemForm(vg);
            bif.Show();
        }

        private void sellItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellItemForm sif = new SellItemForm(vg);
            sif.Show();
        }

        private void evolvePetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EvolvePetForm epf = new EvolvePetForm(vg);
            epf.Show();
        }

        private void petStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PetStatusForm psf = new PetStatusForm(vg);
            psf.Show();
        }
    }
}
