﻿namespace TP01EF2024.Windows.Entidades
{
    partial class ColoursForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            ActualizarBtn = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            BuscarColorTxt = new TextBox();
            panel2 = new Panel();
            PagPrimeraBtn = new FontAwesome.Sharp.IconButton();
            PagUltimaBtn = new FontAwesome.Sharp.IconButton();
            PagSiguienteBtn = new FontAwesome.Sharp.IconButton();
            PagAnteriorBtn = new FontAwesome.Sharp.IconButton();
            CantidadColoresLbl = new Label();
            label2 = new Label();
            CantidadPaginasLbl = new Label();
            label3 = new Label();
            PaginaActualLbl = new Label();
            label1 = new Label();
            panel3 = new Panel();
            panel5 = new Panel();
            OrderABtn = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            OrderZBtn = new FontAwesome.Sharp.IconButton();
            BorrarBtn = new FontAwesome.Sharp.IconButton();
            EditarBtn = new FontAwesome.Sharp.IconButton();
            NuevoColorBtn = new FontAwesome.Sharp.IconButton();
            DgvColours = new DataGridView();
            ColourNameCol = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvColours).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ActualizarBtn);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 66);
            panel1.TabIndex = 2;
            // 
            // ActualizarBtn
            // 
            ActualizarBtn.BackColor = Color.FromArgb(32, 32, 32);
            ActualizarBtn.FlatAppearance.BorderSize = 0;
            ActualizarBtn.FlatStyle = FlatStyle.Flat;
            ActualizarBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ActualizarBtn.ForeColor = Color.FromArgb(224, 224, 224);
            ActualizarBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            ActualizarBtn.IconColor = Color.Black;
            ActualizarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ActualizarBtn.Location = new Point(313, 17);
            ActualizarBtn.Name = "ActualizarBtn";
            ActualizarBtn.Size = new Size(119, 29);
            ActualizarBtn.TabIndex = 6;
            ActualizarBtn.Text = "Actualizar";
            ActualizarBtn.UseVisualStyleBackColor = false;
            ActualizarBtn.Click += ActualizarBtn_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 64, 64);
            panel4.Controls.Add(iconPictureBox1);
            panel4.Controls.Add(BuscarColorTxt);
            panel4.Location = new Point(447, 17);
            panel4.Name = "panel4";
            panel4.Size = new Size(364, 29);
            panel4.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(64, 64, 64);
            iconPictureBox1.ForeColor = Color.FromArgb(224, 224, 224);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconPictureBox1.IconColor = Color.FromArgb(224, 224, 224);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 25;
            iconPictureBox1.Location = new Point(7, 2);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(25, 25);
            iconPictureBox1.TabIndex = 1;
            iconPictureBox1.TabStop = false;
            // 
            // BuscarColorTxt
            // 
            BuscarColorTxt.BackColor = Color.FromArgb(64, 64, 64);
            BuscarColorTxt.BorderStyle = BorderStyle.None;
            BuscarColorTxt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BuscarColorTxt.ForeColor = Color.FromArgb(224, 224, 224);
            BuscarColorTxt.Location = new Point(37, 6);
            BuscarColorTxt.Name = "BuscarColorTxt";
            BuscarColorTxt.PlaceholderText = "Bucar Color...";
            BuscarColorTxt.Size = new Size(285, 16);
            BuscarColorTxt.TabIndex = 0;
            BuscarColorTxt.TextChanged += BuscarColorTxt_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(PagPrimeraBtn);
            panel2.Controls.Add(PagUltimaBtn);
            panel2.Controls.Add(PagSiguienteBtn);
            panel2.Controls.Add(PagAnteriorBtn);
            panel2.Controls.Add(CantidadColoresLbl);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(CantidadPaginasLbl);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(PaginaActualLbl);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 446);
            panel2.MaximumSize = new Size(812, 88);
            panel2.MinimumSize = new Size(812, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(812, 88);
            panel2.TabIndex = 3;
            // 
            // PagPrimeraBtn
            // 
            PagPrimeraBtn.BackColor = Color.FromArgb(32, 32, 32);
            PagPrimeraBtn.FlatAppearance.BorderSize = 0;
            PagPrimeraBtn.FlatStyle = FlatStyle.Flat;
            PagPrimeraBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PagPrimeraBtn.ForeColor = Color.FromArgb(224, 224, 224);
            PagPrimeraBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            PagPrimeraBtn.IconColor = Color.Black;
            PagPrimeraBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PagPrimeraBtn.Location = new Point(307, 20);
            PagPrimeraBtn.Name = "PagPrimeraBtn";
            PagPrimeraBtn.Size = new Size(43, 30);
            PagPrimeraBtn.TabIndex = 9;
            PagPrimeraBtn.Text = "<<";
            PagPrimeraBtn.TextImageRelation = TextImageRelation.TextAboveImage;
            PagPrimeraBtn.UseVisualStyleBackColor = false;
            PagPrimeraBtn.Click += PagPrimeraBtn_Click;
            // 
            // PagUltimaBtn
            // 
            PagUltimaBtn.BackColor = Color.FromArgb(32, 32, 32);
            PagUltimaBtn.FlatAppearance.BorderSize = 0;
            PagUltimaBtn.FlatStyle = FlatStyle.Flat;
            PagUltimaBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PagUltimaBtn.ForeColor = Color.FromArgb(224, 224, 224);
            PagUltimaBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            PagUltimaBtn.IconColor = Color.Black;
            PagUltimaBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PagUltimaBtn.Location = new Point(466, 20);
            PagUltimaBtn.Name = "PagUltimaBtn";
            PagUltimaBtn.Size = new Size(43, 30);
            PagUltimaBtn.TabIndex = 8;
            PagUltimaBtn.Text = ">>";
            PagUltimaBtn.TextImageRelation = TextImageRelation.TextAboveImage;
            PagUltimaBtn.UseVisualStyleBackColor = false;
            PagUltimaBtn.Click += PagUltimaBtn_Click;
            // 
            // PagSiguienteBtn
            // 
            PagSiguienteBtn.BackColor = Color.FromArgb(32, 32, 32);
            PagSiguienteBtn.FlatAppearance.BorderSize = 0;
            PagSiguienteBtn.FlatStyle = FlatStyle.Flat;
            PagSiguienteBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PagSiguienteBtn.ForeColor = Color.FromArgb(224, 224, 224);
            PagSiguienteBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            PagSiguienteBtn.IconColor = Color.Black;
            PagSiguienteBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PagSiguienteBtn.Location = new Point(427, 20);
            PagSiguienteBtn.Name = "PagSiguienteBtn";
            PagSiguienteBtn.Size = new Size(30, 30);
            PagSiguienteBtn.TabIndex = 7;
            PagSiguienteBtn.Text = ">";
            PagSiguienteBtn.TextImageRelation = TextImageRelation.TextAboveImage;
            PagSiguienteBtn.UseVisualStyleBackColor = false;
            PagSiguienteBtn.Click += PagSiguienteBtn_Click;
            // 
            // PagAnteriorBtn
            // 
            PagAnteriorBtn.BackColor = Color.FromArgb(32, 32, 32);
            PagAnteriorBtn.FlatAppearance.BorderSize = 0;
            PagAnteriorBtn.FlatStyle = FlatStyle.Flat;
            PagAnteriorBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PagAnteriorBtn.ForeColor = Color.FromArgb(224, 224, 224);
            PagAnteriorBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            PagAnteriorBtn.IconColor = Color.Black;
            PagAnteriorBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PagAnteriorBtn.Location = new Point(360, 20);
            PagAnteriorBtn.Name = "PagAnteriorBtn";
            PagAnteriorBtn.Size = new Size(30, 30);
            PagAnteriorBtn.TabIndex = 6;
            PagAnteriorBtn.Text = "<";
            PagAnteriorBtn.TextImageRelation = TextImageRelation.TextAboveImage;
            PagAnteriorBtn.UseVisualStyleBackColor = false;
            PagAnteriorBtn.Click += PagAnteriorBtn_Click;
            // 
            // CantidadColoresLbl
            // 
            CantidadColoresLbl.AutoSize = true;
            CantidadColoresLbl.ForeColor = Color.FromArgb(224, 224, 224);
            CantidadColoresLbl.Location = new Point(755, 26);
            CantidadColoresLbl.Name = "CantidadColoresLbl";
            CantidadColoresLbl.Size = new Size(13, 15);
            CantidadColoresLbl.TabIndex = 5;
            CantidadColoresLbl.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(640, 25);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 4;
            label2.Text = "Cantidad de colores:";
            // 
            // CantidadPaginasLbl
            // 
            CantidadPaginasLbl.AutoSize = true;
            CantidadPaginasLbl.ForeColor = Color.FromArgb(224, 224, 224);
            CantidadPaginasLbl.Location = new Point(123, 26);
            CantidadPaginasLbl.Name = "CantidadPaginasLbl";
            CantidadPaginasLbl.Size = new Size(19, 15);
            CantidadPaginasLbl.TabIndex = 3;
            CantidadPaginasLbl.Text = "10";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(97, 26);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 2;
            label3.Text = "de";
            // 
            // PaginaActualLbl
            // 
            PaginaActualLbl.AutoSize = true;
            PaginaActualLbl.ForeColor = Color.FromArgb(224, 224, 224);
            PaginaActualLbl.Location = new Point(78, 26);
            PaginaActualLbl.Name = "PaginaActualLbl";
            PaginaActualLbl.Size = new Size(13, 15);
            PaginaActualLbl.TabIndex = 1;
            PaginaActualLbl.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(32, 25);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Página";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(37, 37, 37);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(BorrarBtn);
            panel3.Controls.Add(EditarBtn);
            panel3.Controls.Add(NuevoColorBtn);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(812, 66);
            panel3.MaximumSize = new Size(172, 500);
            panel3.MinimumSize = new Size(172, 500);
            panel3.Name = "panel3";
            panel3.Size = new Size(172, 500);
            panel3.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.Controls.Add(OrderABtn);
            panel5.Controls.Add(iconButton1);
            panel5.Controls.Add(OrderZBtn);
            panel5.Location = new Point(19, 240);
            panel5.Name = "panel5";
            panel5.Size = new Size(127, 113);
            panel5.TabIndex = 5;
            // 
            // OrderABtn
            // 
            OrderABtn.BackColor = Color.FromArgb(36, 36, 36);
            OrderABtn.Dock = DockStyle.Bottom;
            OrderABtn.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            OrderABtn.FlatStyle = FlatStyle.Flat;
            OrderABtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrderABtn.ForeColor = Color.FromArgb(224, 224, 224);
            OrderABtn.IconChar = FontAwesome.Sharp.IconChar.None;
            OrderABtn.IconColor = Color.Black;
            OrderABtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            OrderABtn.Location = new Point(0, 49);
            OrderABtn.Name = "OrderABtn";
            OrderABtn.Size = new Size(127, 32);
            OrderABtn.TabIndex = 5;
            OrderABtn.Text = "A - Z";
            OrderABtn.UseVisualStyleBackColor = false;
            OrderABtn.Click += OrderABtn_Click;
            // 
            // iconButton1
            // 
            iconButton1.AccessibleRole = AccessibleRole.None;
            iconButton1.BackColor = Color.FromArgb(32, 32, 32);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(32, 32, 32);
            iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 32, 32);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = Color.FromArgb(224, 224, 224);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(0, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(127, 43);
            iconButton1.TabIndex = 3;
            iconButton1.Text = "Ordenar";
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // OrderZBtn
            // 
            OrderZBtn.BackColor = Color.FromArgb(36, 36, 36);
            OrderZBtn.Dock = DockStyle.Bottom;
            OrderZBtn.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            OrderZBtn.FlatStyle = FlatStyle.Flat;
            OrderZBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrderZBtn.ForeColor = Color.FromArgb(224, 224, 224);
            OrderZBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            OrderZBtn.IconColor = Color.Black;
            OrderZBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            OrderZBtn.Location = new Point(0, 81);
            OrderZBtn.Name = "OrderZBtn";
            OrderZBtn.Size = new Size(127, 32);
            OrderZBtn.TabIndex = 4;
            OrderZBtn.Text = "Z - A";
            OrderZBtn.UseVisualStyleBackColor = false;
            OrderZBtn.Click += OrderZBtn_Click;
            // 
            // BorrarBtn
            // 
            BorrarBtn.BackColor = Color.FromArgb(32, 32, 32);
            BorrarBtn.FlatAppearance.BorderSize = 0;
            BorrarBtn.FlatStyle = FlatStyle.Flat;
            BorrarBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BorrarBtn.ForeColor = Color.FromArgb(224, 224, 224);
            BorrarBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            BorrarBtn.IconColor = Color.Black;
            BorrarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BorrarBtn.Location = new Point(19, 176);
            BorrarBtn.Name = "BorrarBtn";
            BorrarBtn.Size = new Size(127, 43);
            BorrarBtn.TabIndex = 2;
            BorrarBtn.Text = "Borrar";
            BorrarBtn.UseVisualStyleBackColor = false;
            BorrarBtn.Click += BorrarBtn_Click;
            // 
            // EditarBtn
            // 
            EditarBtn.BackColor = Color.FromArgb(32, 32, 32);
            EditarBtn.FlatAppearance.BorderSize = 0;
            EditarBtn.FlatStyle = FlatStyle.Flat;
            EditarBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditarBtn.ForeColor = Color.FromArgb(224, 224, 224);
            EditarBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            EditarBtn.IconColor = Color.Black;
            EditarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            EditarBtn.Location = new Point(19, 110);
            EditarBtn.Name = "EditarBtn";
            EditarBtn.Size = new Size(127, 43);
            EditarBtn.TabIndex = 1;
            EditarBtn.Text = "Editar";
            EditarBtn.UseVisualStyleBackColor = false;
            EditarBtn.Click += EditarBtn_Click;
            // 
            // NuevoColorBtn
            // 
            NuevoColorBtn.BackColor = Color.FromArgb(32, 32, 32);
            NuevoColorBtn.FlatAppearance.BorderSize = 0;
            NuevoColorBtn.FlatStyle = FlatStyle.Flat;
            NuevoColorBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NuevoColorBtn.ForeColor = Color.FromArgb(224, 224, 224);
            NuevoColorBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            NuevoColorBtn.IconColor = Color.Black;
            NuevoColorBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            NuevoColorBtn.Location = new Point(19, 49);
            NuevoColorBtn.Name = "NuevoColorBtn";
            NuevoColorBtn.Size = new Size(127, 43);
            NuevoColorBtn.TabIndex = 0;
            NuevoColorBtn.Text = "Nuevo Color";
            NuevoColorBtn.UseVisualStyleBackColor = false;
            NuevoColorBtn.Click += NuevoColorBtn_Click;
            // 
            // DgvColours
            // 
            DgvColours.AllowUserToAddRows = false;
            DgvColours.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(44, 44, 44);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(44, 44, 44);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(37, 212, 102);
            DgvColours.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvColours.BackgroundColor = Color.FromArgb(44, 44, 44);
            DgvColours.BorderStyle = BorderStyle.None;
            DgvColours.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvColours.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DgvColours.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DgvColours.ColumnHeadersHeight = 50;
            DgvColours.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DgvColours.Columns.AddRange(new DataGridViewColumn[] { ColourNameCol });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(44, 44, 44);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DgvColours.DefaultCellStyle = dataGridViewCellStyle3;
            DgvColours.Dock = DockStyle.Fill;
            DgvColours.EnableHeadersVisualStyles = false;
            DgvColours.Location = new Point(0, 66);
            DgvColours.Margin = new Padding(10);
            DgvColours.MultiSelect = false;
            DgvColours.Name = "DgvColours";
            DgvColours.ReadOnly = true;
            DgvColours.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.Padding = new Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DgvColours.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DgvColours.RowHeadersWidth = 30;
            DgvColours.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(44, 44, 44);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle5.Padding = new Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(44, 44, 44);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(37, 211, 102);
            DgvColours.RowsDefaultCellStyle = dataGridViewCellStyle5;
            DgvColours.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvColours.Size = new Size(812, 380);
            DgvColours.TabIndex = 5;
            // 
            // ColourNameCol
            // 
            ColourNameCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColourNameCol.HeaderText = "Color";
            ColourNameCol.Name = "ColourNameCol";
            ColourNameCol.ReadOnly = true;
            // 
            // ColoursForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 44);
            ClientSize = new Size(984, 534);
            ControlBox = false;
            Controls.Add(DgvColours);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(1000, 550);
            MinimumSize = new Size(1000, 550);
            Name = "ColoursForm";
            Load += ColoursForm_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvColours).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton ActualizarBtn;
        private Panel panel4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox BuscarColorTxt;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton PagPrimeraBtn;
        private FontAwesome.Sharp.IconButton PagUltimaBtn;
        private FontAwesome.Sharp.IconButton PagSiguienteBtn;
        private FontAwesome.Sharp.IconButton PagAnteriorBtn;
        private Label CantidadColoresLbl;
        private Label label2;
        private Label CantidadPaginasLbl;
        private Label label3;
        private Label PaginaActualLbl;
        private Label label1;
        private Panel panel3;
        private Panel panel5;
        private FontAwesome.Sharp.IconButton OrderABtn;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton OrderZBtn;
        private FontAwesome.Sharp.IconButton BorrarBtn;
        private FontAwesome.Sharp.IconButton EditarBtn;
        private FontAwesome.Sharp.IconButton NuevoColorBtn;
        private DataGridView DgvColours;
        private DataGridViewTextBoxColumn ColourNameCol;
    }
}