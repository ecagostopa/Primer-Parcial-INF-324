using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _6ta_pregunta_324
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string conexion = "SERVER=127.0.0.1;PORT=3306;DATABASE=mibd_agostopa;UID=root;PASSWORD=;";
        MySqlConnection cn = new MySqlConnection(conexion);

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenar_grid();
        }

        public DataTable llenar_grid()
        {
            cn.Open();
            DataTable dt = new DataTable();
            string llenar = "select * from estudiante";
            MySqlCommand cmd = new MySqlCommand(llenar,cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();
            return dt;
        }
        private void limpiar()
        {
            textUsuario.Clear();
            textPassword.Clear();
            textNombre.Clear();
            textPaterno.Clear();
            textMaterno.Clear();
            textSemestre.Clear();
            textLocacion.Clear();
            textGenero.Clear();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            cn.Open();
            string insertar = "INSERT INTO estudiante (usuario, password, nombre, ap_paterno, ap_materno, semestre, locacion, genero) " +
                "VALUES (@usuario, @password, @nombre, @ap_paterno, @ap_materno, @semestre, @locacion, @genero)";
            MySqlCommand cmd = new MySqlCommand(insertar,cn);
            cmd.Parameters.AddWithValue("@usuario",textUsuario.Text);
            cmd.Parameters.AddWithValue("@password", textPassword.Text);
            cmd.Parameters.AddWithValue("@nombre", textNombre.Text);
            cmd.Parameters.AddWithValue("@ap_paterno", textPaterno.Text);
            cmd.Parameters.AddWithValue("@ap_materno", textMaterno.Text);
            cmd.Parameters.AddWithValue("@semestre", textSemestre.Text);
            cmd.Parameters.AddWithValue("@locacion", textLocacion.Text);
            cmd.Parameters.AddWithValue("@genero", textGenero.Text);

            cmd.ExecuteNonQuery();

            cn.Close();

            MessageBox.Show("Datos AGREGADOS con exito");

            dataGridView1.DataSource = llenar_grid();

            limpiar();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            cn.Open();
            string actualizar = "UPDATE estudiante SET usuario=@usuario, password=@password," +
                "nombre=@nombre, ap_paterno=@ap_paterno, ap_materno=@ap_materno, semestre=@semestre," +
                "locacion=@locacion, genero=@genero WHERE usuario=@usuario";
            MySqlCommand cmd = new MySqlCommand(actualizar,cn);
            cmd.Parameters.AddWithValue("@usuario", textUsuario.Text);
            cmd.Parameters.AddWithValue("@password", textPassword.Text);
            cmd.Parameters.AddWithValue("@nombre", textNombre.Text);
            cmd.Parameters.AddWithValue("@ap_paterno", textPaterno.Text);
            cmd.Parameters.AddWithValue("@ap_materno", textMaterno.Text);
            cmd.Parameters.AddWithValue("@semestre", textSemestre.Text);
            cmd.Parameters.AddWithValue("@locacion", textLocacion.Text);
            cmd.Parameters.AddWithValue("@genero", textGenero.Text);

            cmd.ExecuteNonQuery();

            cn.Close();

            MessageBox.Show("Datos ACTUALIZADOS con exito");

            dataGridView1.DataSource = llenar_grid();

            limpiar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textUsuario.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textPassword.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textNombre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textPaterno.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textMaterno.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textSemestre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textLocacion.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textGenero.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            }
            catch { }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            cn.Open();
            string eliminar = "DELETE FROM estudiante WHERE usuario=@usuario";
            MySqlCommand cmd = new MySqlCommand(eliminar,cn);
            cmd.Parameters.AddWithValue("@usuario", textUsuario.Text);
            cmd.ExecuteNonQuery();

            cn.Close();

            MessageBox.Show("Datos ELIMINADOS con exito");

            dataGridView1.DataSource = llenar_grid();

            limpiar();
        }
    }
}
