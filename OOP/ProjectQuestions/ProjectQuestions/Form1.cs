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
            int result1 = 0;
            int result2 = 0;
            int result3 = 0;
            int result4 = 0;
            int result5 = 0;
            int result6 = 0;
            int result7 = 0;
            int result8 = 0;
            int result9 = 0;
            int final = 0;

            for (int i = 0; i < checkedListBox1.CheckedIndices.Count; i++)
            {
                result1 += checkedListBox1.CheckedIndices[i];
                result1 += 1;
            }

            for (int i = 0; i < checkedListBox2.CheckedIndices.Count; i++)
            {
                result2 += checkedListBox2.CheckedIndices[i];
                result2 += 1;
            }

            for (int i = 0; i < checkedListBox3.CheckedIndices.Count; i++)
            {
                result3 += checkedListBox3.CheckedIndices[i];
                result3 += 1;
            }

            for (int i = 0; i < checkedListBox4.CheckedIndices.Count; i++)
            {
                result4 += checkedListBox4.CheckedIndices[i];
                result4 += 1;
            }

            for (int i = 0; i < checkedListBox5.CheckedIndices.Count; i++)
            {
                result5 += checkedListBox5.CheckedIndices[i];
                result5 += 1;
            }

            for (int i = 0; i < checkedListBox6.CheckedIndices.Count; i++)
            {
                result6 += checkedListBox6.CheckedIndices[i];
                result6 += 1;
            }

            for (int i = 0; i < checkedListBox7.CheckedIndices.Count; i++)
            {
                result7 += checkedListBox7.CheckedIndices[i];
                result7 += 1;
            }

            for (int i = 0; i < checkedListBox8.CheckedIndices.Count; i++)
            {
                result8 += checkedListBox8.CheckedIndices[i];
                result8 += 1;
            }

            for (int i = 0; i < checkedListBox9.CheckedIndices.Count; i++)
            {
                result9 += checkedListBox9.CheckedIndices[i];
                result9 += 1;
            }

            final = result1 + result2 + result3 + result4 + result5 + result6 + result7 + result8 + result9;

            textBox1.Text = final.ToString();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
