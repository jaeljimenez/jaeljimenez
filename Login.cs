using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormProject;

namespace WindowsFormProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Program.boolUserAuthenticated = true;

            if (ClassData.sqlDatareader
                    (ClassData.SqlCommand(
                        "SELECT UserNameEntidad, PassworEntidad FROM Entindades WHERE UserNameEntidad = '"
                        + User.Text.ToString()
                        + "' AND PassworEntidad ='" + Pass.Text.ToString() + "'", CommandType.Text
                    )
                ).HasRows == false
            )
            {
                Program.boolUserAuthenticated = false;
                MessageBox.Show("Acceso No Válido. Revise Sus Credenciales", "Atención", MessageBoxButtons.OK);

            }
         
                                                 
            ClassData.SQLConnectionDB().Close();
            ClassData.SQLConnectionDB().Dispose();
            
            if (Program.boolUserAuthenticated)
            {
                Program.boolUserAuthenticated = true;
                this.Close();
            }
        }
    }

}
