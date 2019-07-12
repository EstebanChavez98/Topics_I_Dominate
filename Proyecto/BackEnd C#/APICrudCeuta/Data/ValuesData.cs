using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;

namespace APICrudCeuta.Data
{
    public class ValuesData
    {
        Conexion con = new Conexion();
        public string GuardarDatosPersona(string _nombre, string _depto, string _persona, string _ip, int _horas)
        {
            string request, patternIP = @"\b((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b";
            SqlConnection conection = new SqlConnection(con.conexionDESK);
            if (!(string.IsNullOrWhiteSpace(_nombre) || string.IsNullOrWhiteSpace(_depto) || string.IsNullOrWhiteSpace(_persona) || string.IsNullOrWhiteSpace(_ip) || _horas == 0))
            {
                Match match = Regex.Match(_ip, patternIP);
                if (match.Success)
                {
                    string sql = "sp_agregarUsuario";
                    SqlCommand cmd = new SqlCommand(con.conexionDESK, conection);
                    conection.Open();

                    cmd.Parameters.AddWithValue("@nom", _nombre);
                    cmd.Parameters.AddWithValue("@depto", _depto);
                    cmd.Parameters.AddWithValue("@persona", _persona);
                    cmd.Parameters.AddWithValue("@ip", _ip);
                    cmd.Parameters.AddWithValue("@horas", _horas);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = sql;
                    cmd.Connection = conection;

                    request = cmd.ExecuteNonQuery() == -1 ? "La direccion IP escrita ya fue registrada" : "Registro Exitoso, ";

                    conection.Close();
                    if (request != "La direccion IP escrita ya fue registrada")
                    {
                        if (!(Directory.Exists(@"C:\\Datos")))
                        {
                            Directory.CreateDirectory(@"C:\\Datos");
                            request += "Se creo la carpeta Datos, ";
                        }
                        StreamWriter sw = new StreamWriter(@"C:\\Datos\\Direcciones.txt", true);
                        sw.WriteLine(_ip);
                        sw.Close();
                        request += "La IP: " + _ip + " se guardo";
                    }
                }
                else
                {
                    request = "La Sintaxis de la direccion IP es incorrecta";
                }
            }
            else
            {
                request = "Tienes un dato vacio";
            }
            return request;
        }

        public string ModificarIP(string _nombre, string _ip)
        {
            string respuestaBD, anteriorIP="", patternIP = @"\b((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b";
            SqlConnection conection = new SqlConnection(con.conexionDESK);
            if (!(string.IsNullOrWhiteSpace(_nombre) || string.IsNullOrWhiteSpace(_ip)))
            {
                Match match = Regex.Match(_ip, patternIP);
                if (match.Success)
                {
                    SqlDataReader lector = null;
                    string sql = "sp_modificarIP";
                    SqlCommand cmd = new SqlCommand(con.conexionDESK, conection);
                    conection.Open();

                    cmd.Parameters.AddWithValue("@nom", _nombre);
                    cmd.Parameters.AddWithValue("@ip", _ip);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = sql;
                    cmd.Connection = conection;
                    lector = cmd.ExecuteReader();


                    respuestaBD = lector.HasRows ? "No se encontro ningun dato" : "Modificacion exitosa en la Base de datos";
                    if(respuestaBD != "No se encontro ningun dato")
                    {
                        if (lector.HasRows)
                        {
                            while (lector.Read())
                            {
                                anteriorIP = lector.GetValue(0).ToString();
                            }
                        }
                        ModificarIPText(_ip, anteriorIP);
                    }
                    conection.Close();
                }
                else
                {
                    respuestaBD = "La sintaxis de la direccion IP es incorrecta";
                }
            }
            else
            {
                respuestaBD = "Tienes algun dato vacio";
            }
            return respuestaBD;
        }
        
        public void ModificarIPText(string ip, string anteriorIP)
        {
            
        }
    }
}
