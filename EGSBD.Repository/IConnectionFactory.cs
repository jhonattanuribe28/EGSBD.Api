using System.Data;

namespace EGSBD.Repository
{
    public interface IConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}
