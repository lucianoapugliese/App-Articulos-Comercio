namespace TP_WinForm
{
    partial class frmAltaArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodArticulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtBoxCodigoArticulo = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.txtBoxUrlImagen = new System.Windows.Forms.TextBox();
            this.txtBoxPrecio = new System.Windows.Forms.TextBox();
            this.cboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.cboBoxMarca = new System.Windows.Forms.ComboBox();
            this.pBoxImagenArticulo = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.bntCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImagenArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodArticulo
            // 
            this.lblCodArticulo.AutoSize = true;
            this.lblCodArticulo.Location = new System.Drawing.Point(53, 55);
            this.lblCodArticulo.Name = "lblCodArticulo";
            this.lblCodArticulo.Size = new System.Drawing.Size(119, 16);
            this.lblCodArticulo.TabIndex = 0;
            this.lblCodArticulo.Text = "Código de artículo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(113, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(90, 107);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(87, 142);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(85, 16);
            this.lblUrlImagen.TabIndex = 0;
            this.lblUrlImagen.Text = "URL Imagen:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(123, 168);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(49, 16);
            this.lblPrecio.TabIndex = 0;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(103, 258);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 16);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(123, 288);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(48, 16);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca:";
            // 
            // txtBoxCodigoArticulo
            // 
            this.txtBoxCodigoArticulo.Location = new System.Drawing.Point(205, 55);
            this.txtBoxCodigoArticulo.Name = "txtBoxCodigoArticulo";
            this.txtBoxCodigoArticulo.Size = new System.Drawing.Size(100, 22);
            this.txtBoxCodigoArticulo.TabIndex = 1;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(205, 83);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(100, 22);
            this.txtBoxNombre.TabIndex = 1;
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Location = new System.Drawing.Point(205, 111);
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(100, 22);
            this.txtBoxDescripcion.TabIndex = 1;
            // 
            // txtBoxUrlImagen
            // 
            this.txtBoxUrlImagen.Location = new System.Drawing.Point(205, 142);
            this.txtBoxUrlImagen.Name = "txtBoxUrlImagen";
            this.txtBoxUrlImagen.Size = new System.Drawing.Size(100, 22);
            this.txtBoxUrlImagen.TabIndex = 1;
            // 
            // txtBoxPrecio
            // 
            this.txtBoxPrecio.Location = new System.Drawing.Point(205, 168);
            this.txtBoxPrecio.Name = "txtBoxPrecio";
            this.txtBoxPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtBoxPrecio.TabIndex = 1;
            // 
            // cboBoxCategoria
            // 
            this.cboBoxCategoria.FormattingEnabled = true;
            this.cboBoxCategoria.Location = new System.Drawing.Point(205, 258);
            this.cboBoxCategoria.Name = "cboBoxCategoria";
            this.cboBoxCategoria.Size = new System.Drawing.Size(100, 24);
            this.cboBoxCategoria.TabIndex = 2;
            // 
            // cboBoxMarca
            // 
            this.cboBoxMarca.FormattingEnabled = true;
            this.cboBoxMarca.Location = new System.Drawing.Point(205, 288);
            this.cboBoxMarca.Name = "cboBoxMarca";
            this.cboBoxMarca.Size = new System.Drawing.Size(100, 24);
            this.cboBoxMarca.TabIndex = 2;
            // 
            // pBoxImagenArticulo
            // 
            this.pBoxImagenArticulo.Location = new System.Drawing.Point(351, 55);
            this.pBoxImagenArticulo.Name = "pBoxImagenArticulo";
            this.pBoxImagenArticulo.Size = new System.Drawing.Size(334, 334);
            this.pBoxImagenArticulo.TabIndex = 3;
            this.pBoxImagenArticulo.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(56, 348);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(98, 41);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // bntCancelar
            // 
            this.bntCancelar.Location = new System.Drawing.Point(207, 348);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(98, 41);
            this.bntCancelar.TabIndex = 4;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 424);
            this.Controls.Add(this.bntCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pBoxImagenArticulo);
            this.Controls.Add(this.cboBoxMarca);
            this.Controls.Add(this.cboBoxCategoria);
            this.Controls.Add(this.txtBoxPrecio);
            this.Controls.Add(this.txtBoxUrlImagen);
            this.Controls.Add(this.txtBoxDescripcion);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.txtBoxCodigoArticulo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodArticulo);
            this.Name = "frmAltaArticulo";
            this.Text = "Nuevo artículo";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImagenArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodArticulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtBoxCodigoArticulo;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.TextBox txtBoxUrlImagen;
        private System.Windows.Forms.TextBox txtBoxPrecio;
        private System.Windows.Forms.ComboBox cboBoxCategoria;
        private System.Windows.Forms.ComboBox cboBoxMarca;
        private System.Windows.Forms.PictureBox pBoxImagenArticulo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button bntCancelar;
    }
}