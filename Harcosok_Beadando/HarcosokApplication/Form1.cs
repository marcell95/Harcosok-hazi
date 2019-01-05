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

        private int harcosId;

        void AdatFrissit()
        {

            comboBox1Kepesseghasznaloja.Text = "";
            textBox2KepessegNeve.Text = "";
            textBox3KepessegLeirasa.Text = "";
            listBox2Kepessegek.Items.Clear();
            listBox1Harcosok.Items.Clear();
            comboBox1Kepesseghasznaloja.Items.Clear();
            textBox4KepessegModositasa.Text = "";

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
                    string sor = string.Format("{1:$yyyy. MM. dd.}: {0}", nev, letrehozas);
                    listBox1Harcosok.Items.Add(sor);
                    comboBox1Kepesseghasznaloja.Items.Add(nev);
                }
            }
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
            string kepnev = textBox2KepessegNeve.Text;
            string leiras = textBox3KepessegLeirasa.Text;
            string nev = comboBox1Kepesseghasznaloja.Text;

            var idKeresesCommand = conn.CreateCommand();
            idKeresesCommand.CommandText = @"
                    SELECT id FROM harcosok where nev = @nev 
                ";
            idKeresesCommand.Parameters.AddWithValue("@nev", nev);

            
            using (var reader = idKeresesCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    //harcosId = reader.GetInt32(0);

                    harcosId = int.Parse(reader["id"].ToString());

                    MessageBox.Show("A harcos idja: "+harcosId);
                }
            }
            /*
            MySqlDataReader myReader;
            myReader = idKeresesCommand.ExecuteReader();
            while (myReader.Read())
            {
                harcosId = myReader.GetInt32(0);
            }*/

            //harcosId = (int)idKeresesCommand.ExecuteScalar();

            var lekerdezesCommand = conn.CreateCommand();
            lekerdezesCommand.CommandText = @"
                    SELECT COUNT(*) FROM kepessegek WHERE nev = @kepnev
                ";

            lekerdezesCommand.Parameters.AddWithValue("@kepnev", kepnev);
            long db = (long)lekerdezesCommand.ExecuteScalar();
            if (db > 0)
            {
                MessageBox.Show("Ilyen képesség már van");
                return;
            }

            var command = conn.CreateCommand();
            command.CommandText = @"INSERT INTO `kepessegek` 
                    (`id`, `nev`, `leiras`, `harcos_id`) 
                    VALUES (NULL, @kepnev, @leiras, @harcosId);
                ";
            command.Parameters.AddWithValue("@kepnev", kepnev);
            command.Parameters.AddWithValue("@leiras", leiras);
            command.Parameters.AddWithValue("@harcosId", harcosId);
            command.ExecuteNonQuery();
            AdatFrissit();
        }

        private void listBox1Harcosok_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2Kepessegek.Items.Clear();
            
            string nevNyers = listBox1Harcosok.Text;
            
            // Remove a substring from the middle of the string.
            string toRemove = "$";
            string nev = string.Empty;
            int i = nevNyers.IndexOf(toRemove);
            if (i >= 0)
            {
                nev = nevNyers.Remove(i, 16);
            }

            //MessageBox.Show("A név: " + nev + "\nA volt név: " + nevNyers);


            var idKeresesCommand = conn.CreateCommand();
            idKeresesCommand.CommandText = @"
                    SELECT id FROM harcosok where nev = @nev
                    ";

            idKeresesCommand.Parameters.AddWithValue("@nev", nev);


            using (var reader = idKeresesCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    //harcosId = reader.GetInt32(0);

                    harcosId = int.Parse(reader["id"].ToString());

                    //MessageBox.Show("A harcos idja: " + harcosId);
                }
            }

            var command = conn.CreateCommand();
            command.CommandText = @"
                    SELECT nev
                    FROM kepessegek 
                    WHERE harcos_id = @harcosId
                    ORDER BY nev
                ";
            command.Parameters.AddWithValue("@harcosId", harcosId);

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string kepnev = reader.GetString("nev");
                    string sor = string.Format("{0}", kepnev);
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
                    textBox4KepessegModositasa.Text = reader.GetString("leiras");
                }
            }
        }

        private void button3Modositas_Click(object sender, EventArgs e)
        {
            string kepnev = listBox2Kepessegek.Text;
            var command = conn.CreateCommand();
            command.CommandText = @"
                    UPDATE kepessegek SET leiras = @leiras WHERE nev = @kepnev
                ";
            command.Parameters.AddWithValue("@leiras", textBox4KepessegModositasa.Text);
            command.Parameters.AddWithValue("@kepnev", kepnev);
            int sorok = command.ExecuteNonQuery();
            if (sorok == 0)
            {
                MessageBox.Show("Nincs ilyen nevű képesség.");
            }

            AdatFrissit();
        }

        private void button4Torles_Click(object sender, EventArgs e)
        {
            string kepnev;
            if (listBox2Kepessegek.Text == "")
            {
                MessageBox.Show("Nincs képesség kijelölve.");
            } else
            {
                kepnev = listBox2Kepessegek.Text;
                var command = conn.CreateCommand();
                command.CommandText = @"
                    DELETE FROM kepessegek WHERE nev = @kepnev
                ";
                command.Parameters.AddWithValue("@kepnev", kepnev);
                command.ExecuteNonQuery();

                AdatFrissit();
            }

            
        }
    }
}
