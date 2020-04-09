using System;
using System.IO;
using System.Windows.Forms;

namespace Windows_Forms_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var working = new Work();

            if (checkBox1.Checked)
            {
                foreach (var n in working.OpenAll())
                {
                    listBox1.Items.Add(n);
                }
            }       //Добавляем в список эле-ты из ВСЕХ дерикторий
            else
            {

                foreach (var n in working.OprenFile())
                {
                    listBox1.Items.Add(n);
                }
            }                         //Добавляем ТОЛЬКО из выбранной
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                FileInfo fi = new FileInfo(listBox1.SelectedItem.ToString());

                using (var fileStream = fi.OpenRead())
                using (var sr = new StreamReader(fileStream))
                {
                    label1.Text = sr.ReadLine();
                }
            }                        
        }
    }
}
