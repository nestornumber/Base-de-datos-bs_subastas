using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace db_sis22A
{
    class cls_transacciones
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        string servidor = "Data Source=.\\SQLEXPRESS;";
        string base_de_datos = "Initial Catalog=bs_subastas;";
        string usuario = "Integrated Security=true;";
        public cls_transacciones()
        {
            con.ConnectionString = servidor + base_de_datos + usuario;
        }


        //metodo para ejecutar consultas sql
        public DataTable consulta(string sql)
        {
            DataTable mitabla = new DataTable();
            adapter = new SqlDataAdapter(sql,con);
            adapter.Fill(mitabla);
            return mitabla;
        }


        //metodo para ejecutar consultas
        //insert, delete, update
        public bool ejecutarComando(string sql)
        {
            cmd.CommandText = sql;
            cmd.Connection = this.con;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return true;
        }
    }
}
