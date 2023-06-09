﻿using Cinema.Application.Common.Projections.ProjectionTypes.Dtos;
using Cinema.Application.Common.Projections.ProjectionTypes.UseCases;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.Presentation.Controllers;

[Route("api/projectionTypes")]
[AllowAnonymous]
[ApiController]
public class ProjectionTypeController : ControllerBase
{
    private readonly IProjectionTypeUseCase projectionTypeUseCase;

    public ProjectionTypeController(IProjectionTypeUseCase projectionTypeUseCase)
    {
        this.projectionTypeUseCase = projectionTypeUseCase;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<List<ProjectionTypeDto>>> GetProjectionTypes()
    {
        List<ProjectionTypeDto> projectionTypes = await projectionTypeUseCase.GetProjectionTypes();
        return Ok(projectionTypes);
    }
}
