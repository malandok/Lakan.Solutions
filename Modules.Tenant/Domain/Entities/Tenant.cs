using Common.Entities;
using Modules.Tenant.Domain.Events;
using Modules.Tenant.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Tenant.Domain.Entities
{
    public class Tenant : AggregateRoot
    {
        private Tenant(Dba dba) : this()
        {
            Dba = dba;
        }

        private Tenant() { }

        public Dba Dba { get; private set; }

        public static Tenant Create(Dba dba)
        {

            var tenant = new Tenant(dba);

            tenant.RaiseDomainEvent(new TenantCreatedDomainEvent(tenant.Id));

            return tenant;
        }
    }
}
