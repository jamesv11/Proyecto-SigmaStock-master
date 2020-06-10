namespace SigmaStockUI
{
    partial class MovimientoFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovimientoFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.TipoBusquedaCmbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MovimientoTablaDgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.IdMovimientoDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoMovimientoDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacturaDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovimientoTablaDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.TipoBusquedaCmbx);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.MovimientoTablaDgv);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.RoyalBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.SlateBlue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(1, 1);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 20;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(870, 535);
            this.bunifuGradientPanel1.TabIndex = 2;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // TipoBusquedaCmbx
            // 
            this.TipoBusquedaCmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TipoBusquedaCmbx.FormattingEnabled = true;
            this.TipoBusquedaCmbx.Items.AddRange(new object[] {
            "Todos",
            "Salida",
            "Entrada"});
            this.TipoBusquedaCmbx.Location = new System.Drawing.Point(57, 34);
            this.TipoBusquedaCmbx.Name = "TipoBusquedaCmbx";
            this.TipoBusquedaCmbx.Size = new System.Drawing.Size(170, 21);
            this.TipoBusquedaCmbx.TabIndex = 6;
            this.TipoBusquedaCmbx.Text = "Todos";
            this.TipoBusquedaCmbx.SelectedIndexChanged += new System.EventHandler(this.TipoBusquedaCbmx_TextChanged);
            this.TipoBusquedaCmbx.TextChanged += new System.EventHandler(this.TipoBusquedaCbmx_TextChanged);
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
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "filtro:";
            // 
            // MovimientoTablaDgv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MovimientoTablaDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MovimientoTablaDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovimientoTablaDgv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.MovimientoTablaDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MovimientoTablaDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MovimientoTablaDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MovimientoTablaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovimientoTablaDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMovimientoDgv,
            this.FechaDgv,
            this.CantidadDgv,
            this.TipoMovimientoDgv,
            this.DetalleDgv,
            this.FacturaDgv});
            this.MovimientoTablaDgv.DoubleBuffered = true;
            this.MovimientoTablaDgv.EnableHeadersVisualStyles = false;
            this.MovimientoTablaDgv.HeaderBgColor = System.Drawing.Color.Honeydew;
            this.MovimientoTablaDgv.HeaderForeColor = System.Drawing.Color.DarkViolet;
            this.MovimientoTablaDgv.Location = new System.Drawing.Point(25, 64);
            this.MovimientoTablaDgv.Name = "MovimientoTablaDgv";
            this.MovimientoTablaDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MovimientoTablaDgv.Size = new System.Drawing.Size(810, 441);
            this.MovimientoTablaDgv.TabIndex = 1;
            // 
            // IdMovimientoDgv
            // 
            this.IdMovimientoDgv.HeaderText = "IDMovimiento";
            this.IdMovimientoDgv.Name = "IdMovimientoDgv";
            this.IdMovimientoDgv.Width = 120;
            // 
            // FechaDgv
            // 
            this.FechaDgv.HeaderText = "Fecha";
            this.FechaDgv.Name = "FechaDgv";
            this.FechaDgv.Width = 120;
            // 
            // CantidadDgv
            // 
            this.CantidadDgv.HeaderText = "Cantidad";
            this.CantidadDgv.Name = "CantidadDgv";
            this.CantidadDgv.Width = 120;
            // 
            // TipoMovimientoDgv
            // 
            this.TipoMovimientoDgv.HeaderText = "TipoMovimiento";
            this.TipoMovimientoDgv.Name = "TipoMovimientoDgv";
            this.TipoMovimientoDgv.Width = 140;
            // 
            // DetalleDgv
            // 
            this.DetalleDgv.HeaderText = "Detalle";
            this.DetalleDgv.Name = "DetalleDgv";
            this.DetalleDgv.Width = 120;
            // 
            // FacturaDgv
            // 
            this.FacturaDgv.HeaderText = "Factura";
            this.FacturaDgv.Name = "FacturaDgv";
            this.FacturaDgv.Width = 140;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 6;
            this.bunifuElipse1.TargetControl = this.bunifuGradientPanel1;
            // 
            // MovimientoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 539);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MovimientoFrm";
            this.Text = "Form1";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovimientoTablaDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid MovimientoTablaDgv;
        private System.Windows.Forms.ComboBox TipoBusquedaCmbx;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMovimientoDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoMovimientoDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacturaDgv;
    }
}