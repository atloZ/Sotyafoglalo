using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Xml;

namespace Sotyafoglalo
{
    class DataBaseHelper
    {
        #region Változok
        private static readonly string connString = "Server=localhost;Port=3306;Database=sotyafoglalo_db;Uid=Sotyafoglalo;Pwd=pin;";
        private static MySqlConnection conn = null;
        private static MySqlCommand cmd = null;
        #endregion

        #region csatlakozás és tábla teszt
        private static string getConnString()
        {
            string s = "";
            using (XmlReader reader = XmlReader.Create(@"database_con_adat.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        //return only when you have START tag  
                        switch (reader.Name.ToString())
                        {
                            case "Server":
                                s += "Server=" + reader.ReadContentAsString() + ";";
                                break;
                            case "Port":
                                s += "Port=" + reader.ReadContentAsString() + ";";
                                break;
                            case "Database":
                                s += "Database=" + reader.ReadContentAsString() + ";";
                                break;
                            case "Uid":
                                s += "Uid=" + reader.ReadContentAsString() + ";";
                                break;
                            case "Pwd":
                                s += "Pwd=" + reader.ReadContentAsString() + ";";
                                break;
                        }
                    }
                }
            }
            
            return s;
        }   //hiányos

        public static Boolean csatlakozas()
        {
            try
            {
                //conn = new MySqlConnection(getConnString());
                conn = new MySqlConnection(connString);
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
                    tablaVanE("tippkerdes") == true &&
                    tablaVanE("csapat") == true &&
                    tablaVanE("meccs") == true &&
                    tablaVanE("kor") == true
                        ? true : false;
            }
            catch (Exception)
            {
                throw new Exception("hiba a táblák tesztelése során");
            }
        }
        #endregion

        #region adatfelvétel
        public static int addUjMeccs()
        {
            int id = -1;
            try
            {
                cmd = new MySqlCommand("call UjMeccs()", conn);
                id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception e)
            {
                throw new Exception("Meccs létrehozási hiba");
            }
            return id;
        }

        public static void addUjKerdes(string kerdes, string[] valasz)
        {
            switch (valasz.Length)
            {
                case 1:
                    {
                        cmd = new MySqlCommand(
                            @"INSERT INTO `tippkerdes`" +
                            "(" +
                                "`kerdes`, " +
                                "`valasz`" +
                            ") " +
                            "VALUES " +
                            "(" +
                                "@kerdes," +
                                "@valasz" +
                            ")", conn);

                        cmd.Parameters.AddWithValue("@kerdes", kerdes);
                        cmd.Parameters.AddWithValue("@valasz", valasz[0]);
                        cmd.ExecuteNonQuery();
                    }
                    break;
                case 4:
                    {
                        cmd = new MySqlCommand(
                            @"CALL addKerdesWithValasz(" +
                                "@kerdes, " +
                                "@hvalasz, " +
                                "@valasz2, " +
                                "@valasz3, " +
                                "@valasz4" +
                            ")", conn);

                            cmd.Parameters.AddWithValue("@kerdes", kerdes);
                            cmd.Parameters.AddWithValue("@hvalasz", valasz[0]);
                            cmd.Parameters.AddWithValue("@valasz2", valasz[1]);
                            cmd.Parameters.AddWithValue("@valasz3", valasz[2]);
                            cmd.Parameters.AddWithValue("@valasz4", valasz[3]);
                            cmd.ExecuteNonQuery();
                    }
                    break;
                default:
                    throw new Exception("Hibás kérdésfelvétel, probálja ujra!");
            }
        }

        public static int addUjKor(int kerdesId, int tamadoCsapatId, int vedekezoCsapatId)
        {
            int korId = -1;
            try
            {
                cmd = new MySqlCommand(
                    "call creatUjKor(@kerdesId, @tcsapatId, @vcsapatId);",
                conn);

                cmd.Parameters.AddWithValue("@kerdesId", kerdesId);
                cmd.Parameters.AddWithValue("@tcsapatId", tamadoCsapatId);
                cmd.Parameters.AddWithValue("@vcsapatId", vedekezoCsapatId);
                korId = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Hiba történt a kör létrehozása során");
            }

            return korId;
        }
        
        public static void addUjCsapat(string nev, int pont, int meccsId)
        {
            try
            {
                cmd = new MySqlCommand(
                    @"INSERT INTO `csapat`" +
                    "(" +
                        "`nev`, " +
                        "`elertPont`, " +
                        "`meccs_id`" +
                    ") " +
                    "VALUES " +
                    "(" +
                        "@nev," +
                        "@pont," +
                        "@meccs_id" +
                    ")"
                    , conn);

                cmd.Parameters.AddWithValue("@nev", nev);
                cmd.Parameters.AddWithValue("@pont", pont);
                cmd.Parameters.AddWithValue("@meccs_id", meccsId);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException e) { }
        }
        
        public static void addTamadoCsapatValasz(int korId, int tamadoValaszId)
        {
            try
            {
                cmd = new MySqlCommand(
                    "UPDATE `kor` " +
                    "SET `tamadoCsapat_valasz_id`= @tamadoValaszId " +
                    "WHERE `id` = @korId;",
                conn);

                cmd.Parameters.AddWithValue("@korId", korId);
                cmd.Parameters.AddWithValue("@tamadoValaszId", tamadoValaszId);
                korId = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Hiba történt a támadó csapat válasza rögzitése közben");
            }
        }
        
        public static void addVedekezoCsapatValasz(int korId, int vedoValaszId)
        {
            try
            {
                cmd = new MySqlCommand(
                    "UPDATE `kor` " +
                    "SET `vedekezoCsapat_valasz_id`= @vedekezoValaszId " +
                    "WHERE `id` = @korId;",
                conn);

                cmd.Parameters.AddWithValue("@korId", korId);
                cmd.Parameters.AddWithValue("@vedekezoValaszId", vedoValaszId);
                korId = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Hiba történt a támadó csapat válasza rögzitése közben");
            }
        }
        #endregion

        #region adatlekérdezések
        public static string[] getCsapatokNeve(int meccsId)
        {
            List<string> csapatNevek = new List<string>();
            try
            {
                cmd = new MySqlCommand(
                    "SELECT `nev` " +
                    "FROM `csapat` " +
                    "WHERE `meccs_id` = @meccsId"
                , conn);

                cmd.Parameters.AddWithValue("@csapatId", meccsId);
                using (var myReader = cmd.ExecuteReader())
                {
                    int index = 0;
                    while (myReader.Read())
                    {
                        csapatNevek[index] = myReader.GetString(0);
                        index++;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return csapatNevek.ToArray();
        }
        
        public static string getCsapatNeve(int csapatId)
        {
            cmd = new MySqlCommand(
                "SELECT `nev` " +
                "FROM `csapat` " +
                "WHERE `id` = @csapatId", 
                conn);

            cmd.Parameters.AddWithValue("@csapatId", csapatId);
            return cmd.ExecuteScalar().ToString();
        }
        
        public static int getUjKerdesId(int meccsId)
        {
            int ujKerdesId;

            try
            {
                cmd = new MySqlCommand("call getKovetkezoKerdes(@meccsId)", conn);

                cmd.Parameters.AddWithValue("@meccsId", meccsId);
                ujKerdesId = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("nem található új kerdés ehhez a meccshez");
            }

            return ujKerdesId;
        }

        public static string getKerdesString(int Id)
        {
            string s = "";
            try
            {
                cmd = new MySqlCommand(
                    "SELECT `kerdes` " +
                    "FROM `kerdesek` " +
                    "WHERE `id`= @kerdesId", conn);
                cmd.Parameters.AddWithValue("@kerdesId", Id);
                cmd.ExecuteNonQuery();
                s = (cmd.ExecuteScalar()).ToString();
            }
            catch (Exception)
            {
                throw;
            }
            return s;
        }

        public static string[] getValaszok(int kerdesId)
        {
            string[] valaszok = new string[4];
            
            try
            {
                cmd = new MySqlCommand(
                    "SELECT `valasz` " +
                    "FROM `valaszok` " +
                    "WHERE `kerdes_id` = @kerdesId " +
                    "ORDER BY RAND();"
                , conn);

                cmd.Parameters.AddWithValue("@kerdesId", kerdesId);
                cmd.ExecuteNonQuery();

                using (var myReader = cmd.ExecuteReader())
                {
                    int index = 0;
                    while (myReader.Read())
                    {
                        valaszok[index] = myReader.GetString(0);
                        index++;
                    }
                }
            }
            catch (Exception e){}

            return valaszok;
        }

        public static string getKerdesHelyesValasza(int kerdesId)
        {
            string s = "";
            try
            {
                cmd = new MySqlCommand(
                    "SELECT `valasz` " +
                    "FROM valaszok " +
                    "WHERE `kerdes_id` = @kerdesId " +
                        "and `valaszHelyesE` = true;"
                , conn);

                cmd.Parameters.AddWithValue("@kerdesId", kerdesId);
                cmd.ExecuteNonQuery();
                s = (cmd.ExecuteScalar()).ToString();
            }
            catch (Exception)
            {
                throw;
            }

            return s;
        }

        public static void csapatPontFrisites(string csapatnev, int pont)
        {
            try
            {
                cmd = new MySqlCommand(
                    "UPDATE `csapat` " +
                    "SET `elertPont`= @pont " +
                    "WHERE `nev`= @csapatnev"
                , conn);

                cmd.Parameters.AddWithValue("@csapatnev", csapatnev);
                cmd.Parameters.AddWithValue("@pont", pont);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Sikertelen csapat pont frisités");
            }
        }
        #endregion
    }
}