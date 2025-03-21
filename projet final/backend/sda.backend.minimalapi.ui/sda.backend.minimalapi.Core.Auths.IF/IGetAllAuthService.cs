using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sda.backend.minimalapi.Core.Auths.Models;

namespace sda.backend.minimalapi.Core.Auths.IF
{
    /// <summary>
    /// Contrat pour récupérer la liste des authenticationuser
    /// </summary>
    public interface IGetAllAuthService
    {
        IEnumerable<AuthenticationUser> GetAll();
    }
}
