using sda.backend.minimalapi.Core.Auths.IF;
using sda.backend.minimalapi.Core.Auths.Models;
using sda.backend.minimalapi.Core.Auths.Services;

namespace sda.backend.minimalapi.Core.Games.Services
{
    namespace sda.backend.minimalapi.Core.Auths.Services
    {
        public class SqlServerGetAuthService : IGetAuthService
        {


            private readonly AuthenticationDbContext _dbContext;

            #region Constructors
            public SqlServerGetAuthService(AuthenticationDbContext context)
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
            public AuthenticationUser? GetOne(string email)
            {
                AuthenticationUser? authuser = _dbContext.AuthenticationUsers
                                               .Where(au => au.NormalizedEmail == email.ToUpper()).FirstOrDefault();
                return authuser;
            }
            #endregion
        }
    }
}
//return this._dbContext.Games.Where(item => item.Character != null).ToList();
