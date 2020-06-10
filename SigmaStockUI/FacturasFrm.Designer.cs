namespace SigmaStockUI
{
    partial class FacturasFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturasFrm));
            this.TipoDeFacturaPnl = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.TipoFactruraCbmx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TipoDeFacturaPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // TipoDeFacturaPnl
            // 
            this.TipoDeFacturaPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TipoDeFacturaPnl.BackgroundImage")));
            this.TipoDeFacturaPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TipoDeFacturaPnl.Controls.Add(this.AceptarBtn);
            this.TipoDeFacturaPnl.Controls.Add(this.TipoFactruraCbmx);
            this.TipoDeFacturaPnl.Controls.Add(this.label1);
            this.TipoDeFacturaPnl.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TipoDeFacturaPnl.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(2)))), ((int)(((byte)(115)))));
            this.TipoDeFacturaPnl.GradientTopLeft = System.Drawing.Color.RoyalBlue;
            this.TipoDeFacturaPnl.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(2)))), ((int)(((byte)(115)))));
            this.TipoDeFacturaPnl.Location = new System.Drawing.Point(191, 178);
            this.TipoDeFacturaPnl.Name = "TipoDeFacturaPnl";
            this.TipoDeFacturaPnl.Quality = 10;
            this.TipoDeFacturaPnl.Size = new System.Drawing.Size(423, 100);
            this.TipoDeFacturaPnl.TabIndex = 0;
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(348, 31);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(55, 39);
            this.AceptarBtn.TabIndex = 2;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // TipoFactruraCbmx
            // 
            this.TipoFactruraCbmx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TipoFactruraCbmx.FormattingEnabled = true;
            this.TipoFactruraCbmx.Items.AddRange(new object[] {
            "Factura de venta",
            "Factura de compra"});
            this.TipoFactruraCbmx.Location = new System.Drawing.Point(160, 41);
            this.TipoFactruraCbmx.Name = "TipoFactruraCbmx";
            this.TipoFactruraCbmx.Size = new System.Drawing.Size(169, 21);
            this.TipoFactruraCbmx.TabIndex = 1;
            this.TipoFactruraCbmx.SelectedIndexChanged += new System.EventHandler(this.TipoFactruraCbmx_SelectedIndexChanged);
            this.TipoFactruraCbmx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TipoFactruraCbmx_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de factura:";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 6;
            this.bunifuElipse1.TargetControl = this.TipoDeFacturaPnl;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 6;
            this.bunifuElipse2.TargetControl = this.AceptarBtn;
            // 
            // FacturasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(829, 508);
            this.Controls.Add(this.TipoDeFacturaPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacturasFrm";
            this.Text = "FacturasFrm";
            this.TipoDeFacturaPnl.ResumeLayout(false);
            this.TipoDeFacturaPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel TipoDeFacturaPnl;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.ComboBox TipoFactruraCbmx;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}