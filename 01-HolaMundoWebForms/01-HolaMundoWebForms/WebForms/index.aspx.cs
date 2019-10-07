using _01_HolaMundoWebForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace _01_HolaMundoWebForms.WebForms
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
      
/// <summary>
        /// Evento al boton saludar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Saludar_Click(object sender, EventArgs e)
        {
            clsPersona persona = new clsPersona();

            persona.nombre = nombre.Text;

            saludo.Text = radioSaludo.SelectedItem.Text+" "+ persona.nombre;
            saludo.Visible = true;
        }
    }
}