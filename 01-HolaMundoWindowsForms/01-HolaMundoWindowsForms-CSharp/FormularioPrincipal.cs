using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_HolaMundoWindowsForms_CSharp
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

  /// <summary>
  /// 
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
        private void btnsaludar_Click(object sender, EventArgs e)
        {
            clsPersona obPersona = new clsPersona();
            //Aqui recogemos el texto del text box
            obPersona.nombre = txtnombre.Text;
            obPersona.apellido = txtapellido.Text;
            //ahora muestra el mensaje
            // MessageBox.Show("Hola,"+saludo);
            //otra forma
            if (string.IsNullOrEmpty(obPersona.nombre) )
            {
               // MessageBox.Show("Introduce un nombre");
                lblerror.Text = "Introduce un nombre";
            }
            else
            {
                lblerror.Text = "";
            }
             if (string.IsNullOrEmpty(obPersona.apellido))
            {
                lblerrorape.Text = "Introduce un apellido";
            }
            else
            {
                MessageBox.Show($"Hola {obPersona.nombre} {obPersona.apellido}");
                
                lblerrorape.Text = "";
            }
            
        }

        private void lblerror_Click(object sender, EventArgs e)
        {

        }

        private void lblnombre_Click(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
