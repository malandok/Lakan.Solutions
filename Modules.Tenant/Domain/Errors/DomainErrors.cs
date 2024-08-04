using Common.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Tenant.Domain.Errors
{
    internal static class DomainErrors
    {
        public static class Tenant
        {
            public static readonly Error DbaAlreadyExist = new(
                "Tenant.DbaAlreadyExist",
                "The specified DBA is already exist");
        }

        public static class Dba
        {
            public static readonly Error Empty = new(
                "DBA.Empty",
                "DBA is empty");
        }
    }
}
