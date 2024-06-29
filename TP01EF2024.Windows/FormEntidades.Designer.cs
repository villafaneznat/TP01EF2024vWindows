namespace TP01EF2024.Windows
{
    partial class FormEntidades
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
            panelMenu = new Panel();
            BackBtn = new FontAwesome.Sharp.IconButton();
            ColoresBtn = new FontAwesome.Sharp.IconButton();
            DeportesBtn = new FontAwesome.Sharp.IconButton();
            GenerosBtn = new FontAwesome.Sharp.IconButton();
            MarcasBtn = new FontAwesome.Sharp.IconButton();
            ZapatosBtn = new FontAwesome.Sharp.IconButton();
            PanelForm = new Panel();
            label1 = new Label();
            label = new Label();
            panelMenu.SuspendLayout();
            PanelForm.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(32, 32, 32);
            panelMenu.Controls.Add(BackBtn);
            panelMenu.Controls.Add(ColoresBtn);
            panelMenu.Controls.Add(DeportesBtn);
            panelMenu.Controls.Add(GenerosBtn);
            panelMenu.Controls.Add(MarcasBtn);
            panelMenu.Controls.Add(ZapatosBtn);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(984, 74);
            panelMenu.TabIndex = 0;
            // 
            // BackBtn
            // 
            BackBtn.Dock = DockStyle.Right;
            BackBtn.FlatAppearance.BorderSize = 0;
            BackBtn.FlatStyle = FlatStyle.Flat;
            BackBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackBtn.ForeColor = Color.FromArgb(224, 224, 224);
            BackBtn.IconChar = FontAwesome.Sharp.IconChar.UpRightFromSquare;
            BackBtn.IconColor = Color.FromArgb(37, 211, 102);
            BackBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BackBtn.IconSize = 38;
            BackBtn.Location = new Point(925, 0);
            BackBtn.Name = "BackBtn";
            BackBtn.Padding = new Padding(10, 5, 10, 0);
            BackBtn.Size = new Size(59, 74);
            BackBtn.TabIndex = 5;
            BackBtn.TextAlign = ContentAlignment.BottomCenter;
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // ColoresBtn
            // 
            ColoresBtn.Dock = DockStyle.Left;
            ColoresBtn.FlatAppearance.BorderSize = 0;
            ColoresBtn.FlatStyle = FlatStyle.Flat;
            ColoresBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ColoresBtn.ForeColor = Color.FromArgb(224, 224, 224);
            ColoresBtn.IconChar = FontAwesome.Sharp.IconChar.Palette;
            ColoresBtn.IconColor = Color.FromArgb(224, 224, 224);
            ColoresBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ColoresBtn.IconSize = 38;
            ColoresBtn.ImageAlign = ContentAlignment.TopCenter;
            ColoresBtn.Location = new Point(384, 0);
            ColoresBtn.Name = "ColoresBtn";
            ColoresBtn.Padding = new Padding(10, 5, 10, 0);
            ColoresBtn.Size = new Size(96, 74);
            ColoresBtn.TabIndex = 4;
            ColoresBtn.Text = "Colores";
            ColoresBtn.TextAlign = ContentAlignment.BottomCenter;
            ColoresBtn.UseVisualStyleBackColor = true;
            ColoresBtn.Click += ColoresBtn_Click;
            // 
            // DeportesBtn
            // 
            DeportesBtn.Dock = DockStyle.Left;
            DeportesBtn.FlatAppearance.BorderSize = 0;
            DeportesBtn.FlatStyle = FlatStyle.Flat;
            DeportesBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeportesBtn.ForeColor = Color.FromArgb(224, 224, 224);
            DeportesBtn.IconChar = FontAwesome.Sharp.IconChar.FutbolBall;
            DeportesBtn.IconColor = Color.FromArgb(224, 224, 224);
            DeportesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            DeportesBtn.IconSize = 38;
            DeportesBtn.ImageAlign = ContentAlignment.TopCenter;
            DeportesBtn.Location = new Point(288, 0);
            DeportesBtn.Name = "DeportesBtn";
            DeportesBtn.Padding = new Padding(10, 5, 10, 0);
            DeportesBtn.Size = new Size(96, 74);
            DeportesBtn.TabIndex = 3;
            DeportesBtn.Text = "Deportes";
            DeportesBtn.TextAlign = ContentAlignment.BottomCenter;
            DeportesBtn.UseVisualStyleBackColor = true;
            DeportesBtn.Click += DeportesBtn_Click;
            // 
            // GenerosBtn
            // 
            GenerosBtn.Dock = DockStyle.Left;
            GenerosBtn.FlatAppearance.BorderSize = 0;
            GenerosBtn.FlatStyle = FlatStyle.Flat;
            GenerosBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenerosBtn.ForeColor = Color.FromArgb(224, 224, 224);
            GenerosBtn.IconChar = FontAwesome.Sharp.IconChar.Transgender;
            GenerosBtn.IconColor = Color.FromArgb(224, 224, 224);
            GenerosBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            GenerosBtn.IconSize = 38;
            GenerosBtn.ImageAlign = ContentAlignment.TopCenter;
            GenerosBtn.Location = new Point(192, 0);
            GenerosBtn.Name = "GenerosBtn";
            GenerosBtn.Padding = new Padding(10, 5, 10, 0);
            GenerosBtn.Size = new Size(96, 74);
            GenerosBtn.TabIndex = 2;
            GenerosBtn.Text = "Generos";
            GenerosBtn.TextAlign = ContentAlignment.BottomCenter;
            GenerosBtn.UseVisualStyleBackColor = true;
            GenerosBtn.Click += GenerosBtn_Click;
            // 
            // MarcasBtn
            // 
            MarcasBtn.Dock = DockStyle.Left;
            MarcasBtn.FlatAppearance.BorderSize = 0;
            MarcasBtn.FlatStyle = FlatStyle.Flat;
            MarcasBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MarcasBtn.ForeColor = Color.FromArgb(224, 224, 224);
            MarcasBtn.IconChar = FontAwesome.Sharp.IconChar.Star;
            MarcasBtn.IconColor = Color.FromArgb(224, 224, 224);
            MarcasBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            MarcasBtn.IconSize = 38;
            MarcasBtn.ImageAlign = ContentAlignment.TopCenter;
            MarcasBtn.Location = new Point(96, 0);
            MarcasBtn.Name = "MarcasBtn";
            MarcasBtn.Padding = new Padding(10, 5, 10, 0);
            MarcasBtn.Size = new Size(96, 74);
            MarcasBtn.TabIndex = 1;
            MarcasBtn.Text = "Marcas";
            MarcasBtn.TextAlign = ContentAlignment.BottomCenter;
            MarcasBtn.UseVisualStyleBackColor = true;
            MarcasBtn.Click += MarcasBtn_Click;
            // 
            // ZapatosBtn
            // 
            ZapatosBtn.Dock = DockStyle.Left;
            ZapatosBtn.FlatAppearance.BorderSize = 0;
            ZapatosBtn.FlatStyle = FlatStyle.Flat;
            ZapatosBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ZapatosBtn.ForeColor = Color.FromArgb(224, 224, 224);
            ZapatosBtn.IconChar = FontAwesome.Sharp.IconChar.ShoePrints;
            ZapatosBtn.IconColor = Color.FromArgb(224, 224, 224);
            ZapatosBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ZapatosBtn.IconSize = 40;
            ZapatosBtn.ImageAlign = ContentAlignment.TopCenter;
            ZapatosBtn.Location = new Point(0, 0);
            ZapatosBtn.Name = "ZapatosBtn";
            ZapatosBtn.Padding = new Padding(10, 5, 10, 0);
            ZapatosBtn.Size = new Size(96, 74);
            ZapatosBtn.TabIndex = 0;
            ZapatosBtn.Text = "Zapatos";
            ZapatosBtn.TextAlign = ContentAlignment.BottomCenter;
            ZapatosBtn.UseVisualStyleBackColor = true;
            ZapatosBtn.Click += ZapatosBtn_Click;
            // 
            // PanelForm
            // 
            PanelForm.Controls.Add(label1);
            PanelForm.Controls.Add(label);
            PanelForm.Dock = DockStyle.Fill;
            PanelForm.Location = new Point(0, 74);
            PanelForm.MaximumSize = new Size(1000, 550);
            PanelForm.MinimumSize = new Size(928, 550);
            PanelForm.Name = "PanelForm";
            PanelForm.Size = new Size(984, 550);
            PanelForm.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(335, 295);
            label1.Name = "label1";
            label1.Size = new Size(328, 28);
            label1.TabIndex = 2;
            label1.Text = "Trabajo Práctico de Nataly Villafañez";
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Segoe UI Semibold", 50F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.FromArgb(37, 211, 102);
            label.Location = new Point(300, 206);
            label.Name = "label";
            label.Size = new Size(397, 89);
            label.TabIndex = 1;
            label.Text = "TP01EF2024";
            // 
            // FormEntidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 44);
            ClientSize = new Size(984, 624);
            ControlBox = false;
            Controls.Add(PanelForm);
            Controls.Add(panelMenu);
            MaximumSize = new Size(1000, 640);
            MinimumSize = new Size(1000, 640);
            Name = "FormEntidades";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormEntidades_Load;
            panelMenu.ResumeLayout(false);
            PanelForm.ResumeLayout(false);
            PanelForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton ZapatosBtn;
        private FontAwesome.Sharp.IconButton DeportesBtn;
        private FontAwesome.Sharp.IconButton GenerosBtn;
        private FontAwesome.Sharp.IconButton MarcasBtn;
        private FontAwesome.Sharp.IconButton ColoresBtn;
        private FontAwesome.Sharp.IconButton BackBtn;
        private Panel PanelForm;
        private Label label;
        private Label label1;
    }
}