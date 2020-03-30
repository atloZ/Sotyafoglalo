using MySql.Data.MySqlClient;
using Sotyafoglalo.Backend;
using System;
using System.Collections.Generic;
using System.IO;

namespace Sotyafoglalo
{
    class DataBaseHelper
    {
        #region Valtozok
        private static MySqlConnection conn = null;
        private static MySqlCommand cmd = null;
        #endregion

        #region Csatlakozas es tabla teszt
        private static string getConnString()
        {
            string serverName = "Server=";
            string portNUmber = "Port=";
            string databaseName = "Database=";
            string userName = "Uid=";
            string passwordValue = "Pwd=";

            string configFile = AppDomain.CurrentDomain.BaseDirectory + "sotyafoglalo.cfg";
            if (File.Exists(configFile))
            {
                foreach (var row in File.ReadAllLines(configFile))
                {
                    Console.WriteLine(row);
                    string input1 = row.Split('=')[0];
                    string input2 = row.Split('=')[1];
                    switch (input1)
                    {
                        case "SERVER":
                            serverName += input2 + ";";
                            break;
                        case "PORT":
                            portNUmber += input2 + ";";
                            break;
                        case "DATABASE":
                            databaseName += input2 + ";";
                            break;
                        case "USER":
                            userName += input2 + ";";
                            break;
                        case "PASSWORD":
                            passwordValue += input2 + ";";
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Nem létezik a config állomány, így default beállításokkal indul a program");
                serverName += "localhost;";
                portNUmber += "3306;";
                databaseName += "db_sotyafoglalo;";
                userName += "Sotyafoglalo;";
                passwordValue += "pin;";
            }

            return serverName + portNUmber + databaseName + userName + passwordValue;
        }

        public static Boolean csatlakozas()
        {
            try
            {
                MySQL_Start();
                conn = new MySqlConnection(getConnString());
                conn.Open();
                tablakTesztelese();
            }
            catch (MySqlException)
            {
                return false;
            }
            return true;
        }

        public static void kapcsolatZaras()
        {
            try
            {
                conn.Close();
                MySQL_Stop();
            }
            catch (Exception)
            {
                throw new Exception("hiba az adatbázis bezárásánál");
            }
        }

        private static Boolean tablaVanE(string tablaNev)
        {
            try
            {
                cmd = new MySqlCommand(@"SELECT * FROM " + tablaNev, conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (MySqlException)
            {
                return false;
            }
            return true;
        }

        private static void tablakTesztelese()
        {
            Boolean tablaOK = false;
            try
            {
                tablaOK =
                    tablaVanE("kerdesek") == true &&
                    tablaVanE("valaszok") == true &&
                    tablaVanE("tippkerdes") == true
                        ? true : false;
            }
            catch (Exception)
            {
                throw new Exception("hiba a táblák tesztelése során");
            }
        }
        #endregion

        #region MySQL szerver
        private static void MySQL_Start()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            string databaseStarterPath = "/C" + AppDomain.CurrentDomain.BaseDirectory + "database\\start.exe";
            startInfo.Arguments = databaseStarterPath;
            process.StartInfo = startInfo;
            process.Start();
        }

        private static void MySQL_Stop()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            string databaseStarterPath = "/C" + AppDomain.CurrentDomain.BaseDirectory + "database\\stop.exe";
            startInfo.Arguments = databaseStarterPath;
            process.StartInfo = startInfo;
            process.Start();
        }

        #endregion

        #region Funkciok
        public static List<Kerdes> getKerdesek()
        {
            List<Kerdes> adatok = new List<Kerdes>();
            try
            {
                cmd = new MySqlCommand(
                    "SELECT k.kerdes, v.valasz, v.valaszHelyesE FROM kerdesek as k LEFT JOIN valaszok as v on k.id = v.kerdes_id ORDER BY k.kerdes;"
                    , conn);

                cmd.ExecuteNonQuery();

                using (var myReader = cmd.ExecuteReader())
                {
                    String kerdes = "";
                    String jovalasz = "";
                    List<String> valaszok = new List<string>();
                    int i = 0;
                    for (int j = 1; j <= 4; j++)
                    {
                        if (myReader.Read())
                        {
                            if (j == 1)
                            {
                                kerdes = myReader.GetString(0);
                            }
                            if (myReader.GetInt32(2) == 1)
                            {
                                jovalasz = myReader.GetString(1);
                            }
                            else
                            {
                                valaszok.Add(myReader.GetString(1));
                            }
                            if (j == 4)
                            {
                                adatok.Add(new Kerdes(kerdes,
                                                  jovalasz,
                                                  valaszok[0],
                                                  valaszok[1],
                                                  valaszok[2],
                                                  i));
                                kerdes = "";
                                jovalasz = "";
                                valaszok = new List<string>();
                                i++;
                                j = 0;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Hiba lépet fel az adatbázis létrehozása közben!");
            }

            return adatok;
        }
        
        public static List<TippKerdes> getTippKerdesek()
        {
            List<TippKerdes> adatok = new List<TippKerdes>();
            try
            {
                cmd = new MySqlCommand(
                    "SELECT `kerdes`, `valasz` FROM `tippkerdes`"
                    , conn);

                cmd.ExecuteNonQuery();

                using (var myReader = cmd.ExecuteReader())
                {
                    int i = 0;
                    while (myReader.Read())
                    {
                        adatok.Add(new TippKerdes(myReader.GetString(0),
                                                Convert.ToInt32(myReader.GetString(1)),
                                                i));
                        i++;
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Hiba lépet fel az adatbázis létrehozása közben!");
            }

            return adatok;
        }

        public static void addUjKerdes(string kerdes, string helyesValasz, string valasz2, string valasz3, string valasz4)
        {
            try
            {
                cmd = new MySqlCommand(
                    "call addKerdesWithValasz(" +
                        "@kerdes, " +
                        "@helyesValasz, " +
                        "@valasz2, " +
                        "@valasz3, " +
                        "@valasz4" +
                    ")", conn);

                cmd.Parameters.AddWithValue("@kerdes", kerdes);
                cmd.Parameters.AddWithValue("@helyesValasz", helyesValasz);
                cmd.Parameters.AddWithValue("@valasz2", valasz2);
                cmd.Parameters.AddWithValue("@valasz3", valasz3);
                cmd.Parameters.AddWithValue("@valasz4", valasz4);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Sikertelen kérdésfelvétel!");
            }
        }
        
        public static void addUjTippKerdes(string kerdes, int Valasz)
        {
            try
            {
                cmd = new MySqlCommand(
                    "INSERT INTO `tippkerdes`(`kerdes`, `valasz`) VALUES (@kerdes, @valasz)", conn);

                cmd.Parameters.AddWithValue("@kerdes", kerdes);
                cmd.Parameters.AddWithValue("@valasz", Valasz);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Sikertelen kérdésfelvétel!");
            }
        }

        public static void removeTippKerdes(string kerdes)
        {
            try
            {
                cmd = new MySqlCommand("DELETE FROM `tippkerdes` WHERE `kerdes` = @kerdes", conn);
                cmd.Parameters.AddWithValue("@kerdes", kerdes);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception("Hibás adattörlés");
            }
        }

        public static void removeKerdes(string kerdes)
        {
            try
            {
                cmd = new MySqlCommand("CALL removeKerdes(@kerdes);", conn);
                cmd.Parameters.AddWithValue("@kerdes", kerdes);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception("Hibás adattörlés");
            }
        }
        #endregion
    }
}