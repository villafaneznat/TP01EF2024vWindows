namespace TP01EF2024.Windows.Agregar_y_Editar
{
    partial class ShoesFormAE
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
            components = new System.ComponentModel.Container();
            label = new Label();
            label1 = new Label();
            NuevaMarcaLbl = new Label();
            NuevoColorLbl = new Label();
            label4 = new Label();
            label5 = new Label();
            NuevoDeporteLbl = new Label();
            label7 = new Label();
            label8 = new Label();
            ComboDeportes = new ComboBox();
            NuevoGeneroLbl = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            CancelarBtn = new Button();
            GuardarBtn = new Button();
            panel4 = new Panel();
            PrecioTxt = new TextBox();
            panel1 = new Panel();
            ModeloTxt = new TextBox();
            panel2 = new Panel();
            DescripcionTxt = new TextBox();
            ComboMarcas = new ComboBox();
            ComboColores = new ComboBox();
            ComboGeneros = new ComboBox();
            errorProvider = new ErrorProvider(components);
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.FromArgb(224, 224, 224);
            label.Location = new Point(20, 31);
            label.Name = "label";
            label.Size = new Size(157, 20);
            label.TabIndex = 4;
            label.Text = "Seleccione una marca";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(20, 83);
            label1.Name = "label1";
            label1.Size = new Size(199, 13);
            label1.TabIndex = 5;
            label1.Text = "¿La marca que desea no se encuentra?";
            // 
            // NuevaMarcaLbl
            // 
            NuevaMarcaLbl.AutoSize = true;
            NuevaMarcaLbl.BackColor = Color.Transparent;
            NuevaMarcaLbl.Cursor = Cursors.Hand;
            NuevaMarcaLbl.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NuevaMarcaLbl.ForeColor = Color.FromArgb(37, 211, 102);
            NuevaMarcaLbl.Location = new Point(233, 83);
            NuevaMarcaLbl.Name = "NuevaMarcaLbl";
            NuevaMarcaLbl.Size = new Size(132, 13);
            NuevaMarcaLbl.TabIndex = 6;
            NuevaMarcaLbl.Text = "Ingrese una nueva marca";
            // 
            // NuevoColorLbl
            // 
            NuevoColorLbl.AutoSize = true;
            NuevoColorLbl.BackColor = Color.Transparent;
            NuevoColorLbl.Cursor = Cursors.Hand;
            NuevoColorLbl.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NuevoColorLbl.ForeColor = Color.FromArgb(37, 211, 102);
            NuevoColorLbl.Location = new Point(642, 83);
            NuevoColorLbl.Name = "NuevoColorLbl";
            NuevoColorLbl.Size = new Size(122, 13);
            NuevoColorLbl.TabIndex = 10;
            NuevoColorLbl.Text = "Ingrese un nuevo color";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(422, 83);
            label4.Name = "label4";
            label4.Size = new Size(192, 13);
            label4.TabIndex = 9;
            label4.Text = "¿El color que desea no se encuentra?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(422, 31);
            label5.Name = "label5";
            label5.Size = new Size(142, 20);
            label5.TabIndex = 8;
            label5.Text = "Seleccione un color";
            // 
            // NuevoDeporteLbl
            // 
            NuevoDeporteLbl.AutoSize = true;
            NuevoDeporteLbl.BackColor = Color.Transparent;
            NuevoDeporteLbl.Cursor = Cursors.Hand;
            NuevoDeporteLbl.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NuevoDeporteLbl.ForeColor = Color.FromArgb(37, 211, 102);
            NuevoDeporteLbl.Location = new Point(228, 187);
            NuevoDeporteLbl.Name = "NuevoDeporteLbl";
            NuevoDeporteLbl.Size = new Size(137, 13);
            NuevoDeporteLbl.TabIndex = 14;
            NuevoDeporteLbl.Text = "Ingrese un nuevo deporte";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(224, 224, 224);
            label7.Location = new Point(20, 187);
            label7.Name = "label7";
            label7.Size = new Size(207, 13);
            label7.TabIndex = 13;
            label7.Text = "¿El deporte que desea no se encuentra?";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(224, 224, 224);
            label8.Location = new Point(20, 135);
            label8.Name = "label8";
            label8.Size = new Size(161, 20);
            label8.TabIndex = 12;
            label8.Text = "Seleccione un deporte";
            // 
            // ComboDeportes
            // 
            ComboDeportes.BackColor = Color.FromArgb(224, 224, 224);
            ComboDeportes.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboDeportes.FlatStyle = FlatStyle.System;
            ComboDeportes.FormattingEnabled = true;
            ComboDeportes.Location = new Point(23, 161);
            ComboDeportes.Name = "ComboDeportes";
            ComboDeportes.Size = new Size(342, 23);
            ComboDeportes.TabIndex = 11;
            ComboDeportes.SelectedIndexChanged += ComboDeportes_SelectedIndexChanged;
            // 
            // NuevoGeneroLbl
            // 
            NuevoGeneroLbl.AutoSize = true;
            NuevoGeneroLbl.BackColor = Color.Transparent;
            NuevoGeneroLbl.Cursor = Cursors.Hand;
            NuevoGeneroLbl.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NuevoGeneroLbl.ForeColor = Color.FromArgb(37, 211, 102);
            NuevoGeneroLbl.Location = new Point(635, 187);
            NuevoGeneroLbl.Name = "NuevoGeneroLbl";
            NuevoGeneroLbl.Size = new Size(132, 13);
            NuevoGeneroLbl.TabIndex = 18;
            NuevoGeneroLbl.Text = "Ingrese un nuevo genero";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(224, 224, 224);
            label10.Location = new Point(422, 187);
            label10.Name = "label10";
            label10.Size = new Size(202, 13);
            label10.TabIndex = 17;
            label10.Text = "¿El genero que desea no se encuentra?";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(224, 224, 224);
            label11.Location = new Point(422, 135);
            label11.Name = "label11";
            label11.Size = new Size(156, 20);
            label11.TabIndex = 16;
            label11.Text = "Seleccione un género";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(224, 224, 224);
            label12.Location = new Point(20, 241);
            label12.Name = "label12";
            label12.Size = new Size(131, 20);
            label12.TabIndex = 19;
            label12.Text = "Ingrese el modelo";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(224, 224, 224);
            label13.Location = new Point(424, 241);
            label13.Name = "label13";
            label13.Size = new Size(218, 20);
            label13.TabIndex = 21;
            label13.Text = "Ingrese una breve descripción:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(224, 224, 224);
            label14.Location = new Point(23, 319);
            label14.Name = "label14";
            label14.Size = new Size(201, 20);
            label14.TabIndex = 23;
            label14.Text = "Ingrese el precio del zapato:";
            // 
            // CancelarBtn
            // 
            CancelarBtn.BackColor = Color.FromArgb(64, 64, 64);
            CancelarBtn.FlatAppearance.BorderSize = 0;
            CancelarBtn.FlatStyle = FlatStyle.Flat;
            CancelarBtn.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelarBtn.ForeColor = Color.FromArgb(224, 224, 224);
            CancelarBtn.Location = new Point(642, 377);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(125, 32);
            CancelarBtn.TabIndex = 26;
            CancelarBtn.Text = "CANCELAR";
            CancelarBtn.UseVisualStyleBackColor = false;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // GuardarBtn
            // 
            GuardarBtn.BackColor = Color.FromArgb(64, 64, 64);
            GuardarBtn.FlatAppearance.BorderSize = 0;
            GuardarBtn.FlatStyle = FlatStyle.Flat;
            GuardarBtn.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GuardarBtn.ForeColor = Color.FromArgb(224, 224, 224);
            GuardarBtn.Location = new Point(499, 377);
            GuardarBtn.Name = "GuardarBtn";
            GuardarBtn.Size = new Size(125, 32);
            GuardarBtn.TabIndex = 25;
            GuardarBtn.Text = "GUARDAR";
            GuardarBtn.UseVisualStyleBackColor = false;
            GuardarBtn.Click += GuardarBtn_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 64, 64);
            panel4.Controls.Add(PrecioTxt);
            panel4.Location = new Point(230, 317);
            panel4.Name = "panel4";
            panel4.Size = new Size(135, 29);
            panel4.TabIndex = 27;
            // 
            // PrecioTxt
            // 
            PrecioTxt.BackColor = Color.FromArgb(64, 64, 64);
            PrecioTxt.BorderStyle = BorderStyle.None;
            PrecioTxt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrecioTxt.ForeColor = Color.FromArgb(224, 224, 224);
            PrecioTxt.Location = new Point(5, 8);
            PrecioTxt.MaxLength = 8;
            PrecioTxt.Name = "PrecioTxt";
            PrecioTxt.Size = new Size(116, 16);
            PrecioTxt.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(ModeloTxt);
            panel1.Location = new Point(23, 267);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 29);
            panel1.TabIndex = 28;
            // 
            // ModeloTxt
            // 
            ModeloTxt.BackColor = Color.FromArgb(64, 64, 64);
            ModeloTxt.BorderStyle = BorderStyle.None;
            ModeloTxt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ModeloTxt.ForeColor = Color.FromArgb(224, 224, 224);
            ModeloTxt.Location = new Point(5, 8);
            ModeloTxt.MaxLength = 150;
            ModeloTxt.Name = "ModeloTxt";
            ModeloTxt.Size = new Size(323, 16);
            ModeloTxt.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(DescripcionTxt);
            panel2.Location = new Point(425, 267);
            panel2.Name = "panel2";
            panel2.Size = new Size(342, 79);
            panel2.TabIndex = 29;
            // 
            // DescripcionTxt
            // 
            DescripcionTxt.BackColor = Color.FromArgb(64, 64, 64);
            DescripcionTxt.BorderStyle = BorderStyle.None;
            DescripcionTxt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DescripcionTxt.ForeColor = Color.FromArgb(224, 224, 224);
            DescripcionTxt.Location = new Point(3, 8);
            DescripcionTxt.MaxLength = 150;
            DescripcionTxt.Multiline = true;
            DescripcionTxt.Name = "DescripcionTxt";
            DescripcionTxt.Size = new Size(336, 61);
            DescripcionTxt.TabIndex = 0;
            // 
            // ComboMarcas
            // 
            ComboMarcas.BackColor = Color.FromArgb(224, 224, 224);
            ComboMarcas.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboMarcas.FlatStyle = FlatStyle.System;
            ComboMarcas.FormattingEnabled = true;
            ComboMarcas.Location = new Point(23, 57);
            ComboMarcas.Name = "ComboMarcas";
            ComboMarcas.Size = new Size(342, 23);
            ComboMarcas.TabIndex = 12;
            ComboMarcas.SelectedIndexChanged += ComboMarcas_SelectedIndexChanged;
            // 
            // ComboColores
            // 
            ComboColores.BackColor = Color.FromArgb(224, 224, 224);
            ComboColores.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboColores.FlatStyle = FlatStyle.System;
            ComboColores.FormattingEnabled = true;
            ComboColores.Location = new Point(425, 57);
            ComboColores.Name = "ComboColores";
            ComboColores.Size = new Size(342, 23);
            ComboColores.TabIndex = 30;
            ComboColores.SelectedIndexChanged += ComboColores_SelectedIndexChanged;
            // 
            // ComboGeneros
            // 
            ComboGeneros.BackColor = Color.FromArgb(224, 224, 224);
            ComboGeneros.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboGeneros.FormattingEnabled = true;
            ComboGeneros.Location = new Point(425, 161);
            ComboGeneros.Name = "ComboGeneros";
            ComboGeneros.Size = new Size(342, 23);
            ComboGeneros.TabIndex = 31;
            ComboGeneros.SelectedIndexChanged += ComboGeneros_SelectedIndexChanged;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // ShoesFormAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(800, 429);
            ControlBox = false;
            Controls.Add(ComboGeneros);
            Controls.Add(ComboColores);
            Controls.Add(ComboMarcas);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(CancelarBtn);
            Controls.Add(GuardarBtn);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(NuevoGeneroLbl);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(NuevoDeporteLbl);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(ComboDeportes);
            Controls.Add(NuevoColorLbl);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(NuevaMarcaLbl);
            Controls.Add(label1);
            Controls.Add(label);
            MaximumSize = new Size(816, 445);
            MinimumSize = new Size(816, 445);
            Name = "ShoesFormAE";
            StartPosition = FormStartPosition.CenterScreen;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label;
        private Label label1;
        private Label NuevaMarcaLbl;
        private Label NuevoColorLbl;
        private Label label4;
        private Label label5;
        private Label NuevoDeporteLbl;
        private Label label7;
        private Label label8;
        private ComboBox ComboDeportes;
        private Label NuevoGeneroLbl;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button CancelarBtn;
        private Button GuardarBtn;
        private Panel panel4;
        private TextBox PrecioTxt;
        private Panel panel1;
        private TextBox ModeloTxt;
        private Panel panel2;
        private TextBox DescripcionTxt;
        private ComboBox ComboMarcas;
        private ComboBox ComboColores;
        private ComboBox ComboGeneros;
        private ErrorProvider errorProvider;
    }
}