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
    public partial class CreatePlayerName : Form
    {
        VirtualGame vg = new VirtualGame();

        public CreatePlayerName()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menu_QuestionName.Text = vg.askPlayerName();
            
        }

        private void menu_QuestionName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string playerName = menu_AnswerName.Text;
            vg.createPlayer(playerName);
            btn_createPlayerName.Enabled = false;

            if (!btn_createPlayerName.Enabled && menu_AnswerName.Text != null)
            {
                btn_NextForm.Enabled = true;
            }
        }

        private void btn_NextForm_Click(object sender, EventArgs e)
        {
            PetMenu pm = new PetMenu(vg);
            pm.Show();
            this.Hide();            
        }
    }
}
