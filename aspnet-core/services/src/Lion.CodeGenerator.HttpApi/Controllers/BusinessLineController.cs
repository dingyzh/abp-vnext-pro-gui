﻿using System.Threading.Tasks;
using Lion.CodeGenerator.BusinessLines;
using Lion.CodeGenerator.BusinessLines.Dto;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Volo.Abp.Auditing;

namespace Lion.CodeGenerator.Controllers;

[Route("BusinessLines")]
public class BusinessLineController : CodeGeneratorController, IBusinessLineAppService
{
    private readonly IBusinessLineAppService _businessLineAppService;

    public BusinessLineController(IBusinessLineAppService businessLineAppService)
    {
        _businessLineAppService = businessLineAppService;
    }

    [HttpPost("CreateBusinessLine")]
    [SwaggerOperation(summary: "创建业务线", Tags = new[] { "BusinessLines" })]
    public Task CreateBusinessLineAsync(CreateBusinessLineInput input)
    {
        return _businessLineAppService.CreateBusinessLineAsync(input);
    }
    
    [HttpPost("CreateBusinessProject")]
    [SwaggerOperation(summary: "创建业务线下项目", Tags = new[] { "BusinessLines" })]
    public Task CreateBusinessProjectAsync(CreateBusinessProjectInput input)
    {
        return _businessLineAppService.CreateBusinessProjectAsync(input);
    }
}