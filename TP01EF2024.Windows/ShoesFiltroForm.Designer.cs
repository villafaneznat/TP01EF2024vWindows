namespace TP01EF2024.Windows
{
    partial class ShoesFiltroForm
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
            panel5 = new Panel();
            PrecioMinimoText = new TextBox();
            ComboTalles = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            ComboGeneros = new ComboBox();
            label6 = new Label();
            ComboDeportes = new ComboBox();
            label8 = new Label();
            panel8 = new Panel();
            PrecioMaximoText = new TextBox();
            label5 = new Label();
            ComboColores = new ComboBox();
            panel7 = new Panel();
            label4 = new Label();
            label7 = new Label();
            ComboMarcas = new ComboBox();
            label = new Label();
            AplicarFiltroBtn = new FontAwesome.Sharp.IconButton();
            CancelBtn = new FontAwesome.Sharp.IconButton();
            errorProvider = new ErrorProvider(components);
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(37, 37, 37);
            panel5.Controls.Add(PrecioMinimoText);
            panel5.Controls.Add(ComboTalles);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(ComboGeneros);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(ComboDeportes);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(ComboColores);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(ComboMarcas);
            panel5.Controls.Add(label);
            panel5.Location = new Point(50, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(176, 411);
            panel5.TabIndex = 8;
            // 
            // PrecioMinimoText
            // 
            PrecioMinimoText.BackColor = Color.FromArgb(64, 64, 64);
            PrecioMinimoText.BorderStyle = BorderStyle.None;
            PrecioMinimoText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrecioMinimoText.ForeColor = Color.FromArgb(224, 224, 224);
            PrecioMinimoText.Location = new Point(76, 341);
            PrecioMinimoText.Name = "PrecioMinimoText";
            PrecioMinimoText.Size = new Size(76, 16);
            PrecioMinimoText.TabIndex = 2;
            // 
            // ComboTalles
            // 
            ComboTalles.BackColor = Color.FromArgb(224, 224, 224);
            ComboTalles.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboTalles.FlatStyle = FlatStyle.System;
            ComboTalles.FormattingEnabled = true;
            ComboTalles.Location = new Point(20, 268);
            ComboTalles.Name = "ComboTalles";
            ComboTalles.Size = new Size(135, 23);
            ComboTalles.TabIndex = 51;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(224, 224, 224);
            label10.Location = new Point(18, 250);
            label10.Name = "label10";
            label10.Size = new Size(34, 15);
            label10.TabIndex = 50;
            label10.Text = "Talle:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(224, 224, 224);
            label9.Location = new Point(18, 381);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 49;
            label9.Text = "Maximo";
            // 
            // ComboGeneros
            // 
            ComboGeneros.BackColor = Color.FromArgb(224, 224, 224);
            ComboGeneros.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboGeneros.FlatStyle = FlatStyle.System;
            ComboGeneros.FormattingEnabled = true;
            ComboGeneros.Location = new Point(18, 207);
            ComboGeneros.Name = "ComboGeneros";
            ComboGeneros.Size = new Size(135, 23);
            ComboGeneros.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(16, 189);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 19;
            label6.Text = "Género:";
            // 
            // ComboDeportes
            // 
            ComboDeportes.BackColor = Color.FromArgb(224, 224, 224);
            ComboDeportes.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboDeportes.FlatStyle = FlatStyle.System;
            ComboDeportes.FormattingEnabled = true;
            ComboDeportes.Location = new Point(18, 149);
            ComboDeportes.Name = "ComboDeportes";
            ComboDeportes.Size = new Size(135, 23);
            ComboDeportes.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(224, 224, 224);
            label8.Location = new Point(18, 342);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 47;
            label8.Text = "Minimo";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(64, 64, 64);
            panel8.Controls.Add(PrecioMaximoText);
            panel8.Location = new Point(73, 378);
            panel8.Name = "panel8";
            panel8.Size = new Size(82, 23);
            panel8.TabIndex = 48;
            // 
            // PrecioMaximoText
            // 
            PrecioMaximoText.BackColor = Color.FromArgb(64, 64, 64);
            PrecioMaximoText.BorderStyle = BorderStyle.None;
            PrecioMaximoText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrecioMaximoText.ForeColor = Color.FromArgb(224, 224, 224);
            PrecioMaximoText.Location = new Point(2, 3);
            PrecioMaximoText.Name = "PrecioMaximoText";
            PrecioMaximoText.Size = new Size(76, 16);
            PrecioMaximoText.TabIndex = 52;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(16, 131);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 17;
            label5.Text = "Deporte:";
            // 
            // ComboColores
            // 
            ComboColores.BackColor = Color.FromArgb(224, 224, 224);
            ComboColores.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboColores.FlatStyle = FlatStyle.System;
            ComboColores.FormattingEnabled = true;
            ComboColores.Location = new Point(18, 93);
            ComboColores.Name = "ComboColores";
            ComboColores.Size = new Size(135, 23);
            ComboColores.TabIndex = 16;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(64, 64, 64);
            panel7.Location = new Point(73, 338);
            panel7.Name = "panel7";
            panel7.Size = new Size(82, 23);
            panel7.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(16, 75);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 15;
            label4.Text = "Color:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(224, 224, 224);
            label7.Location = new Point(18, 310);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 46;
            label7.Text = "Precio:";
            // 
            // ComboMarcas
            // 
            ComboMarcas.BackColor = Color.FromArgb(224, 224, 224);
            ComboMarcas.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboMarcas.FlatStyle = FlatStyle.System;
            ComboMarcas.FormattingEnabled = true;
            ComboMarcas.Location = new Point(18, 36);
            ComboMarcas.Name = "ComboMarcas";
            ComboMarcas.Size = new Size(135, 23);
            ComboMarcas.TabIndex = 14;
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.FromArgb(224, 224, 224);
            label.Location = new Point(16, 18);
            label.Name = "label";
            label.Size = new Size(43, 15);
            label.TabIndex = 13;
            label.Text = "Marca:";
            // 
            // AplicarFiltroBtn
            // 
            AplicarFiltroBtn.BackColor = Color.FromArgb(32, 32, 32);
            AplicarFiltroBtn.FlatAppearance.BorderSize = 0;
            AplicarFiltroBtn.FlatStyle = FlatStyle.Flat;
            AplicarFiltroBtn.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AplicarFiltroBtn.ForeColor = Color.FromArgb(224, 224, 224);
            AplicarFiltroBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            AplicarFiltroBtn.IconColor = Color.Black;
            AplicarFiltroBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AplicarFiltroBtn.Location = new Point(25, 441);
            AplicarFiltroBtn.Name = "AplicarFiltroBtn";
            AplicarFiltroBtn.Size = new Size(111, 25);
            AplicarFiltroBtn.TabIndex = 6;
            AplicarFiltroBtn.Text = "Aplicar";
            AplicarFiltroBtn.UseVisualStyleBackColor = false;
            AplicarFiltroBtn.Click += AplicarFiltroBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.FromArgb(32, 32, 32);
            CancelBtn.FlatAppearance.BorderSize = 0;
            CancelBtn.FlatStyle = FlatStyle.Flat;
            CancelBtn.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelBtn.ForeColor = Color.FromArgb(224, 224, 224);
            CancelBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            CancelBtn.IconColor = Color.Black;
            CancelBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CancelBtn.Location = new Point(152, 441);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(111, 25);
            CancelBtn.TabIndex = 52;
            CancelBtn.Text = "Cancelar";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // ShoesFiltroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 37, 37);
            ClientSize = new Size(286, 506);
            ControlBox = false;
            Controls.Add(CancelBtn);
            Controls.Add(panel5);
            Controls.Add(AplicarFiltroBtn);
            Name = "ShoesFiltroForm";
            StartPosition = FormStartPosition.CenterScreen;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private TextBox PrecioMinimoText;
        private ComboBox ComboTalles;
        private Label label10;
        private Label label9;
        private ComboBox ComboGeneros;
        private Label label6;
        private ComboBox ComboDeportes;
        private Label label8;
        private Panel panel8;
        private TextBox PrecioMaximoText;
        private Label label5;
        private ComboBox ComboColores;
        private Panel panel7;
        private Label label4;
        private Label label7;
        private ComboBox ComboMarcas;
        private Label label;
        private FontAwesome.Sharp.IconButton AplicarFiltroBtn;
        private FontAwesome.Sharp.IconButton CancelBtn;
        private ErrorProvider errorProvider;
    }
}