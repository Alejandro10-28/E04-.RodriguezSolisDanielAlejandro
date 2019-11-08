using System;

namespace Comanda
{
    partial class FrmExamen4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExamen4));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.cmdCobrar = new System.Windows.Forms.Button();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.cboCantidad = new System.Windows.Forms.ComboBox();
            this.TxtBoxPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.lblGrid = new System.Windows.Forms.Label();
            this.lblLista = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dbgrdLista = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstSeleccion = new System.Windows.Forms.ListBox();
            this.cboMenu = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdLista)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.picImage);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.cmdCobrar);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.cmdLimpiar);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.cboCantidad);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TxtBoxPrecio);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lblPrecio);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lblCantidad);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.cmdAdd);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lblGrid);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lblLista);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lblMenu);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TxtTotal);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lblTotal);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dbgrdLista);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lstSeleccion);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.cboMenu);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(734, 428);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(734, 452);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // picImage
            // 
            this.picImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picImage.BackgroundImage")));
            this.picImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picImage.Location = new System.Drawing.Point(556, 24);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(139, 188);
            this.picImage.TabIndex = 20;
            this.picImage.TabStop = false;
            // 
            // cmdCobrar
            // 
            this.cmdCobrar.Location = new System.Drawing.Point(612, 334);
            this.cmdCobrar.Name = "cmdCobrar";
            this.cmdCobrar.Size = new System.Drawing.Size(75, 23);
            this.cmdCobrar.TabIndex = 19;
            this.cmdCobrar.Text = "Cobrar";
            this.cmdCobrar.UseVisualStyleBackColor = true;
            this.cmdCobrar.Click += new System.EventHandler(this.buttonCobrar_Click);
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Location = new System.Drawing.Point(390, 179);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(75, 23);
            this.cmdLimpiar.TabIndex = 18;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboCantidad
            // 
            this.cboCantidad.FormattingEnabled = true;
            this.cboCantidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboCantidad.Location = new System.Drawing.Point(382, 43);
            this.cboCantidad.Name = "cboCantidad";
            this.cboCantidad.Size = new System.Drawing.Size(100, 21);
            this.cboCantidad.TabIndex = 17;
            this.cboCantidad.Text = "0";
            // 
            // TxtBoxPrecio
            // 
            this.TxtBoxPrecio.Location = new System.Drawing.Point(382, 93);
            this.TxtBoxPrecio.Name = "TxtBoxPrecio";
            this.TxtBoxPrecio.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxPrecio.TabIndex = 16;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(387, 77);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 15;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(382, 25);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 14;
            this.lblCantidad.Text = "Cantidad";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(270, 179);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(75, 23);
            this.cmdAdd.TabIndex = 12;
            this.cmdAdd.Text = "Agregar";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // lblGrid
            // 
            this.lblGrid.AutoSize = true;
            this.lblGrid.Location = new System.Drawing.Point(293, 239);
            this.lblGrid.Name = "lblGrid";
            this.lblGrid.Size = new System.Drawing.Size(52, 13);
            this.lblGrid.TabIndex = 11;
            this.lblGrid.Text = "Comanda";
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(215, 24);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(88, 13);
            this.lblLista.TabIndex = 10;
            this.lblLista.Text = "Seleccionar Lista";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(60, 24);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(34, 13);
            this.lblMenu.TabIndex = 8;
            this.lblMenu.Text = "Menu";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(612, 283);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(100, 20);
            this.TxtTotal.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(570, 286);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total";
            // 
            // dbgrdLista
            // 
            this.dbgrdLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgrdLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Cantidad,
            this.Precio,
            this.Total});
            this.dbgrdLista.Location = new System.Drawing.Point(38, 258);
            this.dbgrdLista.Name = "dbgrdLista";
            this.dbgrdLista.ReadOnly = true;
            this.dbgrdLista.Size = new System.Drawing.Size(504, 158);
            this.dbgrdLista.TabIndex = 3;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // lstSeleccion
            // 
            this.lstSeleccion.FormattingEnabled = true;
            this.lstSeleccion.Items.AddRange(new object[] {
            "none"});
            this.lstSeleccion.Location = new System.Drawing.Point(209, 43);
            this.lstSeleccion.Name = "lstSeleccion";
            this.lstSeleccion.Size = new System.Drawing.Size(136, 121);
            this.lstSeleccion.TabIndex = 1;
            // 
            // cboMenu
            // 
            this.cboMenu.FormattingEnabled = true;
            this.cboMenu.Location = new System.Drawing.Point(21, 43);
            this.cboMenu.Name = "cboMenu";
            this.cboMenu.Size = new System.Drawing.Size(121, 21);
            this.cboMenu.TabIndex = 0;
            this.cboMenu.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenu_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.herramientaToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // herramientaToolStripMenuItem
            // 
            this.herramientaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.limpiarToolStripMenuItem,
            this.cobrarToolStripMenuItem});
            this.herramientaToolStripMenuItem.Name = "herramientaToolStripMenuItem";
            this.herramientaToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.herramientaToolStripMenuItem.Text = "Herramienta";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // limpiarToolStripMenuItem
            // 
            this.limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
            this.limpiarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.limpiarToolStripMenuItem.Text = "Limpiar";
            this.limpiarToolStripMenuItem.Click += new System.EventHandler(this.limpiarToolStripMenuItem_Click);
            // 
            // cobrarToolStripMenuItem
            // 
            this.cobrarToolStripMenuItem.Name = "cobrarToolStripMenuItem";
            this.cobrarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.cobrarToolStripMenuItem.Text = "Cobrar";
            this.cobrarToolStripMenuItem.Click += new System.EventHandler(this.cobrarToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.aboutToolStripMenuItem.Text = "Acerca de";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // FrmExamen4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 452);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmExamen4";
            this.Text = "Restaurante";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdLista)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dbgrdLista;
        private System.Windows.Forms.ListBox lstSeleccion;
        private System.Windows.Forms.ComboBox cboMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.Label lblGrid;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.TextBox TxtBoxPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.ComboBox cboCantidad;
        private System.Windows.Forms.Button cmdCobrar;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}

