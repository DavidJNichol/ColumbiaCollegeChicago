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
    public partial class MakeMoneyForm : Form
    {
        VirtualGame vg;

        public MakeMoneyForm()
        {
            InitializeComponent();
        }

        public MakeMoneyForm(VirtualGame vg) : this()
        {
            this.vg = vg;
        }

        private void MakeMoneyForm_Load(object sender, EventArgs e)
        {
            txt_MakeMoneyMenu.Text = this.vg.makeMoneyMenu();
        }

        private void btn_MoneyEnter_Click(object sender, EventArgs e)
        {
            string answer = txt_MakeMoneyAnswer.Text;

            if (this.vg.makeMoney(answer))
            {
                txt_Status.Text = this.vg.makeMoneyRightAnswer();
            }
            else {
                txt_Status.Text = this.vg.makeMoneyWrongAnswer();
            }
        }
    }
}
