﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Fzrain.Permissions.Dto;

namespace Fzrain.Permissions
{
    public  interface IPermissionInfoAppService: IApplicationService
    {
        Task AddOrUpdate(PermissionDto permission);
        Task<PermissionDto> GetById(IdInput input);
        Task Delete(IdInput input);
        Task<PagedResultOutput<PermissionDto>> GetPermissions(PermissionQueryInput input);
        List<string> GetPermissionNames();
    }
}
