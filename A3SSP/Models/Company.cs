using System.Data;
namespace Models
{
    public class Company : Models.Model
    {
        public void Create()
        {
            DataTable Data = QuerySQLServer("");
        }
    }
}