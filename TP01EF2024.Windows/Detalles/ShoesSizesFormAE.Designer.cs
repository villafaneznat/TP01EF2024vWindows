namespace TP01EF2024.Windows.Detalles
{
    partial class ShoesSizesFormAE
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
            ComboTalles = new ComboBox();
            label = new Label();
            label1 = new Label();
            panel4 = new Panel();
            StockTxt = new TextBox();
            CancelarBtn = new Button();
            GuardarBtn = new Button();
            errorProvider = new ErrorProvider(components);
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // ComboTalles
            // 
            ComboTalles.BackColor = Color.FromArgb(224, 224, 224);
            ComboTalles.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboTalles.FlatStyle = FlatStyle.System;
            ComboTalles.FormattingEnabled = true;
            ComboTalles.Location = new Point(208, 58);
            ComboTalles.Name = "ComboTalles";
            ComboTalles.Size = new Size(159, 23);
            ComboTalles.TabIndex = 14;
            ComboTalles.SelectedIndexChanged += ComboTalles_SelectedIndexChanged;
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.FromArgb(224, 224, 224);
            label.Location = new Point(63, 58);
            label.Name = "label";
            label.Size = new Size(140, 20);
            label.TabIndex = 13;
            label.Text = "Seleccione un talle:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(63, 126);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 15;
            label1.Text = "Ingrese el stock:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 64, 64);
            panel4.Controls.Add(StockTxt);
            panel4.Location = new Point(188, 122);
            panel4.Name = "panel4";
            panel4.Size = new Size(179, 29);
            panel4.TabIndex = 28;
            // 
            // StockTxt
            // 
            StockTxt.BackColor = Color.FromArgb(64, 64, 64);
            StockTxt.BorderStyle = BorderStyle.None;
            StockTxt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StockTxt.ForeColor = Color.FromArgb(224, 224, 224);
            StockTxt.Location = new Point(9, 7);
            StockTxt.MaxLength = 8;
            StockTxt.Name = "StockTxt";
            StockTxt.Size = new Size(155, 16);
            StockTxt.TabIndex = 0;
            // 
            // CancelarBtn
            // 
            CancelarBtn.BackColor = Color.FromArgb(64, 64, 64);
            CancelarBtn.FlatAppearance.BorderSize = 0;
            CancelarBtn.FlatStyle = FlatStyle.Flat;
            CancelarBtn.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelarBtn.ForeColor = Color.FromArgb(224, 224, 224);
            CancelarBtn.Location = new Point(264, 212);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(103, 32);
            CancelarBtn.TabIndex = 30;
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
            GuardarBtn.Location = new Point(63, 212);
            GuardarBtn.Name = "GuardarBtn";
            GuardarBtn.Size = new Size(103, 32);
            GuardarBtn.TabIndex = 29;
            GuardarBtn.Text = "GUARDAR";
            GuardarBtn.UseVisualStyleBackColor = false;
            GuardarBtn.Click += GuardarBtn_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // ShoesSizesFormAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(433, 305);
            ControlBox = false;
            Controls.Add(CancelarBtn);
            Controls.Add(GuardarBtn);
            Controls.Add(panel4);
            Controls.Add(label1);
            Controls.Add(ComboTalles);
            Controls.Add(label);
            Name = "ShoesSizesFormAE";
            StartPosition = FormStartPosition.CenterScreen;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComboTalles;
        private Label label;
        private Label label1;
        private Panel panel4;
        private TextBox StockTxt;
        private Button CancelarBtn;
        private Button GuardarBtn;
        private ErrorProvider errorProvider;
    }
}