using BLL;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FormFilasAfectadas : Form
    {
        public FormFilasAfectadas()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormInsertarProyecto mostrar = new FormInsertarProyecto();
            mostrar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassContarFilas listar = new ClassContarFilas();
            this.dataGridView1.DataSource = listar.Proyecto();
            this.dataGridView1.Refresh();
            Contar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormModificarProyecto mostrar = new FormModificarProyecto();
            mostrar.ShowDialog();
        }

        private void FormFilasAfectadas_Load(object sender, EventArgs e)
        {
            ClassContarFilas listar = new ClassContarFilas();
            this.dataGridView1.DataSource = listar.Proyecto();
            this.dataGridView1.Refresh();
            Contar();
        }

        public void Contar()
        {
            ClassContarFilas contar = new ClassContarFilas();
            label2.Text = contar.Proyecto().Rows.Count.ToString();
            this.dataGridView1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormEliminarProyecto eliminar = new FormEliminarProyecto();
            eliminar.ShowDialog();
        }
    }
}
