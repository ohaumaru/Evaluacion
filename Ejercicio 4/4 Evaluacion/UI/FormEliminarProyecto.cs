using BLL;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FormEliminarProyecto : Form
    {
        public FormEliminarProyecto()
        {
            InitializeComponent();
        }

        private void FormEliminarProyecto_Load(object sender, EventArgs e)
        {
            ClassContarFilas agregar = new ClassContarFilas();
            this.comboBox1.DataSource = agregar.Proyecto();
            this.comboBox1.DisplayMember = "Nombre_Proyecto";
            this.comboBox1.ValueMember = "Codigo_Proyecto";
            this.comboBox1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            ClassContarFilas eliminar = new ClassContarFilas();
            respuesta = eliminar.EliminarProyecto(this.comboBox1.Text);
            MessageBox.Show(respuesta);

            ClassContarFilas agregar = new ClassContarFilas();
            this.comboBox1.DataSource = agregar.Proyecto();
            this.comboBox1.DisplayMember = "Nombre_Proyecto";
            this.comboBox1.ValueMember = "Codigo_Proyecto";
            this.comboBox1.Refresh();
        }
    }
}
