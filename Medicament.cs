using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using samar.classes;
using MySql.Data.MySqlClient;
namespace samar
{
    public partial class Medicament : Form
    {
        CRUD crud = new CRUD();

        public Medicament()
        {
            InitializeComponent();
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            CREATE();
            READ();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Update();
            READ();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DELETE();
            READ();
        }


        //read function

        public void READ()
        {
            dataGridView1.DataSource = null;
            crud.Read_data();
            dataGridView1.DataSource = crud.dt;
        }

        //create
        public void CREATE()
        {
            crud.nom = nom.Text;
            crud.description = description.Text;
            crud.prix = prix.Text;

            crud.Create_data();


        }

        //create
        public void UPDATE()
        {
            crud.id = IDTXT.Text;
            crud.prix = u_prix.Text;
            crud.description = u_description.Text;
            crud.prix = u_prix.Text;

            crud.Update_data();


        }


        //delete

        public void DELETE()
        {
            crud.id = IDTXT.Text;
            crud.Delete_data();
        }







        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            DataGridView senderGrid = (DataGridView)sender;


            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                IDTXT.Text = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                u_nom.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                u_description.Text = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                u_prix.Text = (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }

        }




    }
}
