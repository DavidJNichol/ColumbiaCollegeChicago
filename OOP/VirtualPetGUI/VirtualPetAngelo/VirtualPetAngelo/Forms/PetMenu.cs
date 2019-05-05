using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualPetAngelo
{
    public partial class PetMenu : Form
    {
        VirtualGame vg;
        public PetMenu()
        {
            InitializeComponent();
        }

        public PetMenu(VirtualGame vg) : this()
        {
            this.vg = vg;
        }

        private void PetMenu_Load(object sender, EventArgs e)
        {
            txb_PlayerName.Text = this.vg.showPlayerName();
            txb_PlayerWallet.Text = this.vg.showPlayerWallet();

            foreach (var item in this.vg.getListOfPets()) {

                listBox1.Items.Add(item.GetType().ToString().Replace("VirtualPetAngelo.", ""));
            }

            foreach (var item in this.vg.getListOfPets())
            {

                listBox2.Items.Add(item.PetPrice.ToString());
            }

        }

        private void btn_SelectPet_Click(object sender, EventArgs e)
        {
            string selectedPet = listBox1.SelectedItem.ToString();
            if (this.vg.choosePet(selectedPet))
            {
                MainMenu mm = new MainMenu(vg);
                mm.Show();
                this.Hide();
            }
            else
            {
                txt_petMessage.Text = "Not enough money !";
            }           
        }
    }
}
