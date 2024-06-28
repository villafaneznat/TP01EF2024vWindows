namespace TP01EF2024.Windows.Entidades
{
    partial class GenresForm
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            panel1 = new Panel();
            ActualizarBtn = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            BuscarGeneroTxt = new TextBox();
            panel3 = new Panel();
            panel5 = new Panel();
            OrderABtn = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            OrderZBtn = new FontAwesome.Sharp.IconButton();
            BorrarBtn = new FontAwesome.Sharp.IconButton();
            EditarBtn = new FontAwesome.Sharp.IconButton();
            NuevoGeneroBtn = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            PagPrimeraBtn = new FontAwesome.Sharp.IconButton();
            PagUltimaBtn = new FontAwesome.Sharp.IconButton();
            PagSiguienteBtn = new FontAwesome.Sharp.IconButton();
            PagAnteriorBtn = new FontAwesome.Sharp.IconButton();
            CantidadGenerosLbl = new Label();
            label2 = new Label();
            CantidadPaginasLbl = new Label();
            label3 = new Label();
            PaginaActualLbl = new Label();
            label1 = new Label();
            DgvGenres = new DataGridView();
            GentreNameCol = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvGenres).BeginInit();
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
            ActualizarBtn.Location = new Point(312, 17);
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
            panel4.Controls.Add(BuscarGeneroTxt);
            panel4.Location = new Point(446, 17);
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
            // BuscarGeneroTxt
            // 
            BuscarGeneroTxt.BackColor = Color.FromArgb(64, 64, 64);
            BuscarGeneroTxt.BorderStyle = BorderStyle.None;
            BuscarGeneroTxt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BuscarGeneroTxt.ForeColor = Color.FromArgb(224, 224, 224);
            BuscarGeneroTxt.Location = new Point(37, 6);
            BuscarGeneroTxt.Name = "BuscarGeneroTxt";
            BuscarGeneroTxt.PlaceholderText = "Bucar Genero...";
            BuscarGeneroTxt.Size = new Size(285, 16);
            BuscarGeneroTxt.TabIndex = 0;
            BuscarGeneroTxt.TextChanged += BuscarGeneroTxt_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(37, 37, 37);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(BorrarBtn);
            panel3.Controls.Add(EditarBtn);
            panel3.Controls.Add(NuevoGeneroBtn);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(812, 66);
            panel3.MaximumSize = new Size(172, 500);
            panel3.MinimumSize = new Size(172, 500);
            panel3.Name = "panel3";
            panel3.Size = new Size(172, 500);
            panel3.TabIndex = 5;
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
            // NuevoGeneroBtn
            // 
            NuevoGeneroBtn.BackColor = Color.FromArgb(32, 32, 32);
            NuevoGeneroBtn.FlatAppearance.BorderSize = 0;
            NuevoGeneroBtn.FlatStyle = FlatStyle.Flat;
            NuevoGeneroBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NuevoGeneroBtn.ForeColor = Color.FromArgb(224, 224, 224);
            NuevoGeneroBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            NuevoGeneroBtn.IconColor = Color.Black;
            NuevoGeneroBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            NuevoGeneroBtn.Location = new Point(19, 49);
            NuevoGeneroBtn.Name = "NuevoGeneroBtn";
            NuevoGeneroBtn.Size = new Size(127, 43);
            NuevoGeneroBtn.TabIndex = 0;
            NuevoGeneroBtn.Text = "Nuevo Genero";
            NuevoGeneroBtn.UseVisualStyleBackColor = false;
            NuevoGeneroBtn.Click += NuevoGeneroBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(PagPrimeraBtn);
            panel2.Controls.Add(PagUltimaBtn);
            panel2.Controls.Add(PagSiguienteBtn);
            panel2.Controls.Add(PagAnteriorBtn);
            panel2.Controls.Add(CantidadGenerosLbl);
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
            panel2.TabIndex = 6;
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
            PagPrimeraBtn.Location = new Point(301, 20);
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
            PagUltimaBtn.Location = new Point(460, 20);
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
            PagSiguienteBtn.Location = new Point(421, 20);
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
            PagAnteriorBtn.Location = new Point(354, 20);
            PagAnteriorBtn.Name = "PagAnteriorBtn";
            PagAnteriorBtn.Size = new Size(30, 30);
            PagAnteriorBtn.TabIndex = 6;
            PagAnteriorBtn.Text = "<";
            PagAnteriorBtn.TextImageRelation = TextImageRelation.TextAboveImage;
            PagAnteriorBtn.UseVisualStyleBackColor = false;
            PagAnteriorBtn.Click += PagAnteriorBtn_Click;
            // 
            // CantidadGenerosLbl
            // 
            CantidadGenerosLbl.AutoSize = true;
            CantidadGenerosLbl.ForeColor = Color.FromArgb(224, 224, 224);
            CantidadGenerosLbl.Location = new Point(755, 26);
            CantidadGenerosLbl.Name = "CantidadGenerosLbl";
            CantidadGenerosLbl.Size = new Size(13, 15);
            CantidadGenerosLbl.TabIndex = 5;
            CantidadGenerosLbl.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(635, 25);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 4;
            label2.Text = "Cantidad de generos:";
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
            // DgvGenres
            // 
            DgvGenres.AllowUserToAddRows = false;
            DgvGenres.AllowUserToDeleteRows = false;
            DgvGenres.AllowUserToOrderColumns = true;
            DgvGenres.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(44, 44, 44);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle6.Padding = new Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(44, 44, 44);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(37, 212, 102);
            DgvGenres.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            DgvGenres.BackgroundColor = Color.FromArgb(44, 44, 44);
            DgvGenres.BorderStyle = BorderStyle.None;
            DgvGenres.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvGenres.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            DgvGenres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            DgvGenres.ColumnHeadersHeight = 50;
            DgvGenres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DgvGenres.Columns.AddRange(new DataGridViewColumn[] { GentreNameCol });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(44, 44, 44);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            DgvGenres.DefaultCellStyle = dataGridViewCellStyle8;
            DgvGenres.Dock = DockStyle.Fill;
            DgvGenres.EnableHeadersVisualStyles = false;
            DgvGenres.Location = new Point(0, 66);
            DgvGenres.Margin = new Padding(10);
            DgvGenres.MultiSelect = false;
            DgvGenres.Name = "DgvGenres";
            DgvGenres.ReadOnly = true;
            DgvGenres.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle9.Padding = new Padding(5);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            DgvGenres.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            DgvGenres.RowHeadersWidth = 30;
            DgvGenres.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(44, 44, 44);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle10.Padding = new Padding(5);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(44, 44, 44);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(37, 211, 102);
            DgvGenres.RowsDefaultCellStyle = dataGridViewCellStyle10;
            DgvGenres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvGenres.Size = new Size(812, 380);
            DgvGenres.TabIndex = 7;
            // 
            // GentreNameCol
            // 
            GentreNameCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GentreNameCol.HeaderText = "Género";
            GentreNameCol.Name = "GentreNameCol";
            GentreNameCol.ReadOnly = true;
            // 
            // GenresForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 44);
            ClientSize = new Size(984, 534);
            ControlBox = false;
            Controls.Add(DgvGenres);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            MaximumSize = new Size(1000, 550);
            MinimumSize = new Size(1000, 550);
            Name = "GenresForm";
            Load += GenresForm_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvGenres).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton ActualizarBtn;
        private Panel panel4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox BuscarGeneroTxt;
        private Panel panel3;
        private Panel panel5;
        private FontAwesome.Sharp.IconButton OrderABtn;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton OrderZBtn;
        private FontAwesome.Sharp.IconButton BorrarBtn;
        private FontAwesome.Sharp.IconButton EditarBtn;
        private FontAwesome.Sharp.IconButton NuevoGeneroBtn;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton PagPrimeraBtn;
        private FontAwesome.Sharp.IconButton PagUltimaBtn;
        private FontAwesome.Sharp.IconButton PagSiguienteBtn;
        private FontAwesome.Sharp.IconButton PagAnteriorBtn;
        private Label CantidadGenerosLbl;
        private Label label2;
        private Label CantidadPaginasLbl;
        private Label label3;
        private Label PaginaActualLbl;
        private Label label1;
        private DataGridView DgvGenres;
        private DataGridViewTextBoxColumn GentreNameCol;
    }
}