using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppContactos
{
    public partial class Menu : Form
    {
        private int opcion;
        private Dictionary<string, string> agenda = new Dictionary<string, string>();
        public Menu()
        {
            InitializeComponent();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            optionTitle.Text = "Buscar contacto";
            opcion = 3;
            panelMenu.Visible = false;
            panelBuscar.Visible = true;
            opcion = 0;
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            optionTitle.Text = "Agregar contacto";
            opcion = 3;
            panelMenu.Visible = false;
            panelBuscar.Visible = true;
            opcion = 1;
        }

        private void editar_Click(object sender, EventArgs e)
        {
            optionTitle.Text = "Editar contacto";
            opcion = 2;
            panelMenu.Visible = false;
            panelBuscar.Visible = true;
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            optionTitle.Text = "Eliminar contacto";
            opcion = 3;
            panelMenu.Visible = false;
            panelBuscar.Visible = true;
        }

        private void bBuscarCancelar_Click(object sender, EventArgs e)
        {
            panelBuscar.Visible = false;
            panelMenu.Visible = true;
            contactName.Text = null;
            contactNumber.Text = null;
        }

        private void bbuscarSiguiente_Click(object sender, EventArgs e)
        {
            if (isNombreCorrect() && isNumeroCorrect())
            {
                bool isEditarContacto = false;
                switch (opcion)
                {
                    case 0:
                        buscarContacto();
                        break;
                    case 1:
                        agregarContacto();
                        break;
                    case 2:
                        editarContacto();
                        isEditarContacto = true;
                        break;
                    case 3:
                        eliminarContacto();
                        break;
                }
                panelBuscar.Visible = false;
                if (!isEditarContacto)
                {
                    panelConfirmacion.Visible = true;
                }
            }
        }
        
        private bool isNumeroExistente()
        {
            return agenda.Keys.Any(k => { if (k.Equals(contactNumber.Text)) { return true; } return false; } );
        }

        private bool isNombreExistente()
        {
            return agenda.Values.Any(v => { if (v.Equals(contactName.Text)) { return true; } return false; });
        }

        private void buscarContacto()
        {
            if (isNumeroExistente() && isNumeroExistente())
            {
                textoConfirmacion.Text = "Nombre de contacto: " + contactNumber.Text + "\r\n" +
                    "Numero de contacto: " + contactName.Text;
            }
            else
            {
                textoConfirmacion.Text = "No se ha encontrado este contacto";
            }
        }

        private void agregarContacto()
        {

            if (isNumeroExistente())
            {
                textoConfirmacion.Text = "El número de teléfono ya está registrado";
            }
            else
            {
                agenda.Add(contactNumber.Text, contactName.Text);
                textoConfirmacion.Text = "El contacto fue correctamente registrado";
            }
        }

        private void editarContacto()
        {
            if (isNombreExistente() && isNumeroExistente())
            {
                contactData.Text = contactName.Text + " (" + contactNumber.Text + ")";
                panelEditar.Visible = true;
            }
            else
            {
                textoConfirmacion.Text = "El contacto que has introducido no existe";
            }
        }

        private void eliminarContacto()
        {
            if (isNumeroExistente() && isNombreExistente())
            {
                agenda.Remove(contactNumber.Text);
                textoConfirmacion.Text = "Contacto eliminado con éxito";
            }
            else
            {
                textoConfirmacion.Text = "El contacto introducido no existe";
            }
        }

        private bool isNumeroCorrect()
        {
            String numero = contactNumber.Text;
            if (numero.Equals(""))
            {
                numberError.Text = "Número vacío";
                return false;
            } else if (numero.Length != 9)
            {
                numberError.Text = "Faltan números";
                return false;
            }
            foreach (char c in numero)
            {
                if (c < '0' || c > '9')
                {
                    numberError.Text = "Número incorrecto";
                    return false;
                }
            }
            return true;
        }

        private bool isNombreCorrect()
        {
            if (contactName.Equals(""))
            {
                nameError.Text = "Nombre vacío";
                return false;
            }
            numberError.Text = "";
            return true;
        }

        private void bConfirmacionSiguiente_Click(object sender, EventArgs e)
        {
            contactNumber.Text = "";
            contactName.Text = "";
            panelConfirmacion.Visible = false;
            panelMenu.Visible = true;
        }

        private void bCancelarCambiar_Click(object sender, EventArgs e)
        {
            newContactName.Text = "";
            textoConfirmacion.Text = "Editado cancelado";
            panelEditar.Visible = false;
            panelConfirmacion.Visible = true;
        }

        private void bCambiarNombre_Click(object sender, EventArgs e)
        {
            agenda[contactNumber.Text] = newContactName.Text;
            textoConfirmacion.Text = "Editado con éxito";
            panelEditar.Visible = false;
            panelConfirmacion.Visible = true;
        }
    }
}
