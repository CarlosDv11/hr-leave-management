using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Domain.Common;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTime? DataCreated { get; set; }
    public DateTime? DataModified { get; set; }
}
