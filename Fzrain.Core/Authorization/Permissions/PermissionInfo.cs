﻿
using System.Collections.Generic;
using Abp.Domain.Entities.Auditing;
using Fzrain.Authorization.Users;

namespace Fzrain.Authorization.Permissions
{
    public class PermissionInfo : CreationAuditedEntity<int, User>
    {
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public bool IsGrantedByDefault { get; set; }
        public string  Name { get; set; }
        public string  ParentName { get; set; }
    }
}
