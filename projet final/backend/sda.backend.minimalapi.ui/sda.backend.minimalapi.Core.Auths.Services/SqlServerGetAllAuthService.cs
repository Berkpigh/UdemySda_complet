using sda.backend.minimalapi.Core.Auths.IF;
using sda.backend.minimalapi.Core.Auths.Models;
using sda.backend.minimalapi.Core.Auths.Services;

namespace sda.backend.minimalapi.Core.Games.Services
{
    namespace sda.backend.minimalapi.Core.Auths.Services
    {
        public class SqlServerGetAllAuthService : IGetAllAuthService
        {


            private readonly AuthenticationDbContext _dbContext;

            #region Constructors
            public SqlServerGetAllAuthService(AuthenticationDbContext context)
            {
                _dbContext = context;
            }
            #endregion

            #region Public methods
            public IEnumerable<AuthenticationUser> GetAll()
            {
                var query = from item in _dbContext.AuthenticationUsers
                            //where item.Character != null
                            select item;

                //return this._dbContext.Games.Where(item => item.Character != null).ToList();
                return query.ToList();
            }
            #endregion
        }
    }
}
