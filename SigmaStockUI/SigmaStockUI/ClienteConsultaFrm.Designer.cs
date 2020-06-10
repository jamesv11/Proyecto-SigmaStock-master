namespace SigmaStockUI
{
    partial class ClienteConsultaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteConsultaFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.RegistrarCLiente = new System.Windows.Forms.Button();
            this.CantidadProductoTxt = new System.Windows.Forms.TextBox();
            this.CantidadClientes = new System.Windows.Forms.Label();
            this.OrdenadoCbmx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClientesDgt = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.BusquedaClienteBtn = new System.Windows.Forms.Button();
            this.TipoBusquedaTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TipoBusquedaCmbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IDENTIFICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIMER_NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIMER_APELLIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEGUNDO_APELLIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDgt)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.RegistrarCLiente);
            this.bunifuGradientPanel1.Controls.Add(this.CantidadProductoTxt);
            this.bunifuGradientPanel1.Controls.Add(this.CantidadClientes);
            this.bunifuGradientPanel1.Controls.Add(this.OrdenadoCbmx);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.ClientesDgt);
            this.bunifuGradientPanel1.Controls.Add(this.BusquedaClienteBtn);
            this.bunifuGradientPanel1.Controls.Add(this.TipoBusquedaTxt);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.TipoBusquedaCmbx);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(124)))), ((int)(((byte)(166)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(2)))), ((int)(((byte)(115)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(68)))), ((int)(((byte)(128)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(2)))), ((int)(((byte)(115)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 20;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(867, 539);
            this.bunifuGradientPanel1.TabIndex = 1;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // RegistrarCLiente
            // 
            this.RegistrarCLiente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegistrarCLiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrarCLiente.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.RegistrarCLiente.Image = ((System.Drawing.Image)(resources.GetObject("RegistrarCLiente.Image")));
            this.RegistrarCLiente.Location = new System.Drawing.Point(654, 110);
            this.RegistrarCLiente.Name = "RegistrarCLiente";
            this.RegistrarCLiente.Size = new System.Drawing.Size(75, 34);
            this.RegistrarCLiente.TabIndex = 21;
            this.RegistrarCLiente.UseVisualStyleBackColor = true;
            this.RegistrarCLiente.Click += new System.EventHandler(this.RegistrarCLiente_Click);
            // 
            // CantidadProductoTxt
            // 
            this.CantidadProductoTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CantidadProductoTxt.Enabled = false;
            this.CantidadProductoTxt.Location = new System.Drawing.Point(113, 497);
            this.CantidadProductoTxt.Name = "CantidadProductoTxt";
            this.CantidadProductoTxt.Size = new System.Drawing.Size(55, 20);
            this.CantidadProductoTxt.TabIndex = 20;
            // 
            // CantidadClientes
            // 
            this.CantidadClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CantidadClientes.AutoSize = true;
            this.CantidadClientes.BackColor = System.Drawing.Color.Transparent;
            this.CantidadClientes.ForeColor = System.Drawing.Color.White;
            this.CantidadClientes.Location = new System.Drawing.Point(10, 500);
            this.CantidadClientes.Name = "CantidadClientes";
            this.CantidadClientes.Size = new System.Drawing.Size(97, 13);
            this.CantidadClientes.TabIndex = 19;
            this.CantidadClientes.Text = "Cantidad producto:";
            // 
            // OrdenadoCbmx
            // 
            this.OrdenadoCbmx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdenadoCbmx.FormattingEnabled = true;
            this.OrdenadoCbmx.Items.AddRange(new object[] {
            "Nombre",
            "CC/Nit"});
            this.OrdenadoCbmx.Location = new System.Drawing.Point(99, 123);
            this.OrdenadoCbmx.Name = "OrdenadoCbmx";
            this.OrdenadoCbmx.Size = new System.Drawing.Size(146, 21);
            this.OrdenadoCbmx.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ordenar por:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ClientesDgt
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientesDgt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ClientesDgt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientesDgt.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.ClientesDgt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientesDgt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientesDgt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ClientesDgt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesDgt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDENTIFICACION,
            this.PRIMER_NOMBRE,
            this.PRIMER_APELLIDO,
            this.SEGUNDO_APELLIDO,
            this.DIRECCION,
            this.TELEFONO});
            this.ClientesDgt.DoubleBuffered = true;
            this.ClientesDgt.EnableHeadersVisualStyles = false;
            this.ClientesDgt.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.ClientesDgt.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.ClientesDgt.Location = new System.Drawing.Point(99, 146);
            this.ClientesDgt.Name = "ClientesDgt";
            this.ClientesDgt.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ClientesDgt.Size = new System.Drawing.Size(644, 349);
            this.ClientesDgt.TabIndex = 16;
            // 
            // BusquedaClienteBtn
            // 
            this.BusquedaClienteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BusquedaClienteBtn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BusquedaClienteBtn.Image = ((System.Drawing.Image)(resources.GetObject("BusquedaClienteBtn.Image")));
            this.BusquedaClienteBtn.Location = new System.Drawing.Point(479, 50);
            this.BusquedaClienteBtn.Name = "BusquedaClienteBtn";
            this.BusquedaClienteBtn.Size = new System.Drawing.Size(75, 34);
            this.BusquedaClienteBtn.TabIndex = 15;
            this.BusquedaClienteBtn.UseVisualStyleBackColor = true;
            this.BusquedaClienteBtn.Click += new System.EventHandler(this.BUsquedaCliente_Click);
            // 
            // TipoBusquedaTxt
            // 
            this.TipoBusquedaTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TipoBusquedaTxt.Location = new System.Drawing.Point(317, 57);
            this.TipoBusquedaTxt.Name = "TipoBusquedaTxt";
            this.TipoBusquedaTxt.Size = new System.Drawing.Size(146, 20);
            this.TipoBusquedaTxt.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 13;
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
            "CC/Nit"});
            this.TipoBusquedaCmbx.Location = new System.Drawing.Point(147, 57);
            this.TipoBusquedaCmbx.Name = "TipoBusquedaCmbx";
            this.TipoBusquedaCmbx.Size = new System.Drawing.Size(146, 21);
            this.TipoBusquedaCmbx.TabIndex = 12;
            this.TipoBusquedaCmbx.Text = "Todos";
            this.TipoBusquedaCmbx.SelectedIndexChanged += new System.EventHandler(this.TipoBusquedaCbmx_SelectedIndexChanged);
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
            this.label1.Location = new System.Drawing.Point(18, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tipo de busqueda:";
            // 
            // IDENTIFICACION
            // 
            this.IDENTIFICACION.HeaderText = "Column1";
            this.IDENTIFICACION.Name = "IDENTIFICACION";
            // 
            // PRIMER_NOMBRE
            // 
            this.PRIMER_NOMBRE.HeaderText = "Column1";
            this.PRIMER_NOMBRE.Name = "PRIMER_NOMBRE";
            // 
            // PRIMER_APELLIDO
            // 
            this.PRIMER_APELLIDO.HeaderText = "Column1";
            this.PRIMER_APELLIDO.Name = "PRIMER_APELLIDO";
            // 
            // SEGUNDO_APELLIDO
            // 
            this.SEGUNDO_APELLIDO.HeaderText = "Columna4";
            this.SEGUNDO_APELLIDO.Name = "SEGUNDO_APELLIDO";
            // 
            // DIRECCION
            // 
            this.DIRECCION.HeaderText = "Column5";
            this.DIRECCION.Name = "DIRECCION";
            // 
            // TELEFONO
            // 
            this.TELEFONO.HeaderText = "Column6";
            this.TELEFONO.Name = "TELEFONO";
            // 
            // ClienteConsultaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 539);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClienteConsultaFrm";
            this.Text = "Cliente";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDgt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Button RegistrarCLiente;
        private System.Windows.Forms.TextBox CantidadProductoTxt;
        private System.Windows.Forms.Label CantidadClientes;
        private System.Windows.Forms.ComboBox OrdenadoCbmx;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid ClientesDgt;
        private System.Windows.Forms.Button BusquedaClienteBtn;
        private System.Windows.Forms.TextBox TipoBusquedaTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TipoBusquedaCmbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDENTIFICACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIMER_NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIMER_APELLIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEGUNDO_APELLIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
    }
}