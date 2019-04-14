﻿using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TeknoLabs.Habit.MultiTenancy.Dto;

namespace TeknoLabs.Habit.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

