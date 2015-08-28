﻿using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Fzrain.AuditLogs.Dto;
using Fzrain.Common.Application.Dtos;

namespace Fzrain.AuditLogs
{
   public  interface IAuditLogAppService : IApplicationService
    {
       PagedResultOutput<AuditLogDto> GetAuditLogs(GetAuditLogInput input);
       Task<AuditLogDto> GetDetail(IdInput<long> input);
    }
}