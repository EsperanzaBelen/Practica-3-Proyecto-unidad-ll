using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReproductorDeMusicaBelen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();//aqui en esta parte
            personalizarDiseno();
        }
        #region SubMenuMedios
        private void button1_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelMedios);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelMediosSubMenu_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }
        #region SubMenuMedios
        private void personalizarDiseno()//mi practica
        {
            panelMedios.Visible = false;
            panelListaReproduccion.Visible = false;
            panelEcualizador.Visible = false;

        }
        private void ocultarSubMenu()//creamos otro metodo con condiciones para que muestre las opciones de cadaboton
        {
            if (panelMedios.Visible==true)
            {
                panelMedios.Visible = false;
            }
            if (panelListaReproduccion.Visible == true)
            {
                panelListaReproduccion.Visible = false;
            }
            if (panelEcualizador.Visible == true)
            {
                panelEcualizador.Visible = false;
            }
        }

        private void mostrarSubmenu(Panel algunSubMenu)//creamos el siguiente metodo para agregar parametros
            //la cual sera pasarse informacion entre metodos
        {
            if (algunSubMenu.Visible == false)
            {
                ocultarSubMenu();//mandamos a llamar al metodo 
                algunSubMenu.Visible = true;
            }
            else
            {
                algunSubMenu.Visible = false;

            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void btnListaReproduccion_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelListaReproduccion);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void btnEcualizador_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelEcualizador);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private Form formularioActivo = null;
        //Variable que muestre
        private void abrirChildForm(Form childForm)
        {
            //condicion que si el formulario esta activo muestre lo siguiente 
            //en pantalla.
            if (formularioActivo != null)
            {
                formularioActivo.Close();
                formularioActivo = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelChildForm.Controls.Add(childForm);
                panelChildForm.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }

        }
    }
}
