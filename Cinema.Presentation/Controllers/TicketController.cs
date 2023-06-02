using Cinema.Application.Common.Tickets.Dtos;
using Cinema.Application.Common.Tickets.UseCases;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Cinema.Presentation.Controllers;

[Route("api/tickets")]
[AllowAnonymous]
[ApiController]
public class TicketController : ControllerBase
{
    private readonly ITicketUseCase ticketUseCase;

    public TicketController(ITicketUseCase ticketUseCase)
    {
        this.ticketUseCase = ticketUseCase;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<List<TicketDto>>> GetTickets()
    {
        List<TicketDto> tickets = await ticketUseCase.GetTickets();
        return Ok(tickets);
    }

    [HttpGet("user/{userId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<List<TicketDetailsDto>>> GetTicketsByUserId([Required] Guid userId)
    {
        List<TicketDetailsDto> tickets = await ticketUseCase.GetTicketsByUserId(userId);
        return Ok(tickets);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<TicketDetailsDto>> GetTicket([Required] Guid id)
    {
        TicketDetailsDto ticket = await ticketUseCase.GetTicketById(id);
        return Ok(ticket);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<ActionResult<TicketDto>> CreateTicket([FromBody] TicketCreateDto ticketCreateDto)
    {
        TicketDto createdTicket= await ticketUseCase.CreateTicket(ticketCreateDto);
        return Created("Movie created", createdTicket);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<TicketDto>> UpdateTicket([Required] Guid id, [FromBody] TicketUpdateDto ticketUpdateDto)
    {
        TicketDto updatedTicket = await ticketUseCase.UpdateTicket(id, ticketUpdateDto);
        return Ok(updatedTicket);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteTicket([Required] Guid id)
    {
        await ticketUseCase.DeleteTicket(id);
        return NoContent();
    }
}
