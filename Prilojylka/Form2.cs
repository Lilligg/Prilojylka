using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prilojylka
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string text = textAdd.Text;
           listBox1.Items.Add(text);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            catch { MessageBox.Show("Выделите слово"); }
            
        }
    }
}
