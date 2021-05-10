using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace samar.classes
{

    class Connect
    {

        public MySqlConnection con;

        public Connect()

        {


            string host = "localhost";
            string db = "samar";
            string port = "3306";
            string user = "root";
            string pass = "";
            string constring = "datasource =" + host + "; database =" + db + "; port =" + port + "; username =" + user + "; password=" + pass + "; SslMode=none";

            con = new MySqlConnection(constring);

        }



    }


    class CRUD : Connect

    {

        public string nom { set; get; }
        public string description { set; get; }
        public string prix { set; get; }


        public string id { set; get; }

        //read proprite

        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();




        //create function

        public void Create_data()
        {

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {

                cmd.CommandText = "INSERT INTO `medicament`(`nom`, `description`, `prix`) VALUES (@nom,@desc,@prix)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = nom;
                cmd.Parameters.Add("@desc", MySqlDbType.VarChar).Value = description;
                cmd.Parameters.Add("@prix", MySqlDbType.VarChar).Value = prix;

                cmd.ExecuteNonQuery();
                con.Close();

            }
        }


        //update 

        public void Update_data()
        {

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {

                cmd.CommandText = "UPDATE `medicament` SET `nom`=@nom,`description`=@desc,`prix`=@prix  WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = nom;
                cmd.Parameters.Add("@desc", MySqlDbType.VarChar).Value = description;
                cmd.Parameters.Add("@prix", MySqlDbType.VarChar).Value = prix;

                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;


                cmd.ExecuteNonQuery();
                con.Close();

            }



        }


        //delete


        public void Delete_data()
        {

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {

                cmd.CommandText = "DELETE  FROM `medicament` WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;


                cmd.ExecuteNonQuery();
                con.Close();

            }



        }



        //get all


        public void Read_data()
        {
            dt.Clear();
            string query = "SELECT * FROM `medicament`";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(ds);
            dt = ds.Tables[0];

        }


    }





    class ACTUALITE : Connect

    {

        public string titre { set; get; }
        public string   text { set; get; }


        public string id { set; get; }

        //read proprite

        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();




        //create function

        public void Create_data()
        {

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {

                cmd.CommandText = "INSERT INTO `actualite`(`titre`, `text`) VALUES (@titre,@text)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.Add("@titre", MySqlDbType.VarChar).Value = titre;
                cmd.Parameters.Add("@text", MySqlDbType.VarChar).Value = text;

                cmd.ExecuteNonQuery();
                con.Close();

            }
        }


        //update 

        public void Update_data()
        {

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {

                cmd.CommandText = "UPDATE `actualite` SET `titre`=@titre,`text`=@text WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.Add("@titre", MySqlDbType.VarChar).Value = titre;
                cmd.Parameters.Add("@text", MySqlDbType.VarChar).Value = text;

                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;


                cmd.ExecuteNonQuery();
                con.Close();

            }



        }


        //delete


        public void Delete_data()
        {

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {

                cmd.CommandText = "DELETE  FROM `actualite` WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;


                cmd.ExecuteNonQuery();
                con.Close();

            }



        }



        //get all


        public void Read_data()
        {
            dt.Clear();
            string query = "SELECT * FROM `actualite`";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(ds);
            dt = ds.Tables[0];

        }


    }

   

    class CONTACT : Connect

    {

        public string name { set; get; }
      
        public string email { set; get; }

        public string message { set; get; }


        public string id { set; get; }

        //read proprite

        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();




        //create function

        public void Create_data()
        {

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {

                cmd.CommandText = "INSERT INTO `contact`(`name`, `email`, `message`) VALUES (@name,@email,@message)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
               


                cmd.Parameters.Add("@message", MySqlDbType.VarChar).Value = message;


                cmd.ExecuteNonQuery();
                con.Close();

            }
        }


        //update 

        public void Update_data()
        {

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {

                cmd.CommandText = "UPDATE `contact` SET `name`=@name,`email`=@email,`message`=@message  WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;


                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
             
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;


                cmd.Parameters.Add("@message", MySqlDbType.VarChar).Value = message;

                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;


                cmd.ExecuteNonQuery();
                con.Close();

            }



        }


        //delete


        public void Delete_data()
        {

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {

                cmd.CommandText = "DELETE  FROM `contact` WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;


                cmd.ExecuteNonQuery();
                con.Close();

            }



        }



        //get all


        public void Read_data()
        {
            dt.Clear();
            string query = "SELECT * FROM `contact`";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(ds);
            dt = ds.Tables[0];

        }


    }


    class DOCTEUR : Connect

    {

        public string name { set; get; }

        public string specialite { set; get; }

      
        public string id { set; get; }

        //read proprite

        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();




        //create function

        public void Create_data()
        {

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {

                cmd.CommandText = "INSERT INTO `docteur`(`name`, `specialite`) VALUES (@name,@specialite)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@specialite", MySqlDbType.VarChar).Value = specialite;




                cmd.ExecuteNonQuery();
                con.Close();

            }
        }


        //update 

        public void Update_data()
        {

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {

                cmd.CommandText = "UPDATE `docteur` SET `name`=@name,`specialite`=@specialite  WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;


                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@specialite", MySqlDbType.VarChar).Value = specialite;

                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;


                cmd.ExecuteNonQuery();
                con.Close();

            }



        }


        //delete


        public void Delete_data()
        {

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {

                cmd.CommandText = "DELETE  FROM `docteur` WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;


                cmd.ExecuteNonQuery();
                con.Close();

            }



        }



        //get all


        public void Read_data()
        {
            dt.Clear();
            string query = "SELECT * FROM `docteur`";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(ds);
            dt = ds.Tables[0];

        }


    }



}
