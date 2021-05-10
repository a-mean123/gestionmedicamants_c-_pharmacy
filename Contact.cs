﻿using System;
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
    public partial class Contact : Form
    {


        CONTACT contact = new CONTACT();
        public Contact()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            READ();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UPDATE();
            READ();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DELETE();
            READ();
        }





        public void READ()
        {
            dataGridView1.DataSource = null;
            contact.Read_data();
            dataGridView1.DataSource = contact.dt;
        }



        //create
        public void UPDATE()
        {
            contact.id = IDTXT.Text;
            contact.name = u_name.Text;
           
            contact.email = u_email.Text;

            contact.message = u_message.Text;


            contact.Update_data();


        }


        //delete

        public void DELETE()
        {
            contact.id = IDTXT.Text;
            contact.Delete_data();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;


            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                IDTXT.Text = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                u_name.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
               
                u_email.Text = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
              
                u_message.Text = (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

            }
        }




    }
}
