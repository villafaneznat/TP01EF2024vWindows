namespace TP01EF2024.Windows.Entidades
{
    partial class ShoesForm
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
            FiltrarBtn = new FontAwesome.Sharp.IconButton();
            ActualizarBtn = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            BuscarZapatoTxt = new TextBox();
            panel3 = new Panel();
            panel6 = new Panel();
            OrderABtn = new FontAwesome.Sharp.IconButton();
            OrderPMinBtn = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            OrderZBtn = new FontAwesome.Sharp.IconButton();
            OrderPMaxBtn = new FontAwesome.Sharp.IconButton();
            VerDetallesBtn = new FontAwesome.Sharp.IconButton();
            BorrarZapatoBtn = new FontAwesome.Sharp.IconButton();
            EditarZapatoBtn = new FontAwesome.Sharp.IconButton();
            NuevoZapatoBtn = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            PagPrimeraBtn = new FontAwesome.Sharp.IconButton();
            PagUltimaBtn = new FontAwesome.Sharp.IconButton();
            PagSiguienteBtn = new FontAwesome.Sharp.IconButton();
            PagAnteriorBtn = new FontAwesome.Sharp.IconButton();
            CantidadZapatosLbl = new Label();
            label2 = new Label();
            CantidadPaginasLbl = new Label();
            label3 = new Label();
            PaginaActualLbl = new Label();
            label1 = new Label();
            DgvShoes = new DataGridView();
            ModeloCol = new DataGridViewTextBoxColumn();
            MarcaCol = new DataGridViewTextBoxColumn();
            ColorCol = new DataGridViewTextBoxColumn();
            DeporteCol = new DataGridViewTextBoxColumn();
            GeneroCol = new DataGridViewTextBoxColumn();
            PrecioCol = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvShoes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(FiltrarBtn);
            panel1.Controls.Add(ActualizarBtn);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 66);
            panel1.TabIndex = 1;
            // 
            // FiltrarBtn
            // 
            FiltrarBtn.BackColor = Color.FromArgb(32, 32, 32);
            FiltrarBtn.FlatAppearance.BorderSize = 0;
            FiltrarBtn.FlatStyle = FlatStyle.Flat;
            FiltrarBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FiltrarBtn.ForeColor = Color.FromArgb(224, 224, 224);
            FiltrarBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            FiltrarBtn.IconColor = Color.Black;
            FiltrarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            FiltrarBtn.Location = new Point(843, 14);
            FiltrarBtn.Name = "FiltrarBtn";
            FiltrarBtn.Size = new Size(127, 34);
            FiltrarBtn.TabIndex = 7;
            FiltrarBtn.Text = "Filtrar";
            FiltrarBtn.UseVisualStyleBackColor = false;
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
            ActualizarBtn.Location = new Point(326, 17);
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
            panel4.Controls.Add(BuscarZapatoTxt);
            panel4.Location = new Point(460, 17);
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
            // BuscarZapatoTxt
            // 
            BuscarZapatoTxt.BackColor = Color.FromArgb(64, 64, 64);
            BuscarZapatoTxt.BorderStyle = BorderStyle.None;
            BuscarZapatoTxt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BuscarZapatoTxt.ForeColor = Color.FromArgb(224, 224, 224);
            BuscarZapatoTxt.Location = new Point(37, 6);
            BuscarZapatoTxt.Name = "BuscarZapatoTxt";
            BuscarZapatoTxt.PlaceholderText = "Buscar Zapato...";
            BuscarZapatoTxt.Size = new Size(285, 16);
            BuscarZapatoTxt.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(37, 37, 37);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(VerDetallesBtn);
            panel3.Controls.Add(BorrarZapatoBtn);
            panel3.Controls.Add(EditarZapatoBtn);
            panel3.Controls.Add(NuevoZapatoBtn);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(812, 66);
            panel3.MaximumSize = new Size(172, 500);
            panel3.MinimumSize = new Size(172, 500);
            panel3.Name = "panel3";
            panel3.Size = new Size(172, 500);
            panel3.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.Controls.Add(OrderABtn);
            panel6.Controls.Add(OrderPMinBtn);
            panel6.Controls.Add(iconButton1);
            panel6.Controls.Add(OrderZBtn);
            panel6.Controls.Add(OrderPMaxBtn);
            panel6.Location = new Point(16, 226);
            panel6.Name = "panel6";
            panel6.Size = new Size(127, 204);
            panel6.TabIndex = 6;
            // 
            // OrderABtn
            // 
            OrderABtn.BackColor = Color.FromArgb(40, 40, 40);
            OrderABtn.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            OrderABtn.FlatStyle = FlatStyle.Flat;
            OrderABtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrderABtn.ForeColor = Color.FromArgb(224, 224, 224);
            OrderABtn.IconChar = FontAwesome.Sharp.IconChar.None;
            OrderABtn.IconColor = Color.Black;
            OrderABtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            OrderABtn.Location = new Point(0, 62);
            OrderABtn.Name = "OrderABtn";
            OrderABtn.Size = new Size(127, 32);
            OrderABtn.TabIndex = 5;
            OrderABtn.Text = "A - Z";
            OrderABtn.UseVisualStyleBackColor = false;
            OrderABtn.Click += OrderABtn_Click;
            // 
            // OrderPMinBtn
            // 
            OrderPMinBtn.BackColor = Color.FromArgb(40, 40, 40);
            OrderPMinBtn.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            OrderPMinBtn.FlatStyle = FlatStyle.Flat;
            OrderPMinBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrderPMinBtn.ForeColor = Color.FromArgb(224, 224, 224);
            OrderPMinBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            OrderPMinBtn.IconColor = Color.Black;
            OrderPMinBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            OrderPMinBtn.Location = new Point(0, 131);
            OrderPMinBtn.Name = "OrderPMinBtn";
            OrderPMinBtn.Size = new Size(127, 32);
            OrderPMinBtn.TabIndex = 6;
            OrderPMinBtn.Text = "Menor precio";
            OrderPMinBtn.UseVisualStyleBackColor = false;
            OrderPMinBtn.Click += OrderPMinBtn_Click;
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
            iconButton1.Location = new Point(0, 13);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(127, 43);
            iconButton1.TabIndex = 3;
            iconButton1.Text = "Ordenar";
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // OrderZBtn
            // 
            OrderZBtn.BackColor = Color.FromArgb(40, 40, 40);
            OrderZBtn.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            OrderZBtn.FlatStyle = FlatStyle.Flat;
            OrderZBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrderZBtn.ForeColor = Color.FromArgb(224, 224, 224);
            OrderZBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            OrderZBtn.IconColor = Color.Black;
            OrderZBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            OrderZBtn.Location = new Point(0, 96);
            OrderZBtn.Name = "OrderZBtn";
            OrderZBtn.Size = new Size(127, 32);
            OrderZBtn.TabIndex = 4;
            OrderZBtn.Text = "Z - A";
            OrderZBtn.UseVisualStyleBackColor = false;
            OrderZBtn.Click += OrderZBtn_Click;
            // 
            // OrderPMaxBtn
            // 
            OrderPMaxBtn.BackColor = Color.FromArgb(40, 40, 40);
            OrderPMaxBtn.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            OrderPMaxBtn.FlatStyle = FlatStyle.Flat;
            OrderPMaxBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrderPMaxBtn.ForeColor = Color.FromArgb(224, 224, 224);
            OrderPMaxBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            OrderPMaxBtn.IconColor = Color.Black;
            OrderPMaxBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            OrderPMaxBtn.Location = new Point(0, 166);
            OrderPMaxBtn.Name = "OrderPMaxBtn";
            OrderPMaxBtn.Size = new Size(127, 32);
            OrderPMaxBtn.TabIndex = 7;
            OrderPMaxBtn.Text = "Mayor precio";
            OrderPMaxBtn.UseVisualStyleBackColor = false;
            OrderPMaxBtn.Click += OrderPMaxBtn_Click;
            // 
            // VerDetallesBtn
            // 
            VerDetallesBtn.BackColor = Color.FromArgb(32, 32, 32);
            VerDetallesBtn.FlatAppearance.BorderSize = 0;
            VerDetallesBtn.FlatStyle = FlatStyle.Flat;
            VerDetallesBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VerDetallesBtn.ForeColor = Color.FromArgb(224, 224, 224);
            VerDetallesBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            VerDetallesBtn.IconColor = Color.Black;
            VerDetallesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            VerDetallesBtn.Location = new Point(16, 179);
            VerDetallesBtn.Name = "VerDetallesBtn";
            VerDetallesBtn.Size = new Size(127, 43);
            VerDetallesBtn.TabIndex = 6;
            VerDetallesBtn.Text = "Ver Detalles";
            VerDetallesBtn.UseVisualStyleBackColor = false;
            // 
            // BorrarZapatoBtn
            // 
            BorrarZapatoBtn.BackColor = Color.FromArgb(32, 32, 32);
            BorrarZapatoBtn.FlatAppearance.BorderSize = 0;
            BorrarZapatoBtn.FlatStyle = FlatStyle.Flat;
            BorrarZapatoBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BorrarZapatoBtn.ForeColor = Color.FromArgb(224, 224, 224);
            BorrarZapatoBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            BorrarZapatoBtn.IconColor = Color.Black;
            BorrarZapatoBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BorrarZapatoBtn.Location = new Point(16, 121);
            BorrarZapatoBtn.Name = "BorrarZapatoBtn";
            BorrarZapatoBtn.Size = new Size(127, 43);
            BorrarZapatoBtn.TabIndex = 2;
            BorrarZapatoBtn.Text = "Borrar";
            BorrarZapatoBtn.UseVisualStyleBackColor = false;
            BorrarZapatoBtn.Click += BorrarZapatoBtn_Click;
            // 
            // EditarZapatoBtn
            // 
            EditarZapatoBtn.BackColor = Color.FromArgb(32, 32, 32);
            EditarZapatoBtn.FlatAppearance.BorderSize = 0;
            EditarZapatoBtn.FlatStyle = FlatStyle.Flat;
            EditarZapatoBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditarZapatoBtn.ForeColor = Color.FromArgb(224, 224, 224);
            EditarZapatoBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            EditarZapatoBtn.IconColor = Color.Black;
            EditarZapatoBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            EditarZapatoBtn.Location = new Point(16, 65);
            EditarZapatoBtn.Name = "EditarZapatoBtn";
            EditarZapatoBtn.Size = new Size(127, 43);
            EditarZapatoBtn.TabIndex = 1;
            EditarZapatoBtn.Text = "Editar";
            EditarZapatoBtn.UseVisualStyleBackColor = false;
            EditarZapatoBtn.Click += EditarZapatoBtn_Click;
            // 
            // NuevoZapatoBtn
            // 
            NuevoZapatoBtn.BackColor = Color.FromArgb(32, 32, 32);
            NuevoZapatoBtn.FlatAppearance.BorderSize = 0;
            NuevoZapatoBtn.FlatStyle = FlatStyle.Flat;
            NuevoZapatoBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NuevoZapatoBtn.ForeColor = Color.FromArgb(224, 224, 224);
            NuevoZapatoBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            NuevoZapatoBtn.IconColor = Color.Black;
            NuevoZapatoBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            NuevoZapatoBtn.Location = new Point(16, 6);
            NuevoZapatoBtn.Name = "NuevoZapatoBtn";
            NuevoZapatoBtn.Size = new Size(127, 43);
            NuevoZapatoBtn.TabIndex = 0;
            NuevoZapatoBtn.Text = "Nuevo Zapato";
            NuevoZapatoBtn.UseVisualStyleBackColor = false;
            NuevoZapatoBtn.Click += NuevoZapatoBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(PagPrimeraBtn);
            panel2.Controls.Add(PagUltimaBtn);
            panel2.Controls.Add(PagSiguienteBtn);
            panel2.Controls.Add(PagAnteriorBtn);
            panel2.Controls.Add(CantidadZapatosLbl);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(CantidadPaginasLbl);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(PaginaActualLbl);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 446);
            panel2.MaximumSize = new Size(812, 88);
            panel2.MinimumSize = new Size(740, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(812, 88);
            panel2.TabIndex = 5;
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
            PagPrimeraBtn.Location = new Point(258, 20);
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
            PagUltimaBtn.Location = new Point(417, 20);
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
            PagSiguienteBtn.Location = new Point(378, 20);
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
            PagAnteriorBtn.Location = new Point(311, 20);
            PagAnteriorBtn.Name = "PagAnteriorBtn";
            PagAnteriorBtn.Size = new Size(30, 30);
            PagAnteriorBtn.TabIndex = 6;
            PagAnteriorBtn.Text = "<";
            PagAnteriorBtn.TextImageRelation = TextImageRelation.TextAboveImage;
            PagAnteriorBtn.UseVisualStyleBackColor = false;
            PagAnteriorBtn.Click += PagAnteriorBtn_Click;
            // 
            // CantidadZapatosLbl
            // 
            CantidadZapatosLbl.AutoSize = true;
            CantidadZapatosLbl.ForeColor = Color.FromArgb(224, 224, 224);
            CantidadZapatosLbl.Location = new Point(772, 26);
            CantidadZapatosLbl.Name = "CantidadZapatosLbl";
            CantidadZapatosLbl.Size = new Size(13, 15);
            CantidadZapatosLbl.TabIndex = 5;
            CantidadZapatosLbl.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(657, 25);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 4;
            label2.Text = "Cantidad de zapatos:";
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
            // DgvShoes
            // 
            DgvShoes.AllowUserToAddRows = false;
            DgvShoes.AllowUserToDeleteRows = false;
            DgvShoes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(44, 44, 44);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(44, 44, 44);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(37, 212, 102);
            DgvShoes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvShoes.BackgroundColor = Color.FromArgb(44, 44, 44);
            DgvShoes.BorderStyle = BorderStyle.None;
            DgvShoes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvShoes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DgvShoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DgvShoes.ColumnHeadersHeight = 45;
            DgvShoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DgvShoes.Columns.AddRange(new DataGridViewColumn[] { ModeloCol, MarcaCol, ColorCol, DeporteCol, GeneroCol, PrecioCol });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(44, 44, 44);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DgvShoes.DefaultCellStyle = dataGridViewCellStyle3;
            DgvShoes.Dock = DockStyle.Fill;
            DgvShoes.EnableHeadersVisualStyles = false;
            DgvShoes.Location = new Point(0, 66);
            DgvShoes.Margin = new Padding(10);
            DgvShoes.MultiSelect = false;
            DgvShoes.Name = "DgvShoes";
            DgvShoes.ReadOnly = true;
            DgvShoes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.Padding = new Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DgvShoes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DgvShoes.RowHeadersWidth = 30;
            DgvShoes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(44, 44, 44);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle5.Padding = new Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(44, 44, 44);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(37, 211, 102);
            DgvShoes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            DgvShoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvShoes.Size = new Size(812, 380);
            DgvShoes.TabIndex = 6;
            // 
            // ModeloCol
            // 
            ModeloCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ModeloCol.FillWeight = 97.71578F;
            ModeloCol.HeaderText = "Modelo";
            ModeloCol.MinimumWidth = 109;
            ModeloCol.Name = "ModeloCol";
            ModeloCol.ReadOnly = true;
            // 
            // MarcaCol
            // 
            MarcaCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MarcaCol.FillWeight = 97.71578F;
            MarcaCol.HeaderText = "Marca";
            MarcaCol.Name = "MarcaCol";
            MarcaCol.ReadOnly = true;
            // 
            // ColorCol
            // 
            ColorCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColorCol.FillWeight = 97.71578F;
            ColorCol.HeaderText = "Color";
            ColorCol.Name = "ColorCol";
            ColorCol.ReadOnly = true;
            // 
            // DeporteCol
            // 
            DeporteCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DeporteCol.FillWeight = 97.71578F;
            DeporteCol.HeaderText = "Deporte";
            DeporteCol.Name = "DeporteCol";
            DeporteCol.ReadOnly = true;
            // 
            // GeneroCol
            // 
            GeneroCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GeneroCol.FillWeight = 97.71578F;
            GeneroCol.HeaderText = "Genero";
            GeneroCol.Name = "GeneroCol";
            GeneroCol.ReadOnly = true;
            // 
            // PrecioCol
            // 
            PrecioCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PrecioCol.FillWeight = 97.71578F;
            PrecioCol.HeaderText = "Precio";
            PrecioCol.MinimumWidth = 99;
            PrecioCol.Name = "PrecioCol";
            PrecioCol.ReadOnly = true;
            // 
            // ShoesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 44);
            ClientSize = new Size(984, 534);
            ControlBox = false;
            Controls.Add(DgvShoes);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            MaximumSize = new Size(1000, 550);
            MinimumSize = new Size(1000, 550);
            Name = "ShoesForm";
            Load += ShoesForm_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvShoes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton ActualizarBtn;
        private Panel panel4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox BuscarZapatoTxt;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton BorrarZapatoBtn;
        private FontAwesome.Sharp.IconButton EditarZapatoBtn;
        private FontAwesome.Sharp.IconButton NuevoZapatoBtn;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton PagPrimeraBtn;
        private FontAwesome.Sharp.IconButton PagUltimaBtn;
        private FontAwesome.Sharp.IconButton PagSiguienteBtn;
        private FontAwesome.Sharp.IconButton PagAnteriorBtn;
        private Label CantidadZapatosLbl;
        private Label label2;
        private Label CantidadPaginasLbl;
        private Label label3;
        private Label PaginaActualLbl;
        private Label label1;
        private DataGridView DgvShoes;
        private FontAwesome.Sharp.IconButton VerDetallesBtn;
        private FontAwesome.Sharp.IconButton FiltrarBtn;
        private Panel panel6;
        private FontAwesome.Sharp.IconButton OrderABtn;
        private FontAwesome.Sharp.IconButton OrderPMinBtn;
        private FontAwesome.Sharp.IconButton OrderZBtn;
        private FontAwesome.Sharp.IconButton OrderPMaxBtn;
        private DataGridViewTextBoxColumn ModeloCol;
        private DataGridViewTextBoxColumn MarcaCol;
        private DataGridViewTextBoxColumn ColorCol;
        private DataGridViewTextBoxColumn DeporteCol;
        private DataGridViewTextBoxColumn GeneroCol;
        private DataGridViewTextBoxColumn PrecioCol;
    }
}