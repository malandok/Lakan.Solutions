using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Tenant.Domain.Events
{
    public sealed record TenantCreatedDomainEvent(Guid id) : IDomainEvent;
    
}
