using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMagazine.Application.Contracts.Errors
{
    public enum ErrorTypes
    {
        Unauthorized,
        Forbidden,
        Validation,
        NotFound,
        Conflict
    }
}
