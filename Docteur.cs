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
    public partial class Docteur : Form
    {

        DOCTEUR docteur = new  DOCTEUR();
        public Docteur()
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
            docteur.Read_data();
            dataGridView1.DataSource = docteur.dt;
        }

        //create
        public void CREATE()
        {
            docteur.name = name.Text;

            docteur.specialite = specialite.Text;

            docteur.Create_data();


        }

        //create
        public void UPDATE()
        {
            docteur.id = IDTXT.Text;
            docteur.name = u_name.Text;

            docteur.specialite = u_specialite.Text;

            docteur.Update_data();


        }


        //delete

        public void DELETE()
        {
            docteur.id = IDTXT.Text;
            docteur.Delete_data();
        }







        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            DataGridView senderGrid = (DataGridView)sender;


            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                IDTXT.Text = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                u_name.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                u_specialite.Text = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
              
            }

        }



    }
}
