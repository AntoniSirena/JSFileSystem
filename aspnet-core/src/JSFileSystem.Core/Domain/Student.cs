using Abp.Domain.Entities.Auditing;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSFileSystem.Domain
{
    public class Student : FullAuditedEntity, IMayHaveTenant
    {
        public string Code { get; set; }
        public string Names { get; set; }
        public string Surnames { get; set; }
        public DateTime TerminateDate { get; set; }
        public bool IsActive { get; set; }
        public int? TenantId { get; set; }
    }
}
