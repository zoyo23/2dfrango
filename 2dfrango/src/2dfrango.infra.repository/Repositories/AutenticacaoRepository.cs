using _2dfrango.domain.Interfaces.Repositories;
using System.Data;

namespace _2dfrango.infra.repository
{
    public class AutenticacaoRepository : IAutenticacaoRepository
    {
        #region Atributos
        private readonly IDbConnection _dbConnection;

        #endregion

        #region Construtores
        public AutenticacaoRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        #endregion
    }
}
