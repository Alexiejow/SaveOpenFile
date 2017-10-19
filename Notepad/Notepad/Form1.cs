using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Form1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                SaveFile();
            textBox1.Clear();
        }


        private void SaveFile()
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                    sw.Write(textBox1.Text);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Form1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                    sw.Write(textBox1.Text);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Form1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();
        }
    }
}
