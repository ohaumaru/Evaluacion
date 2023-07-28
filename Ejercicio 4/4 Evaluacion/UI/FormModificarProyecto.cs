using BLL;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FormModificarProyecto : Form
    {
        public FormModificarProyecto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); //Cierra el Form y permite volver al Form anterior
        }

        private void FormModificarProyecto_Load(object sender, EventArgs e)
        {
            ClassContarFilas agregar = new ClassContarFilas();
            this.comboBox1.DataSource = agregar.Proyecto();
            this.comboBox1.DisplayMember = "Nombre_Proyecto";
            this.comboBox1.ValueMember = "Codigo_Proyecto";
            this.comboBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            ClassContarFilas modificar = new ClassContarFilas();
            respuesta = modificar.ModificarProyecto(this.comboBox1.Text, textBox1.Text);
            MessageBox.Show(respuesta);
            textBox1.Clear();

            ClassContarFilas agregar = new ClassContarFilas();
            this.comboBox1.DataSource = agregar.Proyecto();
            this.comboBox1.DisplayMember = "Nombre_Proyecto";
            this.comboBox1.ValueMember = "Codigo_Proyecto";
            this.comboBox1.Refresh();
            this.comboBox1.Refresh();
        }
    }
}
