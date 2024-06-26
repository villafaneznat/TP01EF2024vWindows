namespace TP01EF2024.Windows.Agregar_y_Editar
{
    partial class BrandsFormAE
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
            panel4 = new Panel();
            MarcaTxt = new TextBox();
            IngresarBtn = new Button();
            CancelarBtn = new Button();
            errorProvider = new ErrorProvider(components);
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.FromArgb(224, 224, 224);
            label.Location = new Point(68, 90);
            label.Name = "label";
            label.Size = new Size(235, 21);
            label.TabIndex = 1;
            label.Text = "Ingrese el nombre de la marca:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 64, 64);
            panel4.Controls.Add(MarcaTxt);
            panel4.Location = new Point(51, 151);
            panel4.Name = "panel4";
            panel4.Size = new Size(269, 29);
            panel4.TabIndex = 2;
            // 
            // MarcaTxt
            // 
            MarcaTxt.BackColor = Color.FromArgb(64, 64, 64);
            MarcaTxt.BorderStyle = BorderStyle.None;
            MarcaTxt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MarcaTxt.ForeColor = Color.FromArgb(224, 224, 224);
            MarcaTxt.Location = new Point(5, 6);
            MarcaTxt.MaxLength = 50;
            MarcaTxt.Name = "MarcaTxt";
            MarcaTxt.Size = new Size(247, 16);
            MarcaTxt.TabIndex = 0;
            // 
            // IngresarBtn
            // 
            IngresarBtn.BackColor = Color.FromArgb(64, 64, 64);
            IngresarBtn.FlatAppearance.BorderSize = 0;
            IngresarBtn.FlatStyle = FlatStyle.Flat;
            IngresarBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IngresarBtn.ForeColor = Color.FromArgb(224, 224, 224);
            IngresarBtn.Location = new Point(51, 252);
            IngresarBtn.Name = "IngresarBtn";
            IngresarBtn.Size = new Size(113, 40);
            IngresarBtn.TabIndex = 3;
            IngresarBtn.Text = "GUARDAR";
            IngresarBtn.UseVisualStyleBackColor = false;
            IngresarBtn.Click += IngresarBtn_Click;
            // 
            // CancelarBtn
            // 
            CancelarBtn.BackColor = Color.FromArgb(64, 64, 64);
            CancelarBtn.FlatAppearance.BorderSize = 0;
            CancelarBtn.FlatStyle = FlatStyle.Flat;
            CancelarBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelarBtn.ForeColor = Color.FromArgb(224, 224, 224);
            CancelarBtn.Location = new Point(207, 252);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(113, 40);
            CancelarBtn.TabIndex = 4;
            CancelarBtn.Text = "CANCELAR";
            CancelarBtn.UseVisualStyleBackColor = false;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // BrandsFormAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(377, 393);
            ControlBox = false;
            Controls.Add(CancelarBtn);
            Controls.Add(IngresarBtn);
            Controls.Add(panel4);
            Controls.Add(label);
            MaximumSize = new Size(393, 409);
            MinimumSize = new Size(393, 409);
            Name = "BrandsFormAE";
            StartPosition = FormStartPosition.CenterScreen;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Panel panel4;
        private TextBox MarcaTxt;
        private Button IngresarBtn;
        private Button CancelarBtn;
        private ErrorProvider errorProvider;
    }
}