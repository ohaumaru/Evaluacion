using BLL;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FormInsertarProyecto : Form
    {
        public FormInsertarProyecto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {          
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassContarFilas insertar = new ClassContarFilas();
            string respuesta = "";
            respuesta = insertar.InsertarProyecto(textBox1.Text);
            MessageBox.Show(respuesta);
        }
    }
}
