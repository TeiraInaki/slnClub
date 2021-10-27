using Datos.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Datos.Admin
{
    public static class AdmJugador
    {
        public static List<Jugador> Listar()
        {
            string query = "SELECT Id,Nombre,Apellido,FechaNacimiento,Puesto FROM dbo.Jugador";

            SqlCommand command = new SqlCommand(query, AdminBD.ConectarBD());

            SqlDataReader reader;

            List<Jugador> Jugadores = new List<Jugador>();

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                Jugadores.Add(new Jugador
                {
                    Id = (int)reader["Id"],
                    Nombre = (string)reader["Nombre"],
                    Apellido = (string)reader["Apellido"],
                    FechaNacimiento = (DateTime)reader["FechaNacimiento"],
                    Puesto = (string)reader["Puesto"],
                });
            }

            AdminBD.ConectarBD().Close();
            reader.Close();

            return Jugadores;
        }

        public static DataTable Listar(string Puesto)
        {
            string query = "SELECT Id,Nombre,Apellido,FechaNacimiento,Puesto FROM dbo.Jugador WHERE Puesto=@Puesto";

            SqlDataAdapter adapter = new SqlDataAdapter(query, AdminBD.ConectarBD());

            adapter.SelectCommand.Parameters.Add("@Puesto", SqlDbType.VarChar, 50).Value = Puesto;

            DataSet ds = new DataSet();

            adapter.Fill(ds, "Puestos");

            return ds.Tables["Puestos"];
        }

        public static int Insertar(Jugador jugador) 
        {
            string query = "INSERT INTO dbo.Jugador (Nombre,Apellido,FechaNacimiento,Puesto) VALUES (@Nombre,@Apellido,@FechaNacimiento,@Puesto)";

            SqlCommand command = new SqlCommand(query, AdminBD.ConectarBD());

            command.Parameters.Add("@Nombre", SqlDbType.VarChar,50).Value = jugador.Nombre;
            command.Parameters.Add("@Apellido", SqlDbType.VarChar,50).Value = jugador.Apellido;
            command.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = jugador.FechaNacimiento;
            command.Parameters.Add("@Puesto", SqlDbType.VarChar, 50).Value = jugador.Puesto;

            int filasAfectadas = command.ExecuteNonQuery();
            return filasAfectadas;
        }

        public static int Modificar(Jugador jugador) 
        {
            string query = "UPDATE dbo.Jugador SET Nombre=@Nombre,Apellido=@Apellido,FechaNacimiento=@FechaNacimiento,Puesto=@Puesto WHERE Id=@Id";

            SqlCommand command = new SqlCommand(query, AdminBD.ConectarBD());

            command.Parameters.Add("@Id", SqlDbType.Int).Value = jugador.Id;
            command.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = jugador.Nombre;
            command.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = jugador.Apellido;
            command.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = jugador.FechaNacimiento;
            command.Parameters.Add("@Puesto", SqlDbType.VarChar, 50).Value = jugador.Puesto;

            int filasAfectadas = command.ExecuteNonQuery();
            return filasAfectadas;
        }

        public static int Eliminar(int Id)
        {
            string query = "DELETE FROM dbo.Jugador WHERE Id=@Id";

            SqlCommand command = new SqlCommand(query, AdminBD.ConectarBD());

            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;

            int filasAfectadas = command.ExecuteNonQuery();
            return filasAfectadas;
        }

    }
}
