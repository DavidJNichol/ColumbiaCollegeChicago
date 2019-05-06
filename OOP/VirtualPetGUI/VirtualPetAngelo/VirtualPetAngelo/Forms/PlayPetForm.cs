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
    public partial class PlayPetForm : Form
    {
        VirtualGame vg;
        public PlayPetForm()
        {
            InitializeComponent();
        }

        public PlayPetForm(VirtualGame vg) : this()
        {
            this.vg = vg;
        }

        private void PlayPetForm_Load(object sender, EventArgs e)
        {
            txt_PlayPetMenu.Text = this.vg.playPetMenu();

            foreach(var item in this.vg.getListOfPlayerItems())
            {
                list_PlayerItems.Items.Add(item.ItemName.ToString());
            }
        }

        private void btn_EnterPlay_Click(object sender, EventArgs e)
        {
            if(list_PlayerItems.SelectedItem == null)
            {
                txt_MessagePlay.Text = "Select item before playing !";
            }
            else
            {
                this.vg.playWithPet();
                txt_MessagePlay.Text = $"{this.vg.showPlayerPet().ToString().Replace("VirtualPetAngelo.", "")} is playing with {list_PlayerItems.SelectedItem.ToString()}";
            }            
        }
    }
}
