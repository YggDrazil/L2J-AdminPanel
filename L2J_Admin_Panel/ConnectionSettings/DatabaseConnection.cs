using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L2J_Admin_Panel.ConnectionSettings
{
    class DatabaseConnection
    {
        /*
            CTR + R + E (Generate setter + getter) *Mark variable name firstly
        */
        /*
            Connection variables for login server
        */
        private String login_server_Hostname;
        private String login_server_Username;
        private String login_server_Password;
        private String login_server_Database;
        /*
            Connection variables for game server
        */
        private String game_server_Hostname;
        private String game_server_Username;
        private String game_server_Password;
        private String game_server_Database;
        /*
            Connection strings
        */
        private String LoginServerconnectionString;
        private String GameServerconnectionString;
        /*
            MySQL Connector object
        */
        private MySqlConnection connection;


        /*
            Default constructor call initializeConnection
        */
        public DatabaseConnection()
        {
            Connection = new MySqlConnection();
            initializeConnection();
        }

        /*
            Initialize connection variables class
        */
        public void initializeConnection()
        {
            
            if (Properties.Settings.Default.LoginServerConnectionString.ToString() != "" && Properties.Settings.Default.GameServerConnectionString.ToString() != "")
            {
                /*
                    Set 2 connections
                */
                LoginServerconnectionString1 = Properties.Settings.Default.LoginServerConnectionString;
                GameServerconnectionString1 = Properties.Settings.Default.GameServerConnectionString;

                /*
                    Split variables to arrays
                */
                String[] login_server_variables = LoginServerconnectionString1.Split(';');
                String[] game_server_variables = GameServerconnectionString1.Split(';');

                /*
                    Set Variables
                */
                Login_server_Hostname = login_server_variables[0].Substring(login_server_variables[0].IndexOf('=') + 1);
                Login_server_Username = login_server_variables[1].Substring(login_server_variables[1].IndexOf('=') + 1);
                Login_server_Password = login_server_variables[2].Substring(login_server_variables[2].IndexOf('=') + 1);
                Login_server_Database = login_server_variables[3].Substring(login_server_variables[3].IndexOf('=') + 1);

                Game_server_Hostname = game_server_variables[0].Substring(login_server_variables[0].IndexOf('=') + 1);
                Game_server_Username = game_server_variables[1].Substring(login_server_variables[1].IndexOf('=') + 1);
                Game_server_Password = game_server_variables[2].Substring(login_server_variables[2].IndexOf('=') + 1);
                Game_server_Database = game_server_variables[3].Substring(login_server_variables[3].IndexOf('=') + 1);
            }
        }
        /*
            If we can connect
        */
        public Boolean canConnect(int database_index )
        {
            try
            {
                /*
                    Login Server
                */
                if (database_index == 0)
                {
                    /*
                        Empty connection
                    */
                    if (LoginServerconnectionString1 != "")
                    {
                        /*
                           Set login server connection String
                           and try to connect
                        */
                        Connection.ConnectionString = LoginServerconnectionString1;
                        Connection.Open();
                        Connection.Close();
                        /*
                            Connected so true
                        */
                        return true;
                    }
                }
                /*
                    Game Server
                */
                else if (database_index == 1)
                {
                    /*
                        Empty connection
                    */
                    if (GameServerconnectionString1 != "")
                    {
                        /*
                            Set game server connection String
                            and try to connect
                        */
                        Connection.ConnectionString = GameServerconnectionString1;
                        Connection.Open();
                        Connection.Close();
                        /*
                            Connected so true
                        */
                        return true;
                    }
                }
                /*
                    Else false
                */
                return false;       

            }
            catch (Exception ex)
            {
                /*
                    Cant connect so false
                */
                // Console.WriteLine(ex.Message);
                return false;
            }
        }
        /*
            Setter & Getter
        */
        public string Login_server_Hostname
        {
            get
            {
                return login_server_Hostname;
            }

            set
            {
                login_server_Hostname = value;
            }
        }

        public string Login_server_Username
        {
            get
            {
                return login_server_Username;
            }

            set
            {
                login_server_Username = value;
            }
        }

        public string Login_server_Password
        {
            get
            {
                return login_server_Password;
            }

            set
            {
                login_server_Password = value;
            }
        }

        public string Login_server_Database
        {
            get
            {
                return login_server_Database;
            }

            set
            {
                login_server_Database = value;
            }
        }

        public string Game_server_Hostname
        {
            get
            {
                return game_server_Hostname;
            }

            set
            {
                game_server_Hostname = value;
            }
        }

        public string Game_server_Username
        {
            get
            {
                return game_server_Username;
            }

            set
            {
                game_server_Username = value;
            }
        }

        public string Game_server_Password
        {
            get
            {
                return game_server_Password;
            }

            set
            {
                game_server_Password = value;
            }
        }

        public string Game_server_Database
        {
            get
            {
                return game_server_Database;
            }

            set
            {
                game_server_Database = value;
            }
        }

        public string LoginServerconnectionString1
        {
            get
            {
                return LoginServerconnectionString;
            }

            set
            {
                LoginServerconnectionString = value;
            }
        }

        public string GameServerconnectionString1
        {
            get
            {
                return GameServerconnectionString;
            }

            set
            {
                GameServerconnectionString = value;
            }
        }

        public MySqlConnection Connection
        {
            get
            {
                return connection;
            }

            set
            {
                connection = value;
            }
        }
    }
}
