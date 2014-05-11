using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Horoskop
{
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
        }
       
        public void SetZnak(string text)
        {
            this.lblZnak.Text = text;
        }

        public void setDneven(string text)
        {
            this.tbDneven.Text = text;
        }

        public void setNedelen(string text)
        {
            this.tbNedelen.Text = text;
        }

        public void setMesecen(string text)
        {
            this.tbMesecen.Text = text;
        }

        public void setGodisen(string text)
        {
            this.tbGodisen.Text = text;
        }
                
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Application.Exit();
             
        }

       
    }
}
