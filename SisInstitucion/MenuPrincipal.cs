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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            PersonalizarDiseño();
            LbTitulo.Text = "";
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
        // Trabajando con el Diseño de Formulario
        private void PersonalizarDiseño()
        {
            PanSubAdm.Visible = false;
            PanSubTans.Visible = false;
            PanConfi.Visible = false;
        }

        private void ocultarSubMenu()
        {
            if (PanSubAdm.Visible == true)
                PanSubAdm.Visible = false;

            if (PanSubTans.Visible == true)
                PanSubTans.Visible = false;

            if (PanConfi.Visible == true)
                PanConfi.Visible = false;
        }

        private void MostarSubMenu(Panel SubMenu)
        {
            if( SubMenu.Visible == false)
            {
                // ocultamos todos los submenus
                ocultarSubMenu();
                SubMenu.Visible = true;
                
            }
            else
            {
                SubMenu.Visible = false;
            }
        }

        private void BtnAdministrar_Click(object sender, EventArgs e)
        {
            MostarSubMenu(PanSubAdm);
        }

        private void BtnInstitucion_Click(object sender, EventArgs e)
        {
            // abrimos el form Hijo 
            AbrirFormularioHijo(new FrmInstitucion());

            // ocultamos los sub menus
            ocultarSubMenu();

            // asignamos titulo
            LbTitulo.Text = " ";
            LbTitulo.Text = "Institucion";

           

        }

        private void BtnDocentes_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();

            LbTitulo.Text = " ";
            LbTitulo.Text = "Docentes";

            AbrirFormularioHijo(new FrmDocentes());
        }


        private void BtnAlumnos_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void BtnNiveles_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void BtnCarreras_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void BtnSeccion_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void BtnJornadas_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void BtnInscripcion_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void BtnAsignacion_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void BtnNotas_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void BtnTransacciones_Click(object sender, EventArgs e)
        {
            MostarSubMenu(PanSubTans);
        }

        // aca tabajamos todo respecto a los formulario hijos

           // declaramos esta variable tipo formulario para almacenar
        private Form FormularioActivo = null;

        // creamos el metodo
        private void AbrirFormularioHijo( Form HijoForm)
        {
            if ( FormularioActivo != null)
            
                FormularioActivo.Close();
                FormularioActivo = HijoForm;


                HijoForm.TopLevel = false;
                HijoForm.FormBorderStyle = FormBorderStyle.None;
                HijoForm.Dock = DockStyle.Fill;

                // asignamos en el panel contenedor
                PanContenedor.Controls.Add(HijoForm);
                PanContenedor.Tag = HijoForm;

                HijoForm.BringToFront();
                HijoForm.Show();

            

        }

        private void BtnConfiguracion_Click(object sender, EventArgs e)
        {
            MostarSubMenu(PanConfi);
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            // ocultamos los sub menus
            ocultarSubMenu();
            // abrimos el form Hijo 
            AbrirFormularioHijo(new FrmUsuarios());

            // ocultamos los sub menus
            //ocultarSubMenu();

            // asignamos titulo
            LbTitulo.Text = " ";
            LbTitulo.Text = "Usuarios";
        }
    }
}
