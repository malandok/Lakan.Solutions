using Common.Entities;
using Common.Shared;
using Modules.Tenant.Domain.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Tenant.Domain.ValueObjects
{
    public sealed class Dba : ValueObject
    {
        public const int MaxLength = 50;

        private Dba(string value) { 
            Value = value;
        }

        public string Value { get; }

        public static Result<Dba> Create(string dba)
        {
            if (string.IsNullOrWhiteSpace(dba))
            {
                return Result.Failure<Dba>(DomainErrors.Dba.Empty);
            }

            return new Dba(dba);
        }

        public override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }
    }
}
