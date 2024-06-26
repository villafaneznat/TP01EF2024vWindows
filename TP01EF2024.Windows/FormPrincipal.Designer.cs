namespace TP01EF2024.Windows
{
    partial class FormPrincipal
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
            label = new Label();
            IngresarBtn = new Button();
            ExitBtn = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.FromArgb(224, 224, 224);
            label.Location = new Point(46, 85);
            label.Name = "label";
            label.Size = new Size(236, 54);
            label.TabIndex = 0;
            label.Text = "TP01EF2024";
            // 
            // IngresarBtn
            // 
            IngresarBtn.BackColor = Color.FromArgb(64, 64, 64);
            IngresarBtn.FlatAppearance.BorderSize = 0;
            IngresarBtn.FlatStyle = FlatStyle.Flat;
            IngresarBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IngresarBtn.ForeColor = Color.FromArgb(224, 224, 224);
            IngresarBtn.Location = new Point(83, 269);
            IngresarBtn.Name = "IngresarBtn";
            IngresarBtn.Size = new Size(151, 43);
            IngresarBtn.TabIndex = 1;
            IngresarBtn.Text = "INGRESAR";
            IngresarBtn.UseVisualStyleBackColor = false;
            IngresarBtn.Click += IngresarBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.FromArgb(32, 32, 32);
            ExitBtn.FlatAppearance.BorderSize = 0;
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.ForeColor = Color.Transparent;
            ExitBtn.IconChar = FontAwesome.Sharp.IconChar.RectangleTimes;
            ExitBtn.IconColor = Color.FromArgb(64, 64, 64);
            ExitBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            ExitBtn.IconSize = 30;
            ExitBtn.Location = new Point(268, 12);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(56, 27);
            ExitBtn.TabIndex = 3;
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(321, 396);
            ControlBox = false;
            Controls.Add(ExitBtn);
            Controls.Add(IngresarBtn);
            Controls.Add(label);
            MaximumSize = new Size(337, 412);
            MinimumSize = new Size(337, 412);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Button IngresarBtn;
        private FontAwesome.Sharp.IconButton ExitBtn;
    }
}