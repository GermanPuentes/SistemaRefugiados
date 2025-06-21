namespace SistemaRefugiados.GUI
{
    partial class FrmRefugiados
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            txtDocumento = new TextBox();
            Nombres = new Label();
            Apellidos = new Label();
            Documento = new Label();
            EstadoCivil = new Label();
            TipoDocumento = new Label();
            cboTipoDeDocumento = new ComboBox();
            cboEstadoCivil = new ComboBox();
            btnCrear = new Button();
            btnUpdate = new Button();
            btnRead = new Button();
            btnDeleteEnd = new Button();
            lblGenero = new Label();
            cboGenero = new ComboBox();
            dvgRefugiados = new DataGridView();
            btnEstadistica = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgRefugiados).BeginInit();
            SuspendLayout();
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(168, 40);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(354, 23);
            txtNombres.TabIndex = 1;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(168, 71);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(354, 23);
            txtApellidos.TabIndex = 2;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(394, 105);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(128, 23);
            txtDocumento.TabIndex = 3;
            txtDocumento.TextChanged += txtDocumento_TextChanged;
            // 
            // Nombres
            // 
            Nombres.AutoSize = true;
            Nombres.Location = new Point(106, 43);
            Nombres.Name = "Nombres";
            Nombres.Size = new Size(56, 15);
            Nombres.TabIndex = 5;
            Nombres.Text = "Nombres";
            Nombres.Click += label1_Click;
            // 
            // Apellidos
            // 
            Apellidos.AutoSize = true;
            Apellidos.Location = new Point(106, 74);
            Apellidos.Name = "Apellidos";
            Apellidos.Size = new Size(56, 15);
            Apellidos.TabIndex = 6;
            Apellidos.Text = "Apellidos";
            // 
            // Documento
            // 
            Documento.AutoSize = true;
            Documento.Location = new Point(334, 108);
            Documento.Name = "Documento";
            Documento.Size = new Size(54, 15);
            Documento.TabIndex = 7;
            Documento.Text = "Número:";
            Documento.Click += Documento_Click;
            // 
            // EstadoCivil
            // 
            EstadoCivil.AutoSize = true;
            EstadoCivil.Location = new Point(106, 140);
            EstadoCivil.Name = "EstadoCivil";
            EstadoCivil.Size = new Size(71, 15);
            EstadoCivil.TabIndex = 8;
            EstadoCivil.Text = "Estado Civil:";
            // 
            // TipoDocumento
            // 
            TipoDocumento.AutoSize = true;
            TipoDocumento.Location = new Point(106, 108);
            TipoDocumento.Name = "TipoDocumento";
            TipoDocumento.Size = new Size(115, 15);
            TipoDocumento.TabIndex = 9;
            TipoDocumento.Text = "Tipo de Documento:";
            TipoDocumento.Click += label1_Click_1;
            // 
            // cboTipoDeDocumento
            // 
            cboTipoDeDocumento.FormattingEnabled = true;
            cboTipoDeDocumento.Location = new Point(227, 105);
            cboTipoDeDocumento.Name = "cboTipoDeDocumento";
            cboTipoDeDocumento.Size = new Size(85, 23);
            cboTipoDeDocumento.TabIndex = 10;
            cboTipoDeDocumento.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cboEstadoCivil
            // 
            cboEstadoCivil.FormattingEnabled = true;
            cboEstadoCivil.Location = new Point(188, 139);
            cboEstadoCivil.Name = "cboEstadoCivil";
            cboEstadoCivil.Size = new Size(121, 23);
            cboEstadoCivil.TabIndex = 11;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = SystemColors.HotTrack;
            btnCrear.ForeColor = SystemColors.HighlightText;
            btnCrear.Location = new Point(102, 183);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 34);
            btnCrear.TabIndex = 12;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnInsertar;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.HotTrack;
            btnUpdate.ForeColor = SystemColors.HighlightText;
            btnUpdate.Location = new Point(188, 183);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(92, 34);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Modificar";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRefresh
            // 
            btnRead.BackColor = SystemColors.WindowFrame;
            btnRead.ForeColor = SystemColors.HighlightText;
            btnRead.Location = new Point(282, 413);
            btnRead.Name = "btnRefresh";
            btnRead.Size = new Size(136, 34);
            btnRead.TabIndex = 15;
            btnRead.Text = "Actualizar";
            btnRead.UseVisualStyleBackColor = false;
            btnRead.Click += btnRefresh_Click;
            // 
            // btnDeleteEnd
            // 
            btnDeleteEnd.BackColor = SystemColors.HotTrack;
            btnDeleteEnd.ForeColor = SystemColors.HighlightText;
            btnDeleteEnd.Location = new Point(296, 183);
            btnDeleteEnd.Name = "btnDeleteEnd";
            btnDeleteEnd.Size = new Size(111, 34);
            btnDeleteEnd.TabIndex = 16;
            btnDeleteEnd.Text = "Eliminar";
            btnDeleteEnd.UseVisualStyleBackColor = false;
            btnDeleteEnd.Click += btnDeleteEnd_Click;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(338, 144);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(45, 15);
            lblGenero.TabIndex = 18;
            lblGenero.Text = "Genero";
            // 
            // cboGenero
            // 
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(396, 144);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(121, 23);
            cboGenero.TabIndex = 19;
            cboGenero.SelectedIndexChanged += cboGenero_SelectedIndexChanged;
            // 
            // dvgRefugiados
            // 
            dvgRefugiados.BackgroundColor = SystemColors.Info;
            dvgRefugiados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgRefugiados.GridColor = SystemColors.ButtonHighlight;
            dvgRefugiados.Location = new Point(67, 223);
            dvgRefugiados.Name = "dvgRefugiados";
            dvgRefugiados.Size = new Size(598, 184);
            dvgRefugiados.TabIndex = 20;
            dvgRefugiados.CellContentClick += dvgRefugiados_CellContentClick;
            // 
            // btnEstadistica
            // 
            btnEstadistica.BackColor = Color.Gold;
            btnEstadistica.Location = new Point(444, 186);
            btnEstadistica.Name = "btnEstadistica";
            btnEstadistica.Size = new Size(95, 29);
            btnEstadistica.TabIndex = 21;
            btnEstadistica.Text = "Ver Estadistica";
            btnEstadistica.UseVisualStyleBackColor = false;
            btnEstadistica.Click += btnEstadistica_Click;
            // 
            // FrmRefugiados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEstadistica);
            Controls.Add(dvgRefugiados);
            Controls.Add(cboGenero);
            Controls.Add(lblGenero);
            Controls.Add(btnDeleteEnd);
            Controls.Add(btnRead);
            Controls.Add(btnUpdate);
            Controls.Add(btnCrear);
            Controls.Add(cboEstadoCivil);
            Controls.Add(cboTipoDeDocumento);
            Controls.Add(TipoDocumento);
            Controls.Add(EstadoCivil);
            Controls.Add(Documento);
            Controls.Add(Apellidos);
            Controls.Add(Nombres);
            Controls.Add(txtDocumento);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombres);
            Name = "FrmRefugiados";
            Text = "Form1";
            Load += FrmRefugiados_Load;
            ((System.ComponentModel.ISupportInitialize)dvgRefugiados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private TextBox txtDocumento;
        private Label Nombres;
        private Label Apellidos;
        private Label Documento;
        private Label EstadoCivil;
        private Label TipoDocumento;
        private ComboBox cboTipoDeDocumento;
        private ComboBox cboEstadoCivil;
        private Button btnCrear;
        private Button btnUpdate;
        private Button btnRead;
        private Button btnDeleteEnd;
        private Label lblGenero;
        private ComboBox cboGenero;
        private DataGridView dvgRefugiados;
        private Button btnEstadistica;
    }
}
