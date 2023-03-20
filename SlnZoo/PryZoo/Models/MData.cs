using Zoo.DTO;
using Npgsql;
using System.Data;
using Newtonsoft.Json;

namespace Zoo.Models
{
    public class MData
    {

        public MData()
        {

        }

        public ResponseDTO execute(string command)
        {
            ResponseDTO response = new ResponseDTO(true, "", "");
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Host=209.50.55.238:97;Username=postgres;Password=5492bbf20;Database=Grupo2");
                conn.Open();

                // Definimos el query
                NpgsqlCommand query = new NpgsqlCommand(command, conn);

                //Ejecutar Query
                NpgsqlDataReader dr = query.ExecuteReader();

                var datatable = new DataTable();
                datatable.Load(dr);
                response .data = JsonConvert.SerializeObject(datatable);

                return response;
            }
            catch (System.Exception)
            {
                response.response = false;
                response.error = "Error en la conexion";
                return response;
            }
        }
    }
}