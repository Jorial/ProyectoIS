using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SisInstitucion
{
    public partial class Form1 : Form
    {


        int posY = 0;
        int posX = 0;



        public Form1()
        {
            InitializeComponent();
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_Move(object sender, EventArgs e)
        {
        }

        

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button  != MouseButtons.Left )
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();            


            
            
        }
    }
    
}
