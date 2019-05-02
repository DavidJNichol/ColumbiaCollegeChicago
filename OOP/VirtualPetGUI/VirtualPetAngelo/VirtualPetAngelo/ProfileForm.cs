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
    public partial class ProfileForm : Form
    {
        VirtualGame vg;

        public ProfileForm()
        {
            InitializeComponent();
        }

        public ProfileForm(VirtualGame vg) : this()
        {
            this.vg = vg;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            txt_PlayerName.Text = this.vg.showPlayerName();
            txt_Wallet.Text = this.vg.showPlayerWallet();
            txt_MyPet.Text = this.vg.showPlayerPet().ToString().Replace("VirtualPetAngelo.", "");

            foreach(var item in this.vg.getListOfPlayerItems())
            {
                list_Items.Items.Add(item.ItemName.ToString());
            }

        }
    }
}
