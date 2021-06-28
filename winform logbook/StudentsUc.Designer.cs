
namespace winform_logbook
{
    partial class StudentsUc
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsUc));
            this.userlbl = new System.Windows.Forms.Label();
            this.datelbl = new System.Windows.Forms.Label();
            this.redrdbtn = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.greenrdbtn = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.yellowrdbtn = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.savebtn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageCheckBox4 = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.guna2ImageCheckBox3 = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.guna2ImageCheckBox2 = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.guna2ImageCheckBox1 = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userlbl.Location = new System.Drawing.Point(132, 70);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(46, 20);
            this.userlbl.TabIndex = 11;
            this.userlbl.Text = "user";
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datelbl.Location = new System.Drawing.Point(251, 70);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(45, 20);
            this.datelbl.TabIndex = 10;
            this.datelbl.Text = "date";
            // 
            // redrdbtn
            // 
            this.redrdbtn.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.redrdbtn.CheckedState.BorderThickness = 0;
            this.redrdbtn.CheckedState.FillColor = System.Drawing.Color.Red;
            this.redrdbtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.redrdbtn.CheckedState.Parent = this.redrdbtn;
            this.redrdbtn.Location = new System.Drawing.Point(431, 70);
            this.redrdbtn.Name = "redrdbtn";
            this.redrdbtn.ShadowDecoration.Parent = this.redrdbtn;
            this.redrdbtn.Size = new System.Drawing.Size(20, 20);
            this.redrdbtn.TabIndex = 16;
            this.redrdbtn.Text = "guna2CustomRadioButton3";
            this.redrdbtn.UncheckedState.BorderColor = System.Drawing.Color.Red;
            this.redrdbtn.UncheckedState.BorderThickness = 2;
            this.redrdbtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.redrdbtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.redrdbtn.UncheckedState.Parent = this.redrdbtn;
            this.redrdbtn.CheckedChanged += new System.EventHandler(this.redrdbtn_CheckedChanged);
            // 
            // greenrdbtn
            // 
            this.greenrdbtn.CheckedState.BorderColor = System.Drawing.Color.Lime;
            this.greenrdbtn.CheckedState.BorderThickness = 0;
            this.greenrdbtn.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.greenrdbtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.greenrdbtn.CheckedState.Parent = this.greenrdbtn;
            this.greenrdbtn.Location = new System.Drawing.Point(483, 70);
            this.greenrdbtn.Name = "greenrdbtn";
            this.greenrdbtn.ShadowDecoration.Parent = this.greenrdbtn;
            this.greenrdbtn.Size = new System.Drawing.Size(20, 20);
            this.greenrdbtn.TabIndex = 15;
            this.greenrdbtn.Text = "guna2CustomRadioButton2";
            this.greenrdbtn.UncheckedState.BorderColor = System.Drawing.Color.Lime;
            this.greenrdbtn.UncheckedState.BorderThickness = 2;
            this.greenrdbtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.greenrdbtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.greenrdbtn.UncheckedState.Parent = this.greenrdbtn;
            this.greenrdbtn.CheckedChanged += new System.EventHandler(this.greenrdbtn_CheckedChanged);
            // 
            // yellowrdbtn
            // 
            this.yellowrdbtn.CheckedState.BorderColor = System.Drawing.Color.Yellow;
            this.yellowrdbtn.CheckedState.BorderThickness = 0;
            this.yellowrdbtn.CheckedState.FillColor = System.Drawing.Color.Yellow;
            this.yellowrdbtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.yellowrdbtn.CheckedState.Parent = this.yellowrdbtn;
            this.yellowrdbtn.Location = new System.Drawing.Point(457, 70);
            this.yellowrdbtn.Name = "yellowrdbtn";
            this.yellowrdbtn.ShadowDecoration.Parent = this.yellowrdbtn;
            this.yellowrdbtn.Size = new System.Drawing.Size(20, 20);
            this.yellowrdbtn.TabIndex = 14;
            this.yellowrdbtn.Text = "guna2CustomRadioButton1";
            this.yellowrdbtn.UncheckedState.BorderColor = System.Drawing.Color.Yellow;
            this.yellowrdbtn.UncheckedState.BorderThickness = 2;
            this.yellowrdbtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.yellowrdbtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.yellowrdbtn.UncheckedState.Parent = this.yellowrdbtn;
            this.yellowrdbtn.CheckedChanged += new System.EventHandler(this.yellowrdbtn_CheckedChanged);
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.AutoRoundedCorners = true;
            this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.BorderColor = System.Drawing.Color.Lime;
            this.guna2ComboBox2.BorderRadius = 17;
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.FocusedState.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.Lime;
            this.guna2ComboBox2.HoverState.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.ItemHeight = 30;
            this.guna2ComboBox2.ItemsAppearance.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.Location = new System.Drawing.Point(679, 65);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.ShadowDecoration.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.Size = new System.Drawing.Size(101, 36);
            this.guna2ComboBox2.TabIndex = 21;
            this.guna2ComboBox2.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox2_SelectedIndexChanged);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.AutoRoundedCorners = true;
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2ComboBox1.BorderRadius = 17;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(553, 65);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(97, 36);
            this.guna2ComboBox1.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1103, 67);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 34);
            this.textBox1.TabIndex = 29;
            // 
            // savebtn
            // 
            this.savebtn.CheckedState.Parent = this.savebtn;
            this.savebtn.CustomImages.Parent = this.savebtn;
            this.savebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.savebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.savebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.savebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.savebtn.DisabledState.Parent = this.savebtn;
            this.savebtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.savebtn.ForeColor = System.Drawing.Color.White;
            this.savebtn.HoverState.Parent = this.savebtn;
            this.savebtn.Location = new System.Drawing.Point(1145, 107);
            this.savebtn.Name = "savebtn";
            this.savebtn.ShadowDecoration.Parent = this.savebtn;
            this.savebtn.Size = new System.Drawing.Size(97, 29);
            this.savebtn.TabIndex = 30;
            this.savebtn.Text = "save";
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::winform_logbook.Properties.Resources.baku2;
            this.pictureBox1.Location = new System.Drawing.Point(89, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.CheckedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.Location = new System.Drawing.Point(1006, 65);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.PressedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.ShadowDecoration.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Size = new System.Drawing.Size(51, 46);
            this.guna2ImageButton2.TabIndex = 28;
            this.guna2ImageButton2.Click += new System.EventHandler(this.guna2ImageButton2_Click);
            // 
            // guna2ImageCheckBox4
            // 
            this.guna2ImageCheckBox4.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.guna2ImageCheckBox4.CheckedState.Parent = this.guna2ImageCheckBox4;
            this.guna2ImageCheckBox4.HoverState.Parent = this.guna2ImageCheckBox4;
            this.guna2ImageCheckBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageCheckBox4.Image")));
            this.guna2ImageCheckBox4.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageCheckBox4.ImageRotate = 0F;
            this.guna2ImageCheckBox4.Location = new System.Drawing.Point(952, 81);
            this.guna2ImageCheckBox4.Name = "guna2ImageCheckBox4";
            this.guna2ImageCheckBox4.PressedState.Parent = this.guna2ImageCheckBox4;
            this.guna2ImageCheckBox4.ShadowDecoration.Parent = this.guna2ImageCheckBox4;
            this.guna2ImageCheckBox4.Size = new System.Drawing.Size(24, 20);
            this.guna2ImageCheckBox4.TabIndex = 26;
            this.guna2ImageCheckBox4.CheckedChanged += new System.EventHandler(this.guna2ImageCheckBox4_CheckedChanged);
            // 
            // guna2ImageCheckBox3
            // 
            this.guna2ImageCheckBox3.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.guna2ImageCheckBox3.CheckedState.Parent = this.guna2ImageCheckBox3;
            this.guna2ImageCheckBox3.HoverState.Parent = this.guna2ImageCheckBox3;
            this.guna2ImageCheckBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageCheckBox3.Image")));
            this.guna2ImageCheckBox3.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageCheckBox3.ImageRotate = 0F;
            this.guna2ImageCheckBox3.Location = new System.Drawing.Point(922, 81);
            this.guna2ImageCheckBox3.Name = "guna2ImageCheckBox3";
            this.guna2ImageCheckBox3.PressedState.Parent = this.guna2ImageCheckBox3;
            this.guna2ImageCheckBox3.ShadowDecoration.Parent = this.guna2ImageCheckBox3;
            this.guna2ImageCheckBox3.Size = new System.Drawing.Size(24, 20);
            this.guna2ImageCheckBox3.TabIndex = 25;
            // 
            // guna2ImageCheckBox2
            // 
            this.guna2ImageCheckBox2.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.guna2ImageCheckBox2.CheckedState.Parent = this.guna2ImageCheckBox2;
            this.guna2ImageCheckBox2.HoverState.Parent = this.guna2ImageCheckBox2;
            this.guna2ImageCheckBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageCheckBox2.Image")));
            this.guna2ImageCheckBox2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageCheckBox2.ImageRotate = 0F;
            this.guna2ImageCheckBox2.Location = new System.Drawing.Point(892, 77);
            this.guna2ImageCheckBox2.Name = "guna2ImageCheckBox2";
            this.guna2ImageCheckBox2.PressedState.Parent = this.guna2ImageCheckBox2;
            this.guna2ImageCheckBox2.ShadowDecoration.Parent = this.guna2ImageCheckBox2;
            this.guna2ImageCheckBox2.Size = new System.Drawing.Size(24, 24);
            this.guna2ImageCheckBox2.TabIndex = 24;
            // 
            // guna2ImageCheckBox1
            // 
            this.guna2ImageCheckBox1.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.guna2ImageCheckBox1.CheckedState.Parent = this.guna2ImageCheckBox1;
            this.guna2ImageCheckBox1.HoverState.Parent = this.guna2ImageCheckBox1;
            this.guna2ImageCheckBox1.Image = global::winform_logbook.Properties.Resources.crystal__4_;
            this.guna2ImageCheckBox1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageCheckBox1.ImageRotate = 0F;
            this.guna2ImageCheckBox1.Location = new System.Drawing.Point(862, 77);
            this.guna2ImageCheckBox1.Name = "guna2ImageCheckBox1";
            this.guna2ImageCheckBox1.PressedState.Parent = this.guna2ImageCheckBox1;
            this.guna2ImageCheckBox1.ShadowDecoration.Parent = this.guna2ImageCheckBox1;
            this.guna2ImageCheckBox1.Size = new System.Drawing.Size(24, 24);
            this.guna2ImageCheckBox1.TabIndex = 23;
            this.guna2ImageCheckBox1.CheckedChanged += new System.EventHandler(this.guna2ImageCheckBox1_CheckedChanged);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::winform_logbook.Properties.Resources.hum;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(24, 47);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(59, 54);
            this.guna2CirclePictureBox1.TabIndex = 13;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.MouseHover += new System.EventHandler(this.guna2CirclePictureBox1_MouseHover);
            // 
            // StudentsUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.guna2ImageButton2);
            this.Controls.Add(this.guna2ImageCheckBox4);
            this.Controls.Add(this.guna2ImageCheckBox3);
            this.Controls.Add(this.guna2ImageCheckBox2);
            this.Controls.Add(this.guna2ImageCheckBox1);
            this.Controls.Add(this.guna2ComboBox2);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.redrdbtn);
            this.Controls.Add(this.greenrdbtn);
            this.Controls.Add(this.yellowrdbtn);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.userlbl);
            this.Controls.Add(this.datelbl);
            this.Name = "StudentsUc";
            this.Size = new System.Drawing.Size(1295, 155);
            this.Load += new System.EventHandler(this.StudentsUc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userlbl;
        private System.Windows.Forms.Label datelbl;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton redrdbtn;
        private Guna.UI2.WinForms.Guna2CustomRadioButton greenrdbtn;
        private Guna.UI2.WinForms.Guna2CustomRadioButton yellowrdbtn;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2ImageCheckBox guna2ImageCheckBox1;
        private Guna.UI2.WinForms.Guna2ImageCheckBox guna2ImageCheckBox2;
        private Guna.UI2.WinForms.Guna2ImageCheckBox guna2ImageCheckBox3;
        private Guna.UI2.WinForms.Guna2ImageCheckBox guna2ImageCheckBox4;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private System.Windows.Forms.TextBox textBox1;
        private Guna.UI2.WinForms.Guna2Button savebtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
