using Cinema.Application.Common.Projections.Dtos;
using Cinema.Application.Common.Projections.UseCases;
using Cinema.Application.Common.Users.Dtos;
using Cinema.Application.Common.Users.UseCases;
using Cinema.Application.Common.Users.UseCases.Impl;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Cinema.Presentation.Controllers;

[Route("api/projections")]
[ApiController]
public class ProjectionController : ControllerBase
{
    private readonly IProjectionUseCase projectionUseCase;

    public ProjectionController(IProjectionUseCase projectionUseCase)
    {
        this.projectionUseCase = projectionUseCase;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<List<ProjectionDto>>> GetProjections()
    {
        List<ProjectionDto> projections = await projectionUseCase.GetProjections();
        return Ok(projections);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<ProjectionDto>> GetProjection([Required] Guid id)
    {
        ProjectionDto projection = await projectionUseCase.GetProjectionById(id);
        return Ok(projection);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<ActionResult<ProjectionDto>> CreateProjection([FromBody] ProjectionCreateDto projectionCreateDto)
    {
        ProjectionDto createdProjection = await projectionUseCase.CreateProjection(projectionCreateDto);
        return Created("Projection created", createdProjection);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<ProjectionDto>> UpdateProjection([Required] Guid id, [FromBody] ProjectionUpdateDto projectionUpdateDto)
    {
        ProjectionDto updatedProjection = await projectionUseCase.UpdateProjection(id, projectionUpdateDto);
        return Ok(updatedProjection);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteProjection([Required] Guid id)
    {
        await projectionUseCase.DeleteProjection(id);
        return NoContent();
    }
}
