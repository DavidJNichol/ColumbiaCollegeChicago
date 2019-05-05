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
    public partial class SellItemForm : Form
    {

        VirtualGame vg;
        public SellItemForm()
        {
            InitializeComponent();
        }

        public SellItemForm(VirtualGame vg) : this()
        {
            this.vg = vg;
        }

        private void SellItemForm_Load(object sender, EventArgs e)
        {
            txt_playerName.Text = this.vg.showPlayerName();
            txt_playerWallet.Text = this.vg.showPlayerWallet();

            foreach(var item in this.vg.getListOfPlayerItems())
            {
                list_Items.Items.Add(item.ItemName.ToString());
            }

            foreach (var item in this.vg.getListOfPlayerItems())
            {
                list_itemsPrice.Items.Add(item.ItemPrice.ToString());
            }
        }

        private void btn_SellItem_Click(object sender, EventArgs e)
        {
            string chooseItem = list_Items.SelectedItem.ToString();
            this.vg.sellItem(chooseItem);         
            txt_messageSell.Text = this.vg.sellItemMessage();
        }
    }
}
