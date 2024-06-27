namespace TP01EF2024.Windows.Agregar_y_Editar
{
    partial class ColoursFormAE
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
            CancelarBtn = new Button();
            GuardarBtn = new Button();
            panel4 = new Panel();
            ColorTxt = new TextBox();
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
            label.Location = new Point(75, 70);
            label.Name = "label";
            label.Size = new Size(218, 21);
            label.TabIndex = 10;
            label.Text = "Ingrese el nombre del color:";
            // 
            // CancelarBtn
            // 
            CancelarBtn.BackColor = Color.FromArgb(64, 64, 64);
            CancelarBtn.FlatAppearance.BorderSize = 0;
            CancelarBtn.FlatStyle = FlatStyle.Flat;
            CancelarBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelarBtn.ForeColor = Color.FromArgb(224, 224, 224);
            CancelarBtn.Location = new Point(203, 257);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(113, 40);
            CancelarBtn.TabIndex = 12;
            CancelarBtn.Text = "CANCELAR";
            CancelarBtn.UseVisualStyleBackColor = false;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // GuardarBtn
            // 
            GuardarBtn.BackColor = Color.FromArgb(64, 64, 64);
            GuardarBtn.FlatAppearance.BorderSize = 0;
            GuardarBtn.FlatStyle = FlatStyle.Flat;
            GuardarBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GuardarBtn.ForeColor = Color.FromArgb(224, 224, 224);
            GuardarBtn.Location = new Point(47, 257);
            GuardarBtn.Name = "GuardarBtn";
            GuardarBtn.Size = new Size(113, 40);
            GuardarBtn.TabIndex = 11;
            GuardarBtn.Text = "GUARDAR";
            GuardarBtn.UseVisualStyleBackColor = false;
            GuardarBtn.Click += GuardarBtn_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 64, 64);
            panel4.Controls.Add(ColorTxt);
            panel4.Location = new Point(47, 145);
            panel4.Name = "panel4";
            panel4.Size = new Size(269, 29);
            panel4.TabIndex = 13;
            // 
            // ColorTxt
            // 
            ColorTxt.BackColor = Color.FromArgb(64, 64, 64);
            ColorTxt.BorderStyle = BorderStyle.None;
            ColorTxt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ColorTxt.ForeColor = Color.FromArgb(224, 224, 224);
            ColorTxt.Location = new Point(5, 6);
            ColorTxt.MaxLength = 50;
            ColorTxt.Name = "ColorTxt";
            ColorTxt.Size = new Size(247, 16);
            ColorTxt.TabIndex = 0;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // ColoursFormAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(377, 370);
            ControlBox = false;
            Controls.Add(panel4);
            Controls.Add(label);
            Controls.Add(CancelarBtn);
            Controls.Add(GuardarBtn);
            MaximumSize = new Size(393, 386);
            MinimumSize = new Size(393, 386);
            Name = "ColoursFormAE";
            StartPosition = FormStartPosition.CenterScreen;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Button CancelarBtn;
        private Button GuardarBtn;
        private Panel panel4;
        private TextBox ColorTxt;
        private ErrorProvider errorProvider;
    }
}