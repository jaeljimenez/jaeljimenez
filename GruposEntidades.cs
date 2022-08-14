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


namespace WindowsFormProject
{
    public partial class GruposEntidades : Form
    {
        public GruposEntidades()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var comand = ClassData.SqlCommand("insert into Entindades(UserNameEntidad,PassworEntidad) values(@usuario,@clave)", CommandType.Text);
                comand.Parameters.AddWithValue("@usuario",textBox1.Text);
                comand.Parameters.AddWithValue("@clave", textBox2 .Text);
                comand.ExecuteNonQuery();
            ClassData.SQLConnectionDB().Close();
            ClassData.SQLConnectionDB().Dispose();
        }

        private void GruposEntidades_Load(object sender, EventArgs e)
        {
            List<Entidad> list = new List<Entidad>();
            var reader = ClassData.SqlCommand("select * from Entindades", CommandType.Text).ExecuteReader();

            while (reader.Read())
            {
                Entidad entidad = new Entidad();
                entidad.UserNameEntidad = reader.GetString(1);
                entidad.PassworEntidad = reader.GetString(2);
                entidad.ID = reader.GetInt32(0);

                list.Add(entidad);
            }

            
            ClassData.SQLConnectionDB().Close();
            ClassData.SQLConnectionDB().Dispose();

            dataGridView1.DataSource = list;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var comand = ClassData.SqlCommand("update Entindades set UserNameEntidad=@usuario,PassworEntidad= @clave where id=@id", CommandType.Text);
            comand.Parameters.AddWithValue("@usuario", textBox2.Text);
            comand.Parameters.AddWithValue("@clave", textBox3.Text);
            comand.Parameters.AddWithValue("@id", textBox1.Text);
            comand.ExecuteNonQuery();
            ClassData.SQLConnectionDB().Close();
            ClassData.SQLConnectionDB().Dispose();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //MessageBox.Show(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var reader = ClassData.SqlCommand("select * from Entindades", CommandType.Text).ExecuteReader();

            reader.Read();
            {
                Entidad entidad = new Entidad();
                entidad.UserNameEntidad = reader.GetString(0);
                entidad.PassworEntidad = reader.GetString(1);
            
            }

            ClassData.SQLConnectionDB().Close();
            ClassData.SQLConnectionDB().Dispose();


        }

        private void button3_Click(object sender, EventArgs e)
        {

            var comand = ClassData.SqlCommand("delete from Entindades where id=@id", CommandType.Text);
            comand.Parameters.AddWithValue("@id", textBox1.Text);
            comand.ExecuteNonQuery();
            ClassData.SQLConnectionDB().Close();
            ClassData.SQLConnectionDB().Dispose();
        }
    }
    public class Entidad
    {
        public int ID { get; set; }

        public string UserNameEntidad { get; set; }
        public string PassworEntidad { get; set; }
    }
}
