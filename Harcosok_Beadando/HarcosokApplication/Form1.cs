using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarcosokApplication
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();

            conn = new MySqlConnection("Server=localhost;Database=cs_harcosok;Uid=root;Pwd=");

            conn.Open();

            AdatFrissit();
        }


        void AdatFrissit()
        {
            listBox2Kepessegek.Items.Clear();
            listBox1Harcosok.Items.Clear();
            comboBox1Kepesseghasznaloja.Items.Clear();

            var command = conn.CreateCommand();
            command.CommandText = @"
                    SELECT  nev, letrehozas 
                    FROM harcosok 
                    ORDER BY letrehozas, nev
                ";
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string nev = reader.GetString("nev");
                    DateTime letrehozas = reader.GetDateTime("letrehozas");
                    string sor = string.Format("{1:yyyy. MM. dd.}: {0}", nev, letrehozas);
                    listBox1Harcosok.Items.Add(sor);
                    comboBox1Kepesseghasznaloja.Items.Add(nev);
                }
            }
            /*
            var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                    SELECT  nev, fajta, orokbefogadas_datum 
                    FROM kutyak 
                    ORDER BY orokbefogadas_datum, nev
                ";

            var dt = new DataTable();
            var adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            dt.TableNewRow += (sender, e) =>
            {
                var nev = e.Row["nev"];
                var fajta = e.Row["fajta"];
                var datum = e.Row["orokbefogadas_datum"];

                var InsertCmd = conn.CreateCommand();
                command.CommandText = @"INSERT INTO kutyak
                    (nev, fajta, orokbefogadas_datum)
                    VALUES
                    (@nev, @fajta, @orokbe)
                ";
                command.Parameters.AddWithValue("@nev", nev);
                command.Parameters.AddWithValue("@fajta", fajta);
                command.Parameters.AddWithValue("@orokbe", datum);
                command.ExecuteNonQuery();
                try
                {
                    InsertCmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    e.Row.RowError = "Hibás adat!";
                    return;
                }

            };

            dt.ColumnChanged += (sender, e) =>
            {
                //var onev = e.Column.ColumnName;
                var id = e.Row["id"];
                //if (onev == "nev")
                //{
                var UpdateCommand = conn.CreateCommand();
                UpdateCommand.CommandText = @"
                    UPDATE kutyak SET  fajta = @fajta, orokbefogadas_datum = @datum WHERE id = @id
                ";
                UpdateCommand.Parameters.AddWithValue("@nev", e.Row["nev"]);
                UpdateCommand.Parameters.AddWithValue("@fajta", e.Row["fajta"]);
                UpdateCommand.Parameters.AddWithValue("@orokbe", e.Row["orokbefogadas_datum"]);
                UpdateCommand.Parameters.AddWithValue("@id", id);
                UpdateCommand.ExecuteNonQuery();
                //}


            };*/
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1Letrehozas_Click(object sender, EventArgs e)
        {
            string nev = textBox1HarcosNeve.Text;
            DateTime letrehozas = DateTime.Now;

            var lekerdezesCommand = conn.CreateCommand();
            lekerdezesCommand.CommandText = @"
                    SELECT COUNT(*) FROM harcosok WHERE nev = @nev
                ";
            lekerdezesCommand.Parameters.AddWithValue("@nev", nev);
            long db = (long)lekerdezesCommand.ExecuteScalar();
            if (db > 0)
            {
                MessageBox.Show("Ilyen harcos mar van");
                return;
            }

            var command = conn.CreateCommand();
            command.CommandText = @"INSERT INTO harcosok
                    (nev, letrehozas)
                    VALUES
                    (@nev, @letrehozas)
                ";
            command.Parameters.AddWithValue("@nev", nev);
            command.Parameters.AddWithValue("@letrehozas", letrehozas);
            command.ExecuteNonQuery();
            AdatFrissit();
        }

        private void button2Hozzaadas_Click(object sender, EventArgs e)
        {
            string nev = comboBox1Kepesseghasznaloja.Text;
            string kepnev = textBox2KepessegNeve.Text;
            string leiras = textBox3KepessegLeirasa.Text;
            int harcosId;

            var idKeresesCommand = conn.CreateCommand();
            idKeresesCommand.CommandText = @"
                    SELECT id FROM harcosok where nev = @nev 
                ";
            idKeresesCommand.Parameters.AddWithValue("@nev", nev);

            /*
            using (var reader = idKeresesCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    //harcosId = reader.GetInt32(0);
                }
            }
            
            MySqlDataReader myReader;
            myReader = idKeresesCommand.ExecuteReader();
            while (myReader.Read())
            {
                harcosId = myReader.GetInt32(0);
            }*/


            harcosId = (int)idKeresesCommand.ExecuteScalar();

            var lekerdezesCommand = conn.CreateCommand();
            lekerdezesCommand.CommandText = @"
                    SELECT COUNT(*) FROM kepessegek WHERE nev = @kepnev
                ";

            lekerdezesCommand.Parameters.AddWithValue("@kepnev", kepnev);
            long db = (long)lekerdezesCommand.ExecuteScalar();
            if (db > 0)
            {
                MessageBox.Show("Ilyen képesség mar van");
                return;
            }

            var command = conn.CreateCommand();
            command.CommandText = @"INSERT INTO `kepessegek` 
                    (`id`, `nev`, `leiras`, `harcos_id`) 
                    VALUES (@kepnev, @leiras, @harcosId);
                ";
            command.Parameters.AddWithValue("@kepnev", nev);
            command.Parameters.AddWithValue("@leiras", leiras);
            command.Parameters.AddWithValue("@harcosId", Convert.ToInt32(harcosId));
            command.ExecuteNonQuery();
            AdatFrissit();
        }

        private void listBox1Harcosok_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2Kepessegek.Items.Clear();

            var command = conn.CreateCommand();
            command.CommandText = @"
                    SELECT  nev 
                    FROM kepessegek 
                    ORDER BY nev
                ";
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string nev = reader.GetString("nev");
                    string sor = string.Format("{0}", nev);
                    listBox2Kepessegek.Items.Add(sor);
                }
            }
        }

        private void listBox2Kepessegek_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kepnev = listBox2Kepessegek.Text;
            var command = conn.CreateCommand();
            command.CommandText = @"
                    SELECT  leiras 
                    FROM kepessegek WHERE nev = @kepnev
                    ORDER BY nev
                ";
            command.Parameters.AddWithValue("@kepnev", kepnev);

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    textBox4KepessegModositasa.Text = reader.GetString("kepnev");
                }
            }
        }
    }
}
