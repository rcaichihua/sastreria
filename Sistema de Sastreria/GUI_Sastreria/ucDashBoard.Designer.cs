namespace GUI_Sastreria
{
    partial class ucDashBoard
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.mtConsultarVendedores = new MetroFramework.Controls.MetroTile();
            this.mtComunicacionBaja = new MetroFramework.Controls.MetroTile();
            this.mtResumenDiario = new MetroFramework.Controls.MetroTile();
            this.mtNotaDebito = new MetroFramework.Controls.MetroTile();
            this.mtNotaCredito = new MetroFramework.Controls.MetroTile();
            this.mtBoleta = new MetroFramework.Controls.MetroTile();
            this.mtFactura = new MetroFramework.Controls.MetroTile();
            this.mtMovimientoAlmacen = new MetroFramework.Controls.MetroTile();
            this.mtConsultarCatalogo = new MetroFramework.Controls.MetroTile();
            this.mtListaPrecios = new MetroFramework.Controls.MetroTile();
            this.mtGenerarIngresos = new MetroFramework.Controls.MetroTile();
            this.mtConcultarStock = new MetroFramework.Controls.MetroTile();
            this.mtConsultarClientes = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mtConsultarVendedores
            // 
            this.mtConsultarVendedores.ActiveControl = null;
            this.mtConsultarVendedores.Location = new System.Drawing.Point(236, 3);
            this.mtConsultarVendedores.Name = "mtConsultarVendedores";
            this.mtConsultarVendedores.Size = new System.Drawing.Size(238, 100);
            this.mtConsultarVendedores.Style = MetroFramework.MetroColorStyle.Green;
            this.mtConsultarVendedores.TabIndex = 0;
            this.mtConsultarVendedores.Text = "Consultar VENDEDORES";
            this.mtConsultarVendedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtConsultarVendedores.TileImage = global::GUI_Sastreria.Properties.Resources.seller;
            this.mtConsultarVendedores.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtConsultarVendedores.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtConsultarVendedores.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtConsultarVendedores.UseSelectable = true;
            this.mtConsultarVendedores.UseTileImage = true;
            this.mtConsultarVendedores.Click += new System.EventHandler(this.mtConsultarVendedores_Click);
            // 
            // mtComunicacionBaja
            // 
            this.mtComunicacionBaja.ActiveControl = null;
            this.mtComunicacionBaja.Location = new System.Drawing.Point(744, 109);
            this.mtComunicacionBaja.Name = "mtComunicacionBaja";
            this.mtComunicacionBaja.Size = new System.Drawing.Size(266, 100);
            this.mtComunicacionBaja.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtComunicacionBaja.TabIndex = 0;
            this.mtComunicacionBaja.Text = "Comunicación de BAJA";
            this.mtComunicacionBaja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtComunicacionBaja.TileImage = global::GUI_Sastreria.Properties.Resources.comunicacion;
            this.mtComunicacionBaja.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtComunicacionBaja.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtComunicacionBaja.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtComunicacionBaja.UseSelectable = true;
            this.mtComunicacionBaja.UseTileImage = true;
            // 
            // mtResumenDiario
            // 
            this.mtResumenDiario.ActiveControl = null;
            this.mtResumenDiario.Location = new System.Drawing.Point(500, 109);
            this.mtResumenDiario.Name = "mtResumenDiario";
            this.mtResumenDiario.Size = new System.Drawing.Size(238, 100);
            this.mtResumenDiario.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtResumenDiario.TabIndex = 0;
            this.mtResumenDiario.Text = "Resumen DIARIO";
            this.mtResumenDiario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtResumenDiario.TileImage = global::GUI_Sastreria.Properties.Resources.resumendiario;
            this.mtResumenDiario.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtResumenDiario.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtResumenDiario.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtResumenDiario.UseSelectable = true;
            this.mtResumenDiario.UseTileImage = true;
            // 
            // mtNotaDebito
            // 
            this.mtNotaDebito.ActiveControl = null;
            this.mtNotaDebito.Location = new System.Drawing.Point(880, 3);
            this.mtNotaDebito.Name = "mtNotaDebito";
            this.mtNotaDebito.Size = new System.Drawing.Size(130, 100);
            this.mtNotaDebito.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtNotaDebito.TabIndex = 0;
            this.mtNotaDebito.Text = "N. DEBITO";
            this.mtNotaDebito.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtNotaDebito.TileImage = global::GUI_Sastreria.Properties.Resources.nd;
            this.mtNotaDebito.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtNotaDebito.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtNotaDebito.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtNotaDebito.UseSelectable = true;
            this.mtNotaDebito.UseTileImage = true;
            // 
            // mtNotaCredito
            // 
            this.mtNotaCredito.ActiveControl = null;
            this.mtNotaCredito.Location = new System.Drawing.Point(744, 3);
            this.mtNotaCredito.Name = "mtNotaCredito";
            this.mtNotaCredito.Size = new System.Drawing.Size(130, 100);
            this.mtNotaCredito.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtNotaCredito.TabIndex = 0;
            this.mtNotaCredito.Text = "N. CREDITO";
            this.mtNotaCredito.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtNotaCredito.TileImage = global::GUI_Sastreria.Properties.Resources.nc;
            this.mtNotaCredito.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtNotaCredito.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtNotaCredito.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtNotaCredito.UseSelectable = true;
            this.mtNotaCredito.UseTileImage = true;
            // 
            // mtBoleta
            // 
            this.mtBoleta.ActiveControl = null;
            this.mtBoleta.Location = new System.Drawing.Point(622, 3);
            this.mtBoleta.Name = "mtBoleta";
            this.mtBoleta.Size = new System.Drawing.Size(116, 100);
            this.mtBoleta.Style = MetroFramework.MetroColorStyle.Red;
            this.mtBoleta.TabIndex = 0;
            this.mtBoleta.Text = "BOLETA";
            this.mtBoleta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtBoleta.TileImage = global::GUI_Sastreria.Properties.Resources.Boleta;
            this.mtBoleta.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtBoleta.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtBoleta.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtBoleta.UseSelectable = true;
            this.mtBoleta.UseTileImage = true;
            // 
            // mtFactura
            // 
            this.mtFactura.ActiveControl = null;
            this.mtFactura.Location = new System.Drawing.Point(500, 3);
            this.mtFactura.Name = "mtFactura";
            this.mtFactura.Size = new System.Drawing.Size(116, 100);
            this.mtFactura.Style = MetroFramework.MetroColorStyle.Brown;
            this.mtFactura.TabIndex = 0;
            this.mtFactura.Text = "FACTURA";
            this.mtFactura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtFactura.TileImage = global::GUI_Sastreria.Properties.Resources.FACTURA;
            this.mtFactura.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtFactura.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtFactura.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtFactura.UseSelectable = true;
            this.mtFactura.UseTileImage = true;
            // 
            // mtMovimientoAlmacen
            // 
            this.mtMovimientoAlmacen.ActiveControl = null;
            this.mtMovimientoAlmacen.Location = new System.Drawing.Point(236, 109);
            this.mtMovimientoAlmacen.Name = "mtMovimientoAlmacen";
            this.mtMovimientoAlmacen.Size = new System.Drawing.Size(238, 100);
            this.mtMovimientoAlmacen.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtMovimientoAlmacen.TabIndex = 0;
            this.mtMovimientoAlmacen.Text = "Movimiento ALMACEN";
            this.mtMovimientoAlmacen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtMovimientoAlmacen.TileImage = global::GUI_Sastreria.Properties.Resources.store;
            this.mtMovimientoAlmacen.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtMovimientoAlmacen.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtMovimientoAlmacen.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtMovimientoAlmacen.UseSelectable = true;
            this.mtMovimientoAlmacen.UseTileImage = true;
            // 
            // mtConsultarCatalogo
            // 
            this.mtConsultarCatalogo.ActiveControl = null;
            this.mtConsultarCatalogo.Location = new System.Drawing.Point(236, 215);
            this.mtConsultarCatalogo.Name = "mtConsultarCatalogo";
            this.mtConsultarCatalogo.Size = new System.Drawing.Size(238, 100);
            this.mtConsultarCatalogo.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtConsultarCatalogo.TabIndex = 0;
            this.mtConsultarCatalogo.Text = "Consulta CATÁLOGO";
            this.mtConsultarCatalogo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtConsultarCatalogo.TileImage = global::GUI_Sastreria.Properties.Resources.catalogo;
            this.mtConsultarCatalogo.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtConsultarCatalogo.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtConsultarCatalogo.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtConsultarCatalogo.UseSelectable = true;
            this.mtConsultarCatalogo.UseTileImage = true;
            // 
            // mtListaPrecios
            // 
            this.mtListaPrecios.ActiveControl = null;
            this.mtListaPrecios.Location = new System.Drawing.Point(3, 321);
            this.mtListaPrecios.Name = "mtListaPrecios";
            this.mtListaPrecios.Size = new System.Drawing.Size(227, 100);
            this.mtListaPrecios.Style = MetroFramework.MetroColorStyle.Pink;
            this.mtListaPrecios.TabIndex = 0;
            this.mtListaPrecios.Text = "Lista PRECIOS";
            this.mtListaPrecios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtListaPrecios.TileImage = global::GUI_Sastreria.Properties.Resources.listaprecios;
            this.mtListaPrecios.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtListaPrecios.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtListaPrecios.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtListaPrecios.UseSelectable = true;
            this.mtListaPrecios.UseTileImage = true;
            // 
            // mtGenerarIngresos
            // 
            this.mtGenerarIngresos.ActiveControl = null;
            this.mtGenerarIngresos.Location = new System.Drawing.Point(3, 215);
            this.mtGenerarIngresos.Name = "mtGenerarIngresos";
            this.mtGenerarIngresos.Size = new System.Drawing.Size(227, 100);
            this.mtGenerarIngresos.Style = MetroFramework.MetroColorStyle.Red;
            this.mtGenerarIngresos.TabIndex = 0;
            this.mtGenerarIngresos.Text = "Generar INGRESOS";
            this.mtGenerarIngresos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtGenerarIngresos.TileImage = global::GUI_Sastreria.Properties.Resources.ingresos;
            this.mtGenerarIngresos.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtGenerarIngresos.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtGenerarIngresos.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtGenerarIngresos.UseSelectable = true;
            this.mtGenerarIngresos.UseTileImage = true;
            // 
            // mtConcultarStock
            // 
            this.mtConcultarStock.ActiveControl = null;
            this.mtConcultarStock.Location = new System.Drawing.Point(3, 109);
            this.mtConcultarStock.Name = "mtConcultarStock";
            this.mtConcultarStock.Size = new System.Drawing.Size(227, 100);
            this.mtConcultarStock.Style = MetroFramework.MetroColorStyle.Black;
            this.mtConcultarStock.TabIndex = 0;
            this.mtConcultarStock.Text = "Consultar STOCK";
            this.mtConcultarStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtConcultarStock.TileImage = global::GUI_Sastreria.Properties.Resources.clothes;
            this.mtConcultarStock.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtConcultarStock.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtConcultarStock.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtConcultarStock.UseSelectable = true;
            this.mtConcultarStock.UseTileImage = true;
            // 
            // mtConsultarClientes
            // 
            this.mtConsultarClientes.ActiveControl = null;
            this.mtConsultarClientes.Location = new System.Drawing.Point(3, 3);
            this.mtConsultarClientes.Name = "mtConsultarClientes";
            this.mtConsultarClientes.Size = new System.Drawing.Size(227, 100);
            this.mtConsultarClientes.Style = MetroFramework.MetroColorStyle.Purple;
            this.mtConsultarClientes.TabIndex = 0;
            this.mtConsultarClientes.Text = "Consultar CLIENTES";
            this.mtConsultarClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtConsultarClientes.TileImage = global::GUI_Sastreria.Properties.Resources.customer;
            this.mtConsultarClientes.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtConsultarClientes.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtConsultarClientes.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtConsultarClientes.UseSelectable = true;
            this.mtConsultarClientes.UseTileImage = true;
            this.mtConsultarClientes.Click += new System.EventHandler(this.mtConsultarClientes_Click);
            // 
            // ucDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtConsultarVendedores);
            this.Controls.Add(this.mtComunicacionBaja);
            this.Controls.Add(this.mtResumenDiario);
            this.Controls.Add(this.mtNotaDebito);
            this.Controls.Add(this.mtNotaCredito);
            this.Controls.Add(this.mtBoleta);
            this.Controls.Add(this.mtFactura);
            this.Controls.Add(this.mtMovimientoAlmacen);
            this.Controls.Add(this.mtConsultarCatalogo);
            this.Controls.Add(this.mtListaPrecios);
            this.Controls.Add(this.mtGenerarIngresos);
            this.Controls.Add(this.mtConcultarStock);
            this.Controls.Add(this.mtConsultarClientes);
            this.Name = "ucDashBoard";
            this.Size = new System.Drawing.Size(1015, 429);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtConsultarClientes;
        private MetroFramework.Controls.MetroTile mtConcultarStock;
        private MetroFramework.Controls.MetroTile mtMovimientoAlmacen;
        private MetroFramework.Controls.MetroTile mtFactura;
        private MetroFramework.Controls.MetroTile mtConsultarVendedores;
        private MetroFramework.Controls.MetroTile mtResumenDiario;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroTile mtBoleta;
        private MetroFramework.Controls.MetroTile mtNotaCredito;
        private MetroFramework.Controls.MetroTile mtNotaDebito;
        private MetroFramework.Controls.MetroTile mtComunicacionBaja;
        private MetroFramework.Controls.MetroTile mtGenerarIngresos;
        private MetroFramework.Controls.MetroTile mtConsultarCatalogo;
        private MetroFramework.Controls.MetroTile mtListaPrecios;
    }
}
