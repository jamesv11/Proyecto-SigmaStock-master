namespace SigmaStockUI
{
    partial class ConsultarFacturaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarFacturaFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FAc = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.DetallesDgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeBusquedaDTP = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CantidadProductoTxt = new System.Windows.Forms.TextBox();
            this.CantidadProducto = new System.Windows.Forms.Label();
            this.FacturasDgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.BusquedaFacturaBtn = new System.Windows.Forms.Button();
            this.TipoFactiraTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TipoBusquedaCbmx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumeroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // FAc
            // 
            this.FAc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FAc.BackgroundImage")));
            this.FAc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FAc.Controls.Add(this.DetallesDgv);
            this.FAc.Controls.Add(this.FechaDeBusquedaDTP);
            this.FAc.Controls.Add(this.textBox3);
            this.FAc.Controls.Add(this.label5);
            this.FAc.Controls.Add(this.textBox2);
            this.FAc.Controls.Add(this.label4);
            this.FAc.Controls.Add(this.CantidadProductoTxt);
            this.FAc.Controls.Add(this.CantidadProducto);
            this.FAc.Controls.Add(this.FacturasDgv);
            this.FAc.Controls.Add(this.BusquedaFacturaBtn);
            this.FAc.Controls.Add(this.TipoFactiraTxt);
            this.FAc.Controls.Add(this.label2);
            this.FAc.Controls.Add(this.TipoBusquedaCbmx);
            this.FAc.Controls.Add(this.label1);
            this.FAc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FAc.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.FAc.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.FAc.GradientTopLeft = System.Drawing.Color.RoyalBlue;
            this.FAc.GradientTopRight = System.Drawing.Color.SlateBlue;
            this.FAc.Location = new System.Drawing.Point(0, 0);
            this.FAc.Name = "FAc";
            this.FAc.Quality = 20;
            this.FAc.Size = new System.Drawing.Size(867, 539);
            this.FAc.TabIndex = 2;
            this.FAc.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // DetallesDgv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DetallesDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DetallesDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetallesDgv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DetallesDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetallesDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DetallesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetallesDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProducto,
            this.Cantidad,
            this.PrecioUnitario,
            this.PrecioNeto});
            this.DetallesDgv.DoubleBuffered = true;
            this.DetallesDgv.EnableHeadersVisualStyles = false;
            this.DetallesDgv.HeaderBgColor = System.Drawing.Color.Empty;
            this.DetallesDgv.HeaderForeColor = System.Drawing.Color.Black;
            this.DetallesDgv.Location = new System.Drawing.Point(395, 93);
            this.DetallesDgv.Name = "DetallesDgv";
            this.DetallesDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DetallesDgv.Size = new System.Drawing.Size(460, 410);
            this.DetallesDgv.TabIndex = 16;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.HeaderText = "Codigo Producto";
            this.CodigoProducto.Name = "CodigoProducto";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.Width = 110;
            // 
            // PrecioNeto
            // 
            this.PrecioNeto.HeaderText = "Precio Neto";
            this.PrecioNeto.Name = "PrecioNeto";
            this.PrecioNeto.Width = 120;
            // 
            // FechaDeBusquedaDTP
            // 
            this.FechaDeBusquedaDTP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FechaDeBusquedaDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDeBusquedaDTP.Location = new System.Drawing.Point(243, 40);
            this.FechaDeBusquedaDTP.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.FechaDeBusquedaDTP.Name = "FechaDeBusquedaDTP";
            this.FechaDeBusquedaDTP.Size = new System.Drawing.Size(146, 20);
            this.FechaDeBusquedaDTP.TabIndex = 15;
            this.FechaDeBusquedaDTP.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(602, 513);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(55, 20);
            this.textBox3.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(440, 517);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cantidad Facturas  de Compra:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(376, 513);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(55, 20);
            this.textBox2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(223, 517);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cantidad Facturas  de venta:";
            // 
            // CantidadProductoTxt
            // 
            this.CantidadProductoTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CantidadProductoTxt.Enabled = false;
            this.CantidadProductoTxt.Location = new System.Drawing.Point(159, 513);
            this.CantidadProductoTxt.Name = "CantidadProductoTxt";
            this.CantidadProductoTxt.Size = new System.Drawing.Size(55, 20);
            this.CantidadProductoTxt.TabIndex = 10;
            // 
            // CantidadProducto
            // 
            this.CantidadProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CantidadProducto.AutoSize = true;
            this.CantidadProducto.BackColor = System.Drawing.Color.Transparent;
            this.CantidadProducto.ForeColor = System.Drawing.Color.White;
            this.CantidadProducto.Location = new System.Drawing.Point(16, 517);
            this.CantidadProducto.Name = "CantidadProducto";
            this.CantidadProducto.Size = new System.Drawing.Size(134, 13);
            this.CantidadProducto.TabIndex = 9;
            this.CantidadProducto.Text = "Cantidad Facturas en total:";
            // 
            // FacturasDgv
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FacturasDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.FacturasDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FacturasDgv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.FacturasDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FacturasDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FacturasDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.FacturasDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FacturasDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroFactura,
            this.FechaFactura});
            this.FacturasDgv.DoubleBuffered = true;
            this.FacturasDgv.EnableHeadersVisualStyles = false;
            this.FacturasDgv.HeaderBgColor = System.Drawing.Color.Empty;
            this.FacturasDgv.HeaderForeColor = System.Drawing.Color.Black;
            this.FacturasDgv.Location = new System.Drawing.Point(12, 93);
            this.FacturasDgv.Name = "FacturasDgv";
            this.FacturasDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.FacturasDgv.Size = new System.Drawing.Size(377, 410);
            this.FacturasDgv.TabIndex = 6;
            this.FacturasDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FacturasDgv_CellClick);
            this.FacturasDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FacturasDgv_CellContentClick);
            // 
            // BusquedaFacturaBtn
            // 
            this.BusquedaFacturaBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BusquedaFacturaBtn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BusquedaFacturaBtn.Image = ((System.Drawing.Image)(resources.GetObject("BusquedaFacturaBtn.Image")));
            this.BusquedaFacturaBtn.Location = new System.Drawing.Point(395, 33);
            this.BusquedaFacturaBtn.Name = "BusquedaFacturaBtn";
            this.BusquedaFacturaBtn.Size = new System.Drawing.Size(75, 34);
            this.BusquedaFacturaBtn.TabIndex = 4;
            this.BusquedaFacturaBtn.UseVisualStyleBackColor = true;
            this.BusquedaFacturaBtn.Visible = false;
            this.BusquedaFacturaBtn.Click += new System.EventHandler(this.BusquedaFacturaBtn_Click);
            // 
            // TipoFactiraTxt
            // 
            this.TipoFactiraTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TipoFactiraTxt.Location = new System.Drawing.Point(243, 40);
            this.TipoFactiraTxt.Name = "TipoFactiraTxt";
            this.TipoFactiraTxt.Size = new System.Drawing.Size(146, 20);
            this.TipoFactiraTxt.TabIndex = 3;
            this.TipoFactiraTxt.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // TipoBusquedaCbmx
            // 
            this.TipoBusquedaCbmx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TipoBusquedaCbmx.FormattingEnabled = true;
            this.TipoBusquedaCbmx.Items.AddRange(new object[] {
            "Todos",
            "N° factura",
            "Fecha"});
            this.TipoBusquedaCbmx.Location = new System.Drawing.Point(141, 40);
            this.TipoBusquedaCbmx.Name = "TipoBusquedaCbmx";
            this.TipoBusquedaCbmx.Size = new System.Drawing.Size(96, 21);
            this.TipoBusquedaCbmx.TabIndex = 1;
            this.TipoBusquedaCbmx.SelectedIndexChanged += new System.EventHandler(this.TipoBusquedaCbmx_SelectedIndexChanged);
            this.TipoBusquedaCbmx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TipoBusquedaCbmx_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de busqueda:";
            // 
            // NumeroFactura
            // 
            this.NumeroFactura.HeaderText = "Numero Factura";
            this.NumeroFactura.Name = "NumeroFactura";
            this.NumeroFactura.ReadOnly = true;
            this.NumeroFactura.Width = 170;
            // 
            // FechaFactura
            // 
            this.FechaFactura.HeaderText = "Fecha Factura";
            this.FechaFactura.Name = "FechaFactura";
            this.FechaFactura.ReadOnly = true;
            this.FechaFactura.Width = 170;
            // 
            // ConsultarFacturaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 539);
            this.Controls.Add(this.FAc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarFacturaFrm";
            this.Text = "Form1";
            this.FAc.ResumeLayout(false);
            this.FAc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel FAc;
        private System.Windows.Forms.TextBox CantidadProductoTxt;
        private System.Windows.Forms.Label CantidadProducto;
        private Bunifu.Framework.UI.BunifuCustomDataGrid FacturasDgv;
        private System.Windows.Forms.Button BusquedaFacturaBtn;
        private System.Windows.Forms.TextBox TipoFactiraTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TipoBusquedaCbmx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FechaDeBusquedaDTP;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DetallesDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioNeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFactura;
    }
}