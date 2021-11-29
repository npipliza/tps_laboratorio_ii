using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public class ControllerDAO
    {
        private static string connectionStr;
        private static SqlConnection conexion;
        private static SqlCommand comando;
        public static int[] idBInventariosInformes;
        public static int[] idBInventariosDepositos;

        private static void Conectarse()
        {
            connectionStr = " Server = localhost ; Database = Tp4_Pipliza; Trusted_Connection = true ; ";
            conexion = new SqlConnection(connectionStr);
            comando = new SqlCommand
            {
                CommandType = CommandType.Text,
                Connection = conexion
            };
        }

        #region Lectura
        /// <summary>
        /// Lectura de inventarios
        /// </summary>
        /// <param name="listaInventarios"></param>
        public static void LeerInventarios(List<Inventario> listaInventarios)
        {
            listaInventarios.Clear();
            Conectarse();
            try
            {
                Inventario inventario;
                conexion.Open();
                comando.CommandText = "SELECT * FROM dbo.inventarios";
                SqlDataReader myReader = comando.ExecuteReader();

                while (myReader.Read())
                {
                    inventario = new Inventario(myReader["MARCA_PAPEL"].ToString(), 
                                               (Inventario.TipoPapel)Enum.Parse(typeof(Inventario.TipoPapel), 
                                               myReader["TIPO_PAPEL"].ToString()), 
                                               Convert.ToInt32(myReader["ID_CLIENTE"]), 
                                               Convert.ToInt32(myReader["ID_INVENTARIO"]));

                    listaInventarios.Add(inventario);
                }
                myReader.Close();
                conexion.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Lectura de informes según lista
        /// </summary>
        /// <param name="informesStock"></param>
        public static void LeerInformes(List<Informes> informesStock)
        {
            Conectarse();
            informesStock.Clear();
            Informes informes;
            conexion.Open();
            comando.CommandText = "SELECT * FROM dbo.informesStock";

            SqlDataReader myReader = comando.ExecuteReader();

            try
            {
                while (myReader.Read())
                {
                    DateTime dateTime = new DateTime();
                    dateTime = (DateTime)myReader["FECHA_CORRECCION"];

                    informes = new Informes(myReader["NOMBRE_INFORME"].ToString(), 
                                            Convert.ToInt32(myReader["GRAMAJE"]), 
                                            myReader["USD"].ToString(), 
                                            myReader["CODIGO"].ToString(), 
                                            Convert.ToInt32(myReader["KG"]), 
                                            dateTime);

                    informesStock.Add(informes);

                    string[] words = ((myReader["ID_INVENTARIOS"]).ToString()).Split(',');
                    int[] idInventariosInformes = new int[words.Length];
                    for (int i = 0; i < words.Length; i++)
                    {
                        idInventariosInformes[i] = Convert.ToInt32(words[i]);
                    }
                    informes.obtenerIdInventarios(idInventariosInformes);
                    Controller.AgregarInformesAInventarios(idInventariosInformes, informes);
                }
            }
            catch (Exception e)
            {
                //throw new ControllerDaoExcepcion("Hubo un error");
                throw e;
            }
            finally
            {
                myReader.Close();
                conexion.Close();
            }

        }
        /// <summary>
        /// Lectura de inforem según tabla
        /// </summary>
        /// <param name="informesStock"></param>
        /// <param name="tabla"></param>
        public static void LeerInformes(List<Informes> informesStock, string tabla)
        {
            Conectarse();
            informesStock.Clear();
            Informes informes;
            conexion.Open();

            string query = $"Select * from {tabla}";
            comando.CommandText = query;
            SqlDataReader myReader = comando.ExecuteReader();

            try
            {
                while (myReader.Read())
                {
                    DateTime dateTime = new DateTime();
                    dateTime = (DateTime)myReader["FECHA_EDICION"];

                    informes = new Informes(myReader["NOMBRE_INFORME"].ToString(),
                                            Convert.ToInt32(myReader["GRAMAJE"]),
                                            myReader["USD"].ToString(),
                                            myReader["CODIGO"].ToString(),
                                            Convert.ToInt32(myReader["KG"]),
                                            dateTime);

                    informesStock.Add(informes);
                }
            }
            catch (Exception e)
            {     
                throw e;
               // throw new ControllerDaoExcepcion("Hubo un error");
            }
            finally
            {
                myReader.Close();
                conexion.Close();
            }

        }
        /// <summary>
        /// Lectura según listado
        /// </summary>
        /// <param name="depositosStock"></param>
        public static void LeerDepositos(List<DepositoP> depositosStock)
        {
            Conectarse();
            depositosStock.Clear();

            DepositoP deposito;
            conexion.Open();
            comando.CommandText = "SELECT * FROM dbo.depositosStock";
            SqlDataReader myReader = comando.ExecuteReader();
            try
            {
                while (myReader.Read())
                {

                    deposito = new DepositoP(Convert.ToInt32(myReader["NRO_RACK"]),
                                            (DepositoP.Formato)Enum.Parse(typeof(DepositoP.Formato), 
                                            myReader["EFORMATO"].ToString()),
                                            myReader["NOMBRE_PAPEL"].ToString(),
                                            Convert.ToInt32(myReader["GRAMAJE"]),
                                            myReader["USD"].ToString(),
                                            myReader["CODIGO"].ToString(),
                                            Convert.ToInt32(myReader["KG"]));

                    depositosStock.Add(deposito);

                    string[] words = ((myReader["ID_INVENTARIOS"]).ToString()).Split(',');
                    int[] idInventariosDepositos = new int[words.Length];
                    for (int i = 0; i < words.Length; i++)
                    {
                        idInventariosDepositos[i] = Convert.ToInt32(words[i]);
                    }
                    deposito.obtenerIdInventarios(idInventariosDepositos);
                    Controller.AgregarDepositosAInventarios(idInventariosDepositos, deposito);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                myReader.Close();
                conexion.Close();
            }
        }
        /// <summary>
        /// Lectura según tabla
        /// </summary>
        /// <param name="depositosStock"></param>
        /// <param name="tabla"></param>
        public static void LeerDepositos(List<DepositoP> depositosStock, string tabla)
        {
            Conectarse();
            depositosStock.Clear();
            DepositoP deposito;
            conexion.Open();
            string query = $"Select * from {tabla}";
            comando.CommandText = query;
            SqlDataReader myReader = comando.ExecuteReader();
            try
            {
                while (myReader.Read())
                {

                    deposito = new DepositoP(Convert.ToInt32(myReader["NRO_RACK"]),
                                            (DepositoP.Formato)Enum.Parse(typeof(DepositoP.Formato), 
                                            myReader["EFORMATO"].ToString()),
                                            myReader["NOMBRE_PAPEL"].ToString(),
                                            Convert.ToInt32(myReader["GRAMAJE"]),
                                            myReader["USD"].ToString(),
                                            myReader["CODIGO"].ToString(),
                                            Convert.ToInt32(myReader["KG"]));

                    depositosStock.Add(deposito);

                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                myReader.Close();
                conexion.Close();
            }
        }
        /// <summary>
        /// Lectura de clientes
        /// </summary>
        /// <param name="listaClientes"></param>
        public static void LeerClientes(List<Clientes> listaClientes)
        {
            listaClientes.Clear();
            Conectarse();
            try
            {
                Clientes cliente;
                conexion.Open();
                comando.CommandText = " SELECT * FROM dbo.clientes ";
                SqlDataReader myReader = comando.ExecuteReader();

                while (myReader.Read())
                {
                    cliente = new Clientes(myReader["NOMBRE_CLIENTE"].ToString(), Convert.ToInt32(myReader["ID_CLIENTE"]));
                    listaClientes.Add(cliente);
                }
                myReader.Close();
                conexion.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #region Guardar
        public static void GuardarInforme(Informes informes, int idInventario, bool estaDuplicado)
        {

            Conectarse();
            conexion.Open();

            if (estaDuplicado == false)
            {
                comando.CommandText = " INSERT INTO [informesStock] ([GRAMAJE], [NOMBRE_INFORME], [USD], [CODIGO], [KG], [FECHA_CORRECCION], [ID_INVENTARIOS]) " + "Values (@GRAMAJE, @NOMBRE_INFORME, @USD, @CODIGO, @KG, @FECHA_CORRECCION, @ID_INVENTARIOS)";
                comando.Parameters.AddWithValue("@GRAMAJE", informes.Gramaje);
                comando.Parameters.AddWithValue("@NOMBRE_INFORME", informes.TipoPapel);
                comando.Parameters.AddWithValue("@USD", informes.USD);
                comando.Parameters.AddWithValue("@CODIGO", informes.Codigo);
                comando.Parameters.AddWithValue("@KG", informes.Kg);
                comando.Parameters.AddWithValue("@FECHA_CORRECCION", informes.FechaCorreccion);
                comando.Parameters.AddWithValue("@ID_INVENTARIOS", idInventario);
                comando.ExecuteNonQuery();
            }
            else
            {
                int idInformes = EncontrarInformesPorId(informes);
                comando.CommandText = " UPDATE [informesStock] SET ID_INVENTARIOS = concat([ID_INVENTARIOS], ', ', @ID_INVENTARIOSS) WHERE ID_INFORMES = @value ";
                comando.Parameters.AddWithValue("@value", idInformes);
                comando.Parameters.AddWithValue("@ID_INVENTARIOSS", idInventario.ToString());
                comando.ExecuteNonQuery();
            }
            conexion.Close();
        }
        public static void GuardarDepositos(DepositoP deposito, int idInventario, bool estaDuplicado)
        {

            Conectarse();
            conexion.Open();
            int idDepositos;

            try
            {
                if (estaDuplicado == false)
                {
                    comando.CommandText = "INSERT INTO [depositosStock] ([GRAMAJE], [NOMBRE_PAPEL], [USD], [CODIGO], [KG], [EFORMATO], [NRO_RACK], [ID_INVENTARIOS])" + "Values (@GRAMAJE, @NOMBRE_PAPEL, @USD, @CODIGO, @KG, @EFORMATO, @NRO_RACK, @ID_INVENTARIOS)";
                    comando.Parameters.AddWithValue("@GRAMAJE", deposito.Gramaje);
                    comando.Parameters.AddWithValue("@NOMBRE_PAPEL", deposito.TipoPapel);
                    comando.Parameters.AddWithValue("@USD", deposito.USD);
                    comando.Parameters.AddWithValue("@CODIGO", deposito.Codigo);
                    comando.Parameters.AddWithValue("@KG", deposito.Kg);
                    comando.Parameters.AddWithValue("@EFORMATO", deposito.EFormato.ToString());
                    comando.Parameters.AddWithValue("@NRO_RACK", deposito.NroRack);
                    comando.Parameters.AddWithValue("@ID_INVENTARIOS", idInventario);
                    comando.ExecuteNonQuery();
                }
                else
                {
                    idDepositos = EncontrarDepositosPorId(deposito);
                    comando.CommandText = "UPDATE [depositosStock] SET ID_INVENTARIOS = concat([ID_INVENTARIOS], ', ', @ID_INVENTARIOSS) WHERE ID_DEPOSITOS = @value";
                    comando.Parameters.AddWithValue("@value", idDepositos);
                    comando.Parameters.AddWithValue("@ID_INVENTARIOSS", idInventario);
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception exe)
            {
                throw new Exception(exe.Message);
            }
            finally
            {
                conexion.Close();

            }
        }
        #endregion

        #region Auxiliares
        /// <summary>
        ///  Busca según el código el ID al que corresponde el objeto.
        /// </summary>
        /// <param name="deposito"></param>
        /// <returns></returns>
        private static int EncontrarDepositosPorId(DepositoP deposito)
        {
            comando.CommandText = "SELECT * FROM dbo.despositosStock WHERE [CODIGO] = @depositoCodigo";
            comando.Parameters.AddWithValue("@depositoCodigo", deposito.Codigo);
            SqlDataReader myReader = comando.ExecuteReader();
            myReader.Read();
            int idDeposito = Convert.ToInt32(myReader["ID_DEPOSITOS"]);
            myReader.Close();
            return idDeposito;
        }
        /// <summary>
        /// Busca según el código el ID al que corresponde el objeto.
        /// </summary>
        /// <param name="informes"></param>
        /// <returns></returns>
        private static int EncontrarInformesPorId(Informes informes)
        {
            comando.CommandText = "SELECT * FROM dbo.informesStock WHERE [CODIGO] = @informeCodigo";
            comando.Parameters.AddWithValue("@informeCodigo", informes.Codigo);
            SqlDataReader myReader = comando.ExecuteReader();
            int idInformes;
            myReader.Read();
            idInformes = Convert.ToInt32(myReader["ID_INFORMES"]);
            myReader.Close();
            return idInformes;
        }
        #endregion
    }
}
