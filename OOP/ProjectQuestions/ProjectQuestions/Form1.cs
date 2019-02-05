using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectQuestions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = 0;

            for (int i = 0; i < checkedListBox1.CheckedIndices.Count; i++)
            {
                result += checkedListBox1.CheckedIndices[i];
                result += 1;
            }

            for (int i = 0; i < checkedListBox2.CheckedIndices.Count; i++)
            {
                result += checkedListBox2.CheckedIndices[i];
                result += 1;
            }

            for (int i = 0; i < checkedListBox3.CheckedIndices.Count; i++)
            {
                result += checkedListBox3.CheckedIndices[i];
                result += 1;
            }

            for (int i = 0; i < checkedListBox4.CheckedIndices.Count; i++)
            {
                result += checkedListBox4.CheckedIndices[i];
                result += 1;
            }

            for (int i = 0; i < checkedListBox5.CheckedIndices.Count; i++)
            {
                result += checkedListBox5.CheckedIndices[i];
                result += 1;
            }

            for (int i = 0; i < checkedListBox6.CheckedIndices.Count; i++)
            {
                result += checkedListBox6.CheckedIndices[i];
                result += 1;
            }

            for (int i = 0; i < checkedListBox7.CheckedIndices.Count; i++)
            {
                result += checkedListBox7.CheckedIndices[i];
                result += 1;
            }

            for (int i = 0; i < checkedListBox8.CheckedIndices.Count; i++)
            {
                result += checkedListBox8.CheckedIndices[i];
                result += 1;
            }

            for (int i = 0; i < checkedListBox9.CheckedIndices.Count; i++)
            {
                result += checkedListBox9.CheckedIndices[i];
                result += 1;
            }

            textBox1.Text = result.ToString();
        }
    }
}
