using System.Data;

namespace Models
{
    public class CompanyType : Models.Model
    {
        public void Create(string Name)
        {
            QuerySQLServer("INSERT INTO CompanyType (Name) VALUES ('"+Name+"')");
        }
        public DataTable SelectAll()
        {
            return QuerySQLServer("SELECT * FROM CompanyType ORDER BY Name");
        }
        public DataTable GetById(int Id)
        {
            return QuerySQLServer("SELECT * FROM CompanyType WHERE Id="+Id);
        }
        public DataTable GetByName(string Name)
        {
            return QuerySQLServer("SELECT * FROM CompanyType WHERE Name='"+Name+"'");
        }
        public void Delete(int Id)
        {
            QuerySQLServer("Update CompanyType SET IsDeleted=1 WHERE Id="+Id);
        }
    }
}