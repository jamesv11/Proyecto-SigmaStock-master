namespace SigmaStockUI
{
    partial class ConsultarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarProducto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.CantidadProductoTxt = new System.Windows.Forms.TextBox();
            this.CantidadProducto = new System.Windows.Forms.Label();
            this.ProductosDgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.IdProductoDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProductoDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadProductoDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProductoDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVAProductoDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.TipoBusquedaTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TipoBusquedaCmbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RegistrarProducto = new System.Windows.Forms.Button();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.RegistrarProducto);
            this.bunifuGradientPanel1.Controls.Add(this.CantidadProductoTxt);
            this.bunifuGradientPanel1.Controls.Add(this.CantidadProducto);
            this.bunifuGradientPanel1.Controls.Add(this.ProductosDgv);
            this.bunifuGradientPanel1.Controls.Add(this.button1);
            this.bunifuGradientPanel1.Controls.Add(this.TipoBusquedaTxt);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.TipoBusquedaCmbx);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.RoyalBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.SlateBlue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 20;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(867, 539);
            this.bunifuGradientPanel1.TabIndex = 1;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // CantidadProductoTxt
            // 
            this.CantidadProductoTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CantidadProductoTxt.Enabled = false;
            this.CantidadProductoTxt.Location = new System.Drawing.Point(156, 514);
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
            this.CantidadProducto.Location = new System.Drawing.Point(56, 517);
            this.CantidadProducto.Name = "CantidadProducto";
            this.CantidadProducto.Size = new System.Drawing.Size(97, 13);
            this.CantidadProducto.TabIndex = 9;
            this.CantidadProducto.Text = "Cantidad producto:";
            // 
            // ProductosDgv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ProductosDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductosDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductosDgv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.ProductosDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductosDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductosDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductosDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProductoDgv,
            this.NombreProductoDgv,
            this.CantidadProductoDgv,
            this.PrecioProductoDgv,
            this.IVAProductoDgv});
            this.ProductosDgv.DoubleBuffered = true;
            this.ProductosDgv.EnableHeadersVisualStyles = false;
            this.ProductosDgv.HeaderBgColor = System.Drawing.Color.Honeydew;
            this.ProductosDgv.HeaderForeColor = System.Drawing.Color.DarkViolet;
            this.ProductosDgv.Location = new System.Drawing.Point(12, 123);
            this.ProductosDgv.Name = "ProductosDgv";
            this.ProductosDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProductosDgv.Size = new System.Drawing.Size(843, 384);
            this.ProductosDgv.TabIndex = 6;
            // 
            // IdProductoDgv
            // 
            this.IdProductoDgv.HeaderText = "Id Producto";
            this.IdProductoDgv.Name = "IdProductoDgv";
            this.IdProductoDgv.Width = 140;
            // 
            // NombreProductoDgv
            // 
            this.NombreProductoDgv.HeaderText = "Descripcion";
            this.NombreProductoDgv.Name = "NombreProductoDgv";
            this.NombreProductoDgv.Width = 140;
            // 
            // CantidadProductoDgv
            // 
            this.CantidadProductoDgv.HeaderText = "Cantidad";
            this.CantidadProductoDgv.Name = "CantidadProductoDgv";
            this.CantidadProductoDgv.Width = 140;
            // 
            // PrecioProductoDgv
            // 
            this.PrecioProductoDgv.HeaderText = "Precio ";
            this.PrecioProductoDgv.Name = "PrecioProductoDgv";
            this.PrecioProductoDgv.Width = 140;
            // 
            // IVAProductoDgv
            // 
            this.IVAProductoDgv.HeaderText = "IVA";
            this.IVAProductoDgv.Name = "IVAProductoDgv";
            this.IVAProductoDgv.Width = 140;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(473, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TipoBusquedaTxt
            // 
            this.TipoBusquedaTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TipoBusquedaTxt.Location = new System.Drawing.Point(311, 38);
            this.TipoBusquedaTxt.Name = "TipoBusquedaTxt";
            this.TipoBusquedaTxt.Size = new System.Drawing.Size(146, 20);
            this.TipoBusquedaTxt.TabIndex = 3;
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
            // TipoBusquedaCmbx
            // 
            this.TipoBusquedaCmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TipoBusquedaCmbx.FormattingEnabled = true;
            this.TipoBusquedaCmbx.Items.AddRange(new object[] {
            "Todos",
            "Nombre",
            "Codigo"});
            this.TipoBusquedaCmbx.Location = new System.Drawing.Point(141, 38);
            this.TipoBusquedaCmbx.Name = "TipoBusquedaCmbx";
            this.TipoBusquedaCmbx.Size = new System.Drawing.Size(146, 21);
            this.TipoBusquedaCmbx.TabIndex = 1;
            this.TipoBusquedaCmbx.Text = "Todos";
            this.TipoBusquedaCmbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TipoBusquedaCbmx_KeyPress);
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
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de busqueda:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RegistrarProducto
            // 
            this.RegistrarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegistrarProducto.Image = ((System.Drawing.Image)(resources.GetObject("RegistrarProducto.Image")));
            this.RegistrarProducto.Location = new System.Drawing.Point(562, 31);
            this.RegistrarProducto.Name = "RegistrarProducto";
            this.RegistrarProducto.Size = new System.Drawing.Size(75, 34);
            this.RegistrarProducto.TabIndex = 58;
            this.RegistrarProducto.UseVisualStyleBackColor = true;
            this.RegistrarProducto.Click += new System.EventHandler(this.RegistrarProducto_Click);
            // 
            // ConsultarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 539);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarProducto";
            this.Text = "Form1";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid ProductosDgv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TipoBusquedaTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TipoBusquedaCmbx;
        private System.Windows.Forms.TextBox CantidadProductoTxt;
        private System.Windows.Forms.Label CantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProductoDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProductoDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadProductoDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProductoDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVAProductoDgv;
        private System.Windows.Forms.Button RegistrarProducto;
    }
}