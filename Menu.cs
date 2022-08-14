using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormProject
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            this.Hide();
            about.ShowDialog();
            this.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void grupoEntidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GruposEntidades grupo = new GruposEntidades();
            this.Hide();
            grupo.ShowDialog();
            this.Show();

        }

        private void tiposEntidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TiposEntidades tipos = new TiposEntidades();
            this.Hide();
            tipos.ShowDialog();
            this.Show();

        }

        private void entidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entidades entidades = new Entidades();
            this.Hide();
            entidades.ShowDialog();
            this.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = DateTime.Now.ToString("hh:mm:ss tt");

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();

        }
    }
}
