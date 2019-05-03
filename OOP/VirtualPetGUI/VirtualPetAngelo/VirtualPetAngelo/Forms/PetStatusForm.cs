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
    public partial class PetStatusForm : Form
    {
        VirtualGame vg;

        public PetStatusForm()
        {
            InitializeComponent();
        }

        public PetStatusForm(VirtualGame vg) : this()
        {
            this.vg = vg;
        }

        private void PetStatusForm_Load(object sender, EventArgs e)
        {
            txt_Pet.Text = this.vg.showPlayerPet().Replace("VirtualPetAngelo.", "");
            txt_PetSkill.Text = this.vg.showPlayerPetSkill();
        }
    }
}
