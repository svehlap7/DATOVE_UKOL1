using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DatoveUkol1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            FileStream zapis = new FileStream(@"..\..\znaky.dat", FileMode.Open, FileAccess.Read);
            BinaryReader cteni = new BinaryReader(zapis);

            int i = 0;
            char prednim = '0';
            while (cteni.BaseStream.Position < cteni.BaseStream.Length)
            {
                char c = cteni.ReadChar();
                listBox1.Items.Add(c);

                if (c == '?')
                {
                    MessageBox.Show("Prvni vyskyt ? je: " + i + ", a pred nim je: " + prednim);
                }

                prednim = c;
                i++;
            }
            zapis.Close();
        }
    }
}
