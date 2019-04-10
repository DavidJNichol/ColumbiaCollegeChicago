using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlyingVehicleMidterm;

namespace UIAssignment
{
    public partial class Form1 : Form
    {

        AerialVehicle av; // Declare Containment test erial Vehicle

        public Form1()
        {
            InitializeComponent();
            av = new Helicopter(); // Initialize
            UpdateUI();
        }

        void UpdateUI()
        {
            UpdatePanelAerialVehicleUI();
            UpdateTextBoxAboutUI();

        }

        void UpdatePanelAerialVehicleUI()
        {
            panelAerialVehicle.Controls.Clear();
            panelAerialVehicle.Controls.Add(av.Pb);
        }

        private void button_About_Click(object sender, EventArgs e)
        {
            UpdateUI();
        }

        void UpdateTextBoxAboutUI()
        {
            textBoxAbout.Text = av.About();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            av.StartEngine();
            UpdateUI();
        }

        private void buttonTakeOff_Click(object sender, EventArgs e)
        {
            av.TakeOff();
            UpdateUI();
        }

        private void buttonFlyUp_Click(object sender, EventArgs e)
        {
            av.FlyUp();
            UpdateUI();
        }

        private void buttonFlyDown_Click(object sender, EventArgs e)
        {
            av.FlyDown();
            UpdateUI();
        }

        private void comboBoxVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxVehicle.SelectedItem.ToString())
            {
                case "Airplane":
                    av = new Airplane();
                    break;
                case "Helicopter":
                    av = new Helicopter();
                    break;
                default:
                    av = new Airplane();
                    break;
            }

            UpdateUI();
        }
    }
}
