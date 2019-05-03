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
    public partial class BuyItemForm : Form
    {
        VirtualGame vg;
        public BuyItemForm()
        {
            InitializeComponent();
        }

        public BuyItemForm(VirtualGame vg) : this()
        {
            this.vg = vg;
        }

        private void BuyItemForm_Load(object sender, EventArgs e)
        {
            txt_PlayerName.Text = this.vg.showPlayerName();
            txt_Wallet.Text = this.vg.showPlayerWallet();

            foreach(var item in this.vg.getListItems())
            {
                listBox1.Items.Add(item.ItemName.ToString());
            }

            foreach (var item in this.vg.getListItems())
            {
                listBox2.Items.Add(item.ItemPrice.ToString());
            }
        }

        private void btn_buyItem_Click(object sender, EventArgs e)
        {
            string choosedItem = listBox1.SelectedItem.ToString();
            if (this.vg.buyItem(choosedItem))
            {
                txt_BuyMessage.Text = "Item Purchased !";
            }
            else
            {
                txt_BuyMessage.Text = "Not enough money!";
            }  
        }
    }
}
