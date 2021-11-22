using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            connectionStr = " Server = localhost ; Database = Pipliza; Trusted_Connection = true ; ";
            conexion = new SqlConnection(connectionStr);
            comando = new SqlCommand
            {
                CommandType = CommandType.Text,
                Connection = conexion
            };
        }

        #region Lectura
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
                    dateTime = (DateTime)myReader["FechaEdicion"];

                    informes = new Informes(myReader["Nombre"].ToString(), Convert.ToInt32(myReader["USD"]), myReader["Gramaje"].ToString(), myReader["Codigo"].ToString(), Convert.ToInt32(myReader["Kg"]), dateTime);

                    informesStock.Add(informes);

                    string[] words = ((myReader["IdDepositos"]).ToString()).Split(',');
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
                throw new ControllerDaoExcepcion("Hubo un error");
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
                    dateTime = (DateTime)myReader["FechaEdicion"];

                    informes = new Informes(myReader["Nombre"].ToString(), Convert.ToInt32(myReader["USD"]), myReader["Gramaje"].ToString(), myReader["Codigo"].ToString(), Convert.ToInt32(myReader["Kg"]), dateTime);

                    informesStock.Add(informes);
                }
            }
            catch (Exception e)
            {
                throw new ControllerDaoExcepcion("Hubo un error");
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

                    deposito = new DepositoP(
                    Convert.ToInt32(myReader["Nro"]),
                    (DepositoP.Formato)Enum.Parse(typeof(DepositoP.Formato), myReader["EFormato"].ToString()),
                    myReader["TipoPapel"].ToString(),
                    Convert.ToInt32(myReader["USD"]),
                    myReader["Gramaje"].ToString(),
                    myReader["Codigo"].ToString(),
                    Convert.ToInt32(myReader["Kg"]));

                    depositosStock.Add(deposito);

                    string[] words = ((myReader["IdInventarios"]).ToString()).Split(',');
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

                    deposito = new DepositoP(
                    Convert.ToInt32(myReader["Nro"]),
                    (DepositoP.Formato)Enum.Parse(typeof(DepositoP.Formato), myReader["EFormato"].ToString()),
                    myReader["TipoPapel"].ToString(),
                    Convert.ToInt32(myReader["NroRack"]),
                    myReader["USD"].ToString(),
                    myReader["Codigo"].ToString(),
                    Convert.ToInt32(myReader["Kg"]));

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
                comando.CommandText = "SELECT * FROM dbo.clientes";
                SqlDataReader myReader = comando.ExecuteReader();

                while (myReader.Read())
                {
                    cliente = new Clientes(myReader["Nombre"].ToString(), Convert.ToInt32(myReader["IdCliente"]));
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
                    inventario = new Inventario(myReader["Nombre Papel"].ToString(), (Inventario.TipoPapel)Enum.Parse(typeof(Inventario.TipoPapel), myReader["Tipo papel"].ToString()), Convert.ToInt32(myReader["ID Cliente"]), Convert.ToInt32(myReader["ID Inventario"]));
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
        #endregion

        #region Guardar
        public static void GuardarInforme(Informes informes, int idInventario, bool estaDuplicado)
        {

            Conectarse();
            conexion.Open();

            if (estaDuplicado == false)
            {
                comando.CommandText = "INSERT INTO [informesStock] ([USD], [Nombre], [Gramaje], [Codigo], [Kg], [FechaEdicion], [IdInventarios])" + "Values (@usd, @nombre, @gramaje, @codigo, @kg, @fechaEdicion, @idInventarios)";
                comando.Parameters.AddWithValue("@usd", informes.USD);
                comando.Parameters.AddWithValue("@nombre", informes.TipoPapel);
                comando.Parameters.AddWithValue("@gramaje", informes.Gramaje);
                comando.Parameters.AddWithValue("@codigo", informes.Codigo);
                comando.Parameters.AddWithValue("@kg", informes.Kg);
                comando.Parameters.AddWithValue("@fechaEdicion", informes.FechaCorreccion);
                comando.Parameters.AddWithValue("@idInventario", idInventario);
                comando.ExecuteNonQuery();
            }
            else
            {
                int idInformes = EncontrarInformesPorId(informes);
                comando.CommandText = "UPDATE [informesStock] SET IdInventarios = concat([IdInventarios], ', ', @IdInventarioss) WHERE IdInformes = @value";
                comando.Parameters.AddWithValue("@value", idInformes);
                comando.Parameters.AddWithValue("@IdInventarioss", idInventario.ToString());
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
                    comando.CommandText = "INSERT INTO [depositosStock] ([USD], [TipoPapel], [Gramaje], [Codigo], [Kg], [EFormato], [NroRack], [IdInventarios])" + "Values (@usd, @tipoPapel, @gramaje, @codigo, @kg, @EFormato, @Tomos, @idInventario)";
                    comando.Parameters.AddWithValue("@usd", deposito.USD);
                    comando.Parameters.AddWithValue("@tipoPapel", deposito.TipoPapel);
                    comando.Parameters.AddWithValue("@gramaje", deposito.Gramaje);
                    comando.Parameters.AddWithValue("@codigo", deposito.Codigo);
                    comando.Parameters.AddWithValue("@kg", deposito.Kg);
                    comando.Parameters.AddWithValue("@EFormato", deposito.EFormato.ToString());
                    comando.Parameters.AddWithValue("@NroRack", deposito.NroRack);
                    comando.Parameters.AddWithValue("@idInventarios", idInventario);
                    comando.ExecuteNonQuery();
                }
                else
                {
                    idDepositos = EncontrarDepositosPorId(deposito);
                    comando.CommandText = "UPDATE [depositosStock] SET IdInventario = concat([IdInventario], ', ', @idInventarioss) WHERE IdDepositos = @value";
                    comando.Parameters.AddWithValue("@value", idDepositos);
                    comando.Parameters.AddWithValue("@idInventarioss", idInventario); 
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
            comando.CommandText = "SELECT * FROM dbo.despositosStock WHERE [Codigo] = @depositoCodigo";
            comando.Parameters.AddWithValue("@depositoCodigo", deposito.Codigo);
            SqlDataReader myReader = comando.ExecuteReader();
            myReader.Read();
            int idDeposito = Convert.ToInt32(myReader["IdDeposito"]);
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
            comando.CommandText = "SELECT * FROM dbo.informesStock WHERE [Codigo] = @informeCodigo";
            comando.Parameters.AddWithValue("@informeCodigo", informes.Codigo);
            SqlDataReader myReader = comando.ExecuteReader();
            int idInformes;
            myReader.Read();
            idInformes = Convert.ToInt32(myReader["IdInformes"]);
            myReader.Close();
            return idInformes;
        }



        #endregion

    }
}
