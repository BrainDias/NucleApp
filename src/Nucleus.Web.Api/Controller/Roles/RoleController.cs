﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nucleus.Application.Permissions;
using Nucleus.Application.Roles;
using Nucleus.Application.Roles.Dto;
using Nucleus.Core.Permissions;
using Nucleus.Utilities.Collections;
using Nucleus.Web.Core.Controllers;

namespace Nucleus.Web.Api.Controller.Roles
{
    public class RoleController : AdminController
    {
        private readonly IRoleAppService _roleAppService;

        public RoleController(IRoleAppService roleAppService, IPermissionAppService permissionAppService)
        {
            _roleAppService = roleAppService;
        }

        [HttpGet("[action]")]
        [Authorize(Policy = DefaultPermissions.PermissionNameForRoleRead)] 
        public async Task<ActionResult<IPagedList<RoleListOutput>>> GetRoles(RoleListInput input)
        {
            return Ok(await _roleAppService.GetRolesAsync(input));
        }

        [HttpPost("[action]")]
        [Authorize(Policy = DefaultPermissions.PermissionNameForRoleCreate)] 
        public async Task<ActionResult> CreateRole([FromBody]CreateOrUpdateRoleInput input)
        {
            await _roleAppService.AddRoleAsync(input);

            return Ok(new { success = true });
        }

        [HttpDelete("[action]")]
        [Authorize(Policy = DefaultPermissions.PermissionNameForRoleDelete)] 
        public ActionResult DeleteRole(Guid id)
        {
            _roleAppService.RemoveRole(id);

            return Ok(new { success = true });
        }

        [HttpGet("[action]")]
        [Authorize(Policy = DefaultPermissions.PermissionNameForRoleCreate)]
        [Authorize(Policy = DefaultPermissions.PermissionNameForRoleUpdate)]
        public async Task<ActionResult<GetRoleForCreateOrUpdateOutput>> GetRoleForCreateOrUpdate(GetRoleForCreateOrUpdateInput input)
        {
            var getRoleForCreateOrUpdateOutput = await _roleAppService.GetRoleForCreateOrUpdateAsync(input);

            return Ok(getRoleForCreateOrUpdateOutput);
        }
    }
}