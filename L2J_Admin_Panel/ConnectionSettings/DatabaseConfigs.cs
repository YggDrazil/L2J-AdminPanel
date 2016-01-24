using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using L2J_Admin_Panel.ConnectionSettings;

namespace L2J_Admin_Panel.SettingsForms
{
    public partial class DatabaseConfigs : Form
    {
        public DatabaseConfigs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*
            Check settings given from user
        */
        public StringBuilder checkSettings()
        {
            StringBuilder sb = new StringBuilder("");
            /*
                Check for wrong login server settings
            */
            if (login_server_host_name_textbox.Text.ToString() == "")
            {
                sb.AppendLine("Login Server : Empty HostName");
            }
            if (login_server_username_textbox.Text.ToString() == "")
            {
                sb.AppendLine("Login Server : Empty Username");
            }
            if (login_server_password_textbox.Text.ToString() == "")
            {
                sb.AppendLine("Login Server : Empty Password");
            }
            if (login_server_dbname_textbox.Text.ToString() == "")
            {
                sb.AppendLine("Login Server : Empty Database Name");
            }
            /*
                Check for wrong game server settings
            */
            if (game_server_host_name_textbox.Text.ToString() == "")
            {
                sb.AppendLine("Game Server : Empty HostName");
            }
            if (game_server_username_textbox.Text.ToString() == "")
            {
                sb.AppendLine("Game Server : Empty Username");
            }
            if (game_server_password_textbox.Text.ToString() == "")
            {
                sb.AppendLine("Game Server : Empty Password");
            }
            if (game_server_dbname_textbox.Text.ToString() == "")
            {
                sb.AppendLine("Game Server : Empty Database Name");
            }

            return sb;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            /*
                Check for wrong settings
            */
            StringBuilder sb = checkSettings();
            /*
                If we had errors
            */
            if (sb.ToString() != "")
            {
                MessageBox.Show(sb.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Properties.Settings.Default.LoginServerConnectionString = "server=" + login_server_host_name_textbox.Text.ToString() +
                    ";userId=" + login_server_username_textbox.Text.ToString() + 
                    ";password=" + login_server_password_textbox.Text.ToString() +
                    ";database=" + login_server_dbname_textbox.Text.ToString() + ";";

                Properties.Settings.Default.GameServerConnectionString = "server=" + login_server_host_name_textbox.Text.ToString() +
                    ";userId=" + login_server_username_textbox.Text.ToString() +
                    ";password=" + login_server_password_textbox.Text.ToString() +
                    ";database=" + game_server_dbname_textbox.Text.ToString() + ";";

                Properties.Settings.Default.Save();

                this.Close();

            }
        }

        private void DatabaseConfigs_Load(object sender, EventArgs e)
        {
            DatabaseConnection connection = new DatabaseConnection();
            login_server_host_name_textbox.Text = connection.Login_server_Hostname;
            login_server_username_textbox.Text = connection.Login_server_Username;
            login_server_password_textbox.Text = connection.Login_server_Password;
            login_server_dbname_textbox.Text = connection.Login_server_Database;

            game_server_host_name_textbox.Text = connection.Game_server_Hostname;
            game_server_username_textbox.Text = connection.Game_server_Username;
            game_server_password_textbox.Text = connection.Game_server_Password;
            game_server_dbname_textbox.Text = connection.Game_server_Database;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DatabaseConnection connection = new DatabaseConnection();
            if (connection.canConnect(0))
            {
                MessageBox.Show("Connected successfully to Login Server Database !!!");
            }
            else
            {
                MessageBox.Show("Cant connect to Login Server database", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DatabaseConnection connection = new DatabaseConnection();
            if (connection.canConnect(1))
            {
                MessageBox.Show("Connected successfully to Game Server Database !!!");
            }
            else
            {
                MessageBox.Show("Cant connect to Game Server database", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
