﻿using Marqa.Service.Services.EmployeeRoles;
using Marqa.Service.Services.EmployeeRoles.Models;
using Marqa.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Marqa.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeRolesController(IEmployeeRoleService employeeRoleService) : ControllerBase
{
    [HttpPost("create")]
    public async Task<IActionResult> PostAsync(EmployeeRoleCreateModel model)
    {
        await employeeRoleService.CreateAsync(model);

        return Ok(new Response
        {
            Status = 200,
            Message = "success",
        });
    }

    [HttpPut("update/{id:int}")]
    public async Task<IActionResult> PutAsync(int id, [FromBody] EmployeeRoleUpdateModel model)
    {
        await employeeRoleService.UpdateAsync(id, model);

        return Ok(new Response
        {
            Status = 200,
            Message = "success",
        });
    }

    [HttpDelete("delete/{id:int}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        await employeeRoleService.DeleteAsync(id);

        return Ok(new Response
        {
            Status = 200,
            Message = "success",
        });
    }

    [HttpGet("get/{id:int}")]
    public async Task<IActionResult> GetAsync(int id)
    {
        var company = await employeeRoleService.GetAsync(id);

        return Ok(new Response<EmployeeRoleViewModel>
        {
            Status = 200,
            Message = "success",
            Data = company
        });
    }

    [HttpGet("by{companyId:int}")]
    public async Task<IActionResult> GetAllAsync(int? companyId)
    {
        var companies = await employeeRoleService.GetAllAsync(companyId);

        return Ok(new Response<List<EmployeeRoleViewModel>>
        {
            Status = 200,
            Message = "success",
            Data = companies
        });
    }
}
