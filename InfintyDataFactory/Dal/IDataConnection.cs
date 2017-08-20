using System.Data;

namespace InfintyDataFactory.Dal
{
    interface IDataConnection
    {
        IDbConnection GetConnection();
    }
}
