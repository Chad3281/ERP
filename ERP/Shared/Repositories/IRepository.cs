using System;
using System.Data;

namespace ERP.Shared.Repositories
{
    public interface IRepository : IDisposable
    {
        IDbCommand CreateCommand(string query);
    }
}