using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualPetAngelo.Forms
{
    public partial class EvolvePetForm : Form
    {
        VirtualGame vg;

        public EvolvePetForm()
        {
            InitializeComponent();
        }

        public EvolvePetForm(VirtualGame vg) : this()
        {
            this.vg = vg;
        }

        private void EvolvePetForm_Load(object sender, EventArgs e)
        {
            txt_PlayerName.Text = this.vg.showPlayerName();
            txt_PlayerScore.Text = this.vg.showPlayerScore();
            txt_PlayerWallet.Text = this.vg.showPlayerScore();
            txt_PlayerPet.Text = this.vg.showPlayerPet().Replace("VirtualPetAngelo.", "");
        }

        private void btn_Evolve_Click(object sender, EventArgs e)
        {
            if (this.vg.evolvePet())
            {
                txt_evolveMessage.Text = $"Your pet evolved to a {this.vg.showPlayerPet()}";
            }
            else
            {
                txt_evolveMessage.Text = "You don't have enough resources for this action yet !";
            }
        }
    }
}
