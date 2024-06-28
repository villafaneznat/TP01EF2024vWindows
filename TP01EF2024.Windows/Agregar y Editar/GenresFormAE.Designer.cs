namespace TP01EF2024.Windows.Agregar_y_Editar
{
    partial class GenresFormAE
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
            CancelarBtn = new Button();
            IngresarBtn = new Button();
            panel4 = new Panel();
            GeneroTxt = new TextBox();
            label = new Label();
            errorProvider = new ErrorProvider(components);
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // CancelarBtn
            // 
            CancelarBtn.BackColor = Color.FromArgb(64, 64, 64);
            CancelarBtn.FlatAppearance.BorderSize = 0;
            CancelarBtn.FlatStyle = FlatStyle.Flat;
            CancelarBtn.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelarBtn.ForeColor = Color.FromArgb(224, 224, 224);
            CancelarBtn.Location = new Point(184, 104);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(113, 29);
            CancelarBtn.TabIndex = 8;
            CancelarBtn.Text = "CANCELAR";
            CancelarBtn.UseVisualStyleBackColor = false;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // IngresarBtn
            // 
            IngresarBtn.BackColor = Color.FromArgb(64, 64, 64);
            IngresarBtn.FlatAppearance.BorderSize = 0;
            IngresarBtn.FlatStyle = FlatStyle.Flat;
            IngresarBtn.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IngresarBtn.ForeColor = Color.FromArgb(224, 224, 224);
            IngresarBtn.Location = new Point(28, 104);
            IngresarBtn.Name = "IngresarBtn";
            IngresarBtn.Size = new Size(113, 29);
            IngresarBtn.TabIndex = 7;
            IngresarBtn.Text = "GUARDAR";
            IngresarBtn.UseVisualStyleBackColor = false;
            IngresarBtn.Click += IngresarBtn_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 64, 64);
            panel4.Controls.Add(GeneroTxt);
            panel4.Location = new Point(28, 56);
            panel4.Name = "panel4";
            panel4.Size = new Size(269, 29);
            panel4.TabIndex = 6;
            // 
            // GeneroTxt
            // 
            GeneroTxt.BackColor = Color.FromArgb(64, 64, 64);
            GeneroTxt.BorderStyle = BorderStyle.None;
            GeneroTxt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GeneroTxt.ForeColor = Color.FromArgb(224, 224, 224);
            GeneroTxt.Location = new Point(5, 6);
            GeneroTxt.MaxLength = 10;
            GeneroTxt.Name = "GeneroTxt";
            GeneroTxt.Size = new Size(247, 16);
            GeneroTxt.TabIndex = 0;
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.FromArgb(224, 224, 224);
            label.Location = new Point(50, 21);
            label.Name = "label";
            label.Size = new Size(215, 20);
            label.TabIndex = 5;
            label.Text = "Ingrese el nombre del género:";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // GenresFormAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(323, 156);
            ControlBox = false;
            Controls.Add(CancelarBtn);
            Controls.Add(IngresarBtn);
            Controls.Add(panel4);
            Controls.Add(label);
            MaximumSize = new Size(339, 172);
            MinimumSize = new Size(339, 172);
            Name = "GenresFormAE";
            StartPosition = FormStartPosition.CenterScreen;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelarBtn;
        private Button IngresarBtn;
        private Panel panel4;
        private TextBox GeneroTxt;
        private Label label;
        private ErrorProvider errorProvider;
    }
}