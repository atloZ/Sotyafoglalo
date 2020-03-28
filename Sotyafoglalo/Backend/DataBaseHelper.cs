using MySql.Data.MySqlClient;
using Sotyafoglalo.Backend;
using System;
using System.Collections.Generic;
using System.Xml;

namespace Sotyafoglalo
{
    class DataBaseHelper
    {
        #region Változok
        private static readonly string connString = "Server=localhost;Port=3306;Database=db_sotyafoglalo;Uid=Sotyafoglalo;Pwd=pin;";
        private static MySqlConnection conn = null;
        private static MySqlCommand cmd = null;
        #endregion

        #region Csatlakozás és tábla teszt
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
                    tablaVanE("tippkerdes") == true
                        ? true : false;
            }
            catch (Exception)
            {
                throw new Exception("hiba a táblák tesztelése során");
            }
        }
        #endregion

        #region Funkciók
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
                                System.Windows.Forms.MessageBox.Show(adatok[i].getKerdes()+ adatok[i].getJoValasz()+ adatok[i].getRossz1()+ adatok[i].getRossz2()+ adatok[i].getRossz3());
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
            catch (Exception e)
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
        #endregion
    }
}