using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SisInstitucion
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            PanInfoUsu.Visible = false;
        }
        // instanciamos la clase conexion
        ConectionSQL Csql = new ConectionSQL();
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            DgvUsuario.DataSource = Csql.MostarDatos();
            LetraYcolor();

        }



        // 
        private void ocultarSubMenu()
        {
            if (PanInfoUsu.Visible == true)
                PanInfoUsu.Visible = false;

            if (PaEncUsu.Visible == true)
                PaEncUsu.Visible = false;

        }

        private void MostarSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                // ocultamos todos los submenus
                //ocultarSubMenu();
                SubMenu.Visible = true;

            }
            else
            {
                SubMenu.Visible = false;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnCrearUs_Click(object sender, EventArgs e)
        {
            MostarSubMenu(PanInfoUsu);
            MostarSubMenu(PaEncUsu);
            LimpiarInfo();
        }

        private void BtnCanUs_Click(object sender, EventArgs e)
        {
            MostarSubMenu(PaEncUsu);
            MostarSubMenu(PanInfoUsu);
            LimpiarInfo();
        }

        private void LimpiarInfo()
        {
            TxtApeUs.Text = "";
            TxtConUs.Text = "";
            TxtNomUs.Text = "";
            TxtUsUs.Text = "";
            TxtBuscarUs.text = "";
        }

        private void DgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            LetraYcolor();


            DataGridViewRow fila = DgvUsuario.Rows[e.ColumnIndex];
            if (this.DgvUsuario.CanSelect == true)
            
                TxtCodigoUs.Text = Convert.ToString(fila.Cells[0].Value);
                TxtNomUs.Text = Convert.ToString(fila.Cells[1].Value);
                TxtApeUs.Text = Convert.ToString(fila.Cells[2].Value);
                TxtUsUs.Text = Convert.ToString(fila.Cells[3].Value);
                TxtConUs.Text = Convert.ToString(fila.Cells[4].Value);
            
           

          
        }



        private void LetraYcolor()
        {
            //this.DgvUsuario.DefaultCellStyle.Font = new Font("Tahoma", 15);
            //this.DgvUsuario.DefaultCellStyle.ForeColor = Color.Black;
            //this.DgvUsuario.DefaultCellStyle.BackColor = Color.Black;
            // this.DgvUsuario.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            // this.DgvUsuario.DefaultCellStyle.SelectionBackColor = Color.Black;

            this.DgvUsuario.EnableHeadersVisualStyles = false;
        }

        private void BtnGuardarUs_Click(object sender, EventArgs e)
        {
            LbTotUs.Text = "Total Usuarios" +  DgvUsuario.Rows.Count.ToString();
            if (Csql.Insertar(TxtCodigoUs.Text, TxtNomUs.Text, TxtApeUs.Text, TxtUsUs.Text, TxtConUs.Text))
                MessageBox.Show("Datos Insertados ");

            DgvUsuario.DataSource = Csql.MostarDatos();
        }

    }
}
