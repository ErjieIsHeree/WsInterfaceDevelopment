using System.Windows.Forms;

namespace AppContactos
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bAgregar = new System.Windows.Forms.Button();
            this.bBuscar = new System.Windows.Forms.Button();
            this.bEditar = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.numberError = new System.Windows.Forms.Label();
            this.nameError = new System.Windows.Forms.Label();
            this.optionTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contactNumber = new System.Windows.Forms.TextBox();
            this.contactName = new System.Windows.Forms.TextBox();
            this.bbuscarSiguiente = new System.Windows.Forms.Button();
            this.bBuscarCancelar = new System.Windows.Forms.Button();
            this.panelConfirmacion = new System.Windows.Forms.Panel();
            this.bConfirmacionSiguiente = new System.Windows.Forms.Button();
            this.textoConfirmacion = new System.Windows.Forms.Label();
            this.panelEditar = new System.Windows.Forms.Panel();
            this.newContactName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bCancelarCambiar = new System.Windows.Forms.Button();
            this.bCambiarNombre = new System.Windows.Forms.Button();
            this.contactData = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelBuscar.SuspendLayout();
            this.panelConfirmacion.SuspendLayout();
            this.panelEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(0, 64);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(304, 58);
            this.bAgregar.TabIndex = 1;
            this.bAgregar.Text = "Agregar contacto";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(0, 0);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(304, 58);
            this.bBuscar.TabIndex = 2;
            this.bBuscar.Text = "Buscar contacto";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // bEditar
            // 
            this.bEditar.Location = new System.Drawing.Point(0, 128);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(304, 58);
            this.bEditar.TabIndex = 3;
            this.bEditar.Text = "Editar contacto";
            this.bEditar.UseVisualStyleBackColor = true;
            this.bEditar.Click += new System.EventHandler(this.editar_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(0, 192);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(304, 58);
            this.bEliminar.TabIndex = 4;
            this.bEliminar.Text = "Eliminar contacto";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.bEliminar);
            this.panelMenu.Controls.Add(this.bBuscar);
            this.panelMenu.Controls.Add(this.bEditar);
            this.panelMenu.Controls.Add(this.bAgregar);
            this.panelMenu.Location = new System.Drawing.Point(369, 138);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(304, 250);
            this.panelMenu.TabIndex = 5;
            // 
            // panelBuscar
            // 
            this.panelBuscar.Controls.Add(this.numberError);
            this.panelBuscar.Controls.Add(this.nameError);
            this.panelBuscar.Controls.Add(this.optionTitle);
            this.panelBuscar.Controls.Add(this.label2);
            this.panelBuscar.Controls.Add(this.label1);
            this.panelBuscar.Controls.Add(this.contactNumber);
            this.panelBuscar.Controls.Add(this.contactName);
            this.panelBuscar.Controls.Add(this.bbuscarSiguiente);
            this.panelBuscar.Controls.Add(this.bBuscarCancelar);
            this.panelBuscar.Location = new System.Drawing.Point(391, 107);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(304, 281);
            this.panelBuscar.TabIndex = 6;
            this.panelBuscar.Visible = false;
            // 
            // numberError
            // 
            this.numberError.AutoSize = true;
            this.numberError.ForeColor = System.Drawing.Color.Red;
            this.numberError.Location = new System.Drawing.Point(3, 203);
            this.numberError.Name = "numberError";
            this.numberError.Size = new System.Drawing.Size(0, 16);
            this.numberError.TabIndex = 8;
            // 
            // nameError
            // 
            this.nameError.AutoSize = true;
            this.nameError.ForeColor = System.Drawing.Color.Red;
            this.nameError.Location = new System.Drawing.Point(3, 120);
            this.nameError.Name = "nameError";
            this.nameError.Size = new System.Drawing.Size(0, 16);
            this.nameError.TabIndex = 7;
            // 
            // optionTitle
            // 
            this.optionTitle.AutoSize = true;
            this.optionTitle.Location = new System.Drawing.Point(121, 31);
            this.optionTitle.Name = "optionTitle";
            this.optionTitle.Size = new System.Drawing.Size(40, 16);
            this.optionTitle.TabIndex = 6;
            this.optionTitle.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Introduzca el número del contacto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Introduzca el nombre del contacto";
            // 
            // contactNumber
            // 
            this.contactNumber.Location = new System.Drawing.Point(2, 178);
            this.contactNumber.Name = "contactNumber";
            this.contactNumber.Size = new System.Drawing.Size(298, 22);
            this.contactNumber.TabIndex = 3;
            // 
            // contactName
            // 
            this.contactName.AccessibleDescription = "";
            this.contactName.AccessibleName = "";
            this.contactName.Location = new System.Drawing.Point(2, 95);
            this.contactName.Name = "contactName";
            this.contactName.Size = new System.Drawing.Size(298, 22);
            this.contactName.TabIndex = 2;
            // 
            // bbuscarSiguiente
            // 
            this.bbuscarSiguiente.Location = new System.Drawing.Point(171, 255);
            this.bbuscarSiguiente.Name = "bbuscarSiguiente";
            this.bbuscarSiguiente.Size = new System.Drawing.Size(75, 23);
            this.bbuscarSiguiente.TabIndex = 1;
            this.bbuscarSiguiente.Text = "Siguiente";
            this.bbuscarSiguiente.UseVisualStyleBackColor = true;
            this.bbuscarSiguiente.Click += new System.EventHandler(this.bbuscarSiguiente_Click);
            // 
            // bBuscarCancelar
            // 
            this.bBuscarCancelar.Location = new System.Drawing.Point(53, 255);
            this.bBuscarCancelar.Name = "bBuscarCancelar";
            this.bBuscarCancelar.Size = new System.Drawing.Size(75, 23);
            this.bBuscarCancelar.TabIndex = 0;
            this.bBuscarCancelar.Text = "Cancelar";
            this.bBuscarCancelar.UseVisualStyleBackColor = true;
            this.bBuscarCancelar.Click += new System.EventHandler(this.bBuscarCancelar_Click);
            // 
            // panelConfirmacion
            // 
            this.panelConfirmacion.Controls.Add(this.bConfirmacionSiguiente);
            this.panelConfirmacion.Controls.Add(this.textoConfirmacion);
            this.panelConfirmacion.Location = new System.Drawing.Point(409, 155);
            this.panelConfirmacion.Name = "panelConfirmacion";
            this.panelConfirmacion.Size = new System.Drawing.Size(304, 250);
            this.panelConfirmacion.TabIndex = 7;
            this.panelConfirmacion.Visible = false;
            // 
            // bConfirmacionSiguiente
            // 
            this.bConfirmacionSiguiente.Location = new System.Drawing.Point(211, 210);
            this.bConfirmacionSiguiente.Name = "bConfirmacionSiguiente";
            this.bConfirmacionSiguiente.Size = new System.Drawing.Size(75, 23);
            this.bConfirmacionSiguiente.TabIndex = 9;
            this.bConfirmacionSiguiente.Text = "Siguiente";
            this.bConfirmacionSiguiente.UseVisualStyleBackColor = true;
            this.bConfirmacionSiguiente.Click += new System.EventHandler(this.bConfirmacionSiguiente_Click);
            // 
            // textoConfirmacion
            // 
            this.textoConfirmacion.AutoSize = true;
            this.textoConfirmacion.Location = new System.Drawing.Point(87, 85);
            this.textoConfirmacion.Name = "textoConfirmacion";
            this.textoConfirmacion.Size = new System.Drawing.Size(120, 16);
            this.textoConfirmacion.TabIndex = 0;
            this.textoConfirmacion.Text = "Texto confirmación";
            // 
            // panelEditar
            // 
            this.panelEditar.Controls.Add(this.newContactName);
            this.panelEditar.Controls.Add(this.label4);
            this.panelEditar.Controls.Add(this.bCancelarCambiar);
            this.panelEditar.Controls.Add(this.bCambiarNombre);
            this.panelEditar.Controls.Add(this.contactData);
            this.panelEditar.Controls.Add(this.label3);
            this.panelEditar.Location = new System.Drawing.Point(425, 138);
            this.panelEditar.Name = "panelEditar";
            this.panelEditar.Size = new System.Drawing.Size(304, 250);
            this.panelEditar.TabIndex = 8;
            this.panelEditar.Visible = false;
            // 
            // newContactName
            // 
            this.newContactName.Location = new System.Drawing.Point(3, 136);
            this.newContactName.Name = "newContactName";
            this.newContactName.Size = new System.Drawing.Size(298, 22);
            this.newContactName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nuevo nombre de contacto";
            // 
            // bCancelarCambiar
            // 
            this.bCancelarCambiar.Location = new System.Drawing.Point(49, 188);
            this.bCancelarCambiar.Name = "bCancelarCambiar";
            this.bCancelarCambiar.Size = new System.Drawing.Size(75, 23);
            this.bCancelarCambiar.TabIndex = 3;
            this.bCancelarCambiar.Text = "Cancelar";
            this.bCancelarCambiar.UseVisualStyleBackColor = true;
            this.bCancelarCambiar.Click += new System.EventHandler(this.bCancelarCambiar_Click);
            // 
            // bCambiarNombre
            // 
            this.bCambiarNombre.Location = new System.Drawing.Point(173, 188);
            this.bCambiarNombre.Name = "bCambiarNombre";
            this.bCambiarNombre.Size = new System.Drawing.Size(75, 23);
            this.bCambiarNombre.TabIndex = 2;
            this.bCambiarNombre.Text = "Cambiar";
            this.bCambiarNombre.UseVisualStyleBackColor = true;
            this.bCambiarNombre.Click += new System.EventHandler(this.bCambiarNombre_Click);
            // 
            // contactData
            // 
            this.contactData.AutoSize = true;
            this.contactData.Location = new System.Drawing.Point(89, 68);
            this.contactData.Name = "contactData";
            this.contactData.Size = new System.Drawing.Size(119, 16);
            this.contactData.TabIndex = 1;
            this.contactData.Text = "Datos del contacto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Editar Contacto";
            // 
            // Menu
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 577);
            this.Controls.Add(this.panelEditar);
            this.Controls.Add(this.panelBuscar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelConfirmacion);
            this.Name = "Menu";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            this.panelConfirmacion.ResumeLayout(false);
            this.panelConfirmacion.PerformLayout();
            this.panelEditar.ResumeLayout(false);
            this.panelEditar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Button bEditar;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Panel panelMenu;
        private Panel panelBuscar;
        private Button bbuscarSiguiente;
        private Button bBuscarCancelar;
        private Label label1;
        private TextBox contactNumber;
        private TextBox contactName;
        private Label label2;
        private Label optionTitle;
        private Label numberError;
        private Label nameError;
        private Panel panelConfirmacion;
        private Button bConfirmacionSiguiente;
        private Label textoConfirmacion;
        private Panel panelEditar;
        private Label label3;
        private Label contactData;
        private Button bCancelarCambiar;
        private Button bCambiarNombre;
        private TextBox newContactName;
        private Label label4;
    }
}

