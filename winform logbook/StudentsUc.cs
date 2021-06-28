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
    public partial class StudentsUc : UserControl
    {
        public string Username { get; set; }
        public StudentsUc()
        {

        }
        public StudentsUc(string username)
        {
            InitializeComponent();
        
            guna2ComboBox1.Enabled = false;
            guna2ComboBox2.Enabled = false;
            guna2ImageButton2.Enabled = false;
            guna2ImageCheckBox1.Enabled = false;
            guna2ImageCheckBox2.Enabled = false;
            guna2ImageCheckBox3.Enabled = false;
            guna2ImageCheckBox4.Enabled = false;
            textBox1.Enabled = false;
            savebtn.Enabled = false;
            pictureBox1.Visible = false;
            this.Username = username;
            userlbl.Text = username;
            string date = DateTime.Now.ToString();
            datelbl.Text = date;
            List<int> num = new List<int>
           {
               1,2,3,4,5,6,7,8,9,10,11,12
           };
            
            
                guna2ComboBox1.DataSource  = num;
                guna2ComboBox2.DataSource  = num;







        }


        private void StudentsUc_Load(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
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

        private void redrdbtn_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void yellowrdbtn_CheckedChanged(object sender, EventArgs e)
        {
guna2ComboBox1.Enabled = true;
            guna2ComboBox2.Enabled = true;
            guna2ImageCheckBox1.Enabled = true;
            guna2ImageCheckBox2.Enabled = true;
            guna2ImageCheckBox3.Enabled = true;
            guna2ImageCheckBox4.Enabled = true;
           
            //textBox1.Enabled = true;
            savebtn.Enabled = true;
            guna2ImageButton2.Enabled = true;
        }

        private void greenrdbtn_CheckedChanged(object sender, EventArgs e)
        {
            guna2ComboBox1.Enabled = true;
            guna2ComboBox2.Enabled = true;
            guna2ImageCheckBox1.Enabled = true;
            guna2ImageCheckBox2.Enabled = true;
            guna2ImageCheckBox3.Enabled = true;
            guna2ImageCheckBox4.Enabled = true;
           // textBox1.Enabled = true;
            savebtn.Enabled = true;
            guna2ImageButton2.Enabled = true;
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;

        }

        private void guna2ImageCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageCheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            guna2ImageCheckBox1.Enabled = false;
            guna2ImageCheckBox2.Enabled = false;
            guna2ImageCheckBox3.Enabled = false;
            guna2ImageCheckBox4.Enabled = false;
        }

        private void guna2CirclePictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }
    }
}
