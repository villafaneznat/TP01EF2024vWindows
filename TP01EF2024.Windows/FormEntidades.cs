using FontAwesome.Sharp;
using System.Windows.Media;
using TP01EF2024.Windows.Entidades;
using Color = System.Drawing.Color;

namespace TP01EF2024.Windows
{
    public partial class FormEntidades : Form
    {
        private IconButton currentBtn;

        private Panel topBorderBtn;

        private Form currentForm;

        public FormEntidades()
        {
            InitializeComponent();
            topBorderBtn = new Panel();
            topBorderBtn.Size = new Size(96, 5);
            panelMenu.Controls.Add(topBorderBtn);
        }

        private void FormEntidades_Load(object sender, EventArgs e)
        {

        }

        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();

                //button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(44, 44, 44); //gris claro
                currentBtn.ForeColor = Color.FromArgb(37, 211, 102); //verde
                currentBtn.IconColor = Color.FromArgb(37, 211, 102); // verde

                //borde de arriba

                topBorderBtn.BackColor = Color.FromArgb(37, 211, 102); // verde
                topBorderBtn.Location = new Point(currentBtn.Location.X, 0);
                topBorderBtn.Visible = true;
                topBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(32, 32, 32); //gris oscuro
                currentBtn.ForeColor = Color.FromArgb(224, 224, 224);
                currentBtn.IconColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void OpenChildForm(Form form)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            PanelForm.Controls.Add(form);
            PanelForm.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void ZapatosBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new ShoesForm());
        }

        private void MarcasBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new BrandsForm());
        }

        private void GenerosBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new GenresForm());
        }

        private void DeportesBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new SportsForm());
        }

        private void ColoresBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new ColoursForm());
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            FormPrincipal frm = new FormPrincipal();
            frm.Show();
            this.Close();
        }
    }
}
