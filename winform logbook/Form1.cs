using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_logbook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int x = 50;
            int y = 150;
            List<string> usernames = new List<string>
            {
                "Nezrin Rehimli Ramil",
                "Zeyneb Esgerli Fuad",
                "Ayxan Eliyev Tural"
            };
            foreach (var item in usernames)
            {
                StudentsUc students = new StudentsUc(item);
                students.Location = new Point(x, y);
                y += 100;
                this.Controls.Add(students);

            }
            textBox1.Enabled = false;
            guna2Button1.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            guna2Button1.Enabled = true;
            StudentsUc uc = new StudentsUc();
            
        }

        private void guna2CustomRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            guna2Button1.Enabled = true;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var serializer = new JsonSerializer();


            using (var sw = new StreamWriter("date.json"))


            {


                using (var jw = new JsonTextWriter(sw))


                {


                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;


                    serializer.Serialize(jw, textBox1.Text);
                }
            }
        }
    }
}
