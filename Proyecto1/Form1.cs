using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Proyecto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login()
        {

            SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-PVNQ7PKM;Initial Catalog=Logim;Integrated Security=True");
            Con.Open();
            string Nm = "select * from Userr where Usuario='" + tex1.Text + "' and Password='" + tex2.Text + "'";

            SqlCommand com = new SqlCommand(Nm, Con);

            SqlDataReader lector;

            lector = com.ExecuteReader();
            if (lector.HasRows == true)
            {
                MessageBox.Show("Bienvenido");
            }
            else
            {
                MessageBox.Show("Error");
            }

            Con.Close();

        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tex1 = new System.Windows.Forms.TextBox();
            this.tex2 = new System.Windows.Forms.TextBox();
            this.Acceder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(349, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tex1
            // 
            this.tex1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tex1.Location = new System.Drawing.Point(288, 158);
            this.tex1.Name = "tex1";
            this.tex1.Size = new System.Drawing.Size(233, 22);
            this.tex1.TabIndex = 5;
            // 
            // tex2
            // 
            this.tex2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tex2.Location = new System.Drawing.Point(288, 241);
            this.tex2.Name = "tex2";
            this.tex2.Size = new System.Drawing.Size(233, 22);
            this.tex2.TabIndex = 6;
            // 
            // Acceder
            // 
            this.Acceder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Acceder.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Acceder.Location = new System.Drawing.Point(337, 343);
            this.Acceder.Name = "Acceder";
            this.Acceder.Size = new System.Drawing.Size(127, 30);
            this.Acceder.TabIndex = 7;
            this.Acceder.Text = "Acceder";
            this.Acceder.UseVisualStyleBackColor = false;
            this.Acceder.Click += new System.EventHandler(this.Acceder_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(828, 399);
            this.ControlBox = false;
            this.Controls.Add(this.Acceder);
            this.Controls.Add(this.tex2);
            this.Controls.Add(this.tex1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Acceder_Click(object sender, EventArgs e)
        {
            login();
    }     
    }
}
