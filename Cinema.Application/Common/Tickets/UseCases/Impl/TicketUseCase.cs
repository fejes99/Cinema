using Cinema.Application.Common.Tickets.Dtos;
using Cinema.Application.Common.Tickets.Helpers;
using Cinema.Domain.AggregateModels.Tickets;
using Cinema.Domain.AggregateModels.Tickets.ValueObjects;

namespace Cinema.Application.Common.Tickets.UseCases.Impl;

public class TicketUseCase : ITicketUseCase
{
    private readonly ITicketRepository repository;

    public TicketUseCase(ITicketRepository repository)
    {
        this.repository = repository;
    }

    public async Task<TicketDto> CreateTicket(TicketCreateDto ticketCreateDto)
    {
        Ticket createdTicket = await repository.CreateAsync(ticketCreateDto.CreateDtoToTicket());
        TicketDto createdTicketDto = createdTicket.TicketToDto();
        return createdTicketDto;
    }

    public async Task DeleteTicket(Guid id)
    {
        await repository.DeleteAsync(new TicketId(id));
    }

    public async Task<TicketDto> GetTicketById(Guid id)
    {
        Ticket ticket = await repository.GetByIdAsync(new TicketId(id));
        TicketDto ticketDto = ticket.TicketToDto();
        return ticketDto;
    }

    public async Task<List<TicketDto>> GetTickets()
    {
        List<Ticket> tickets = await repository.GetAllAsync();
        List<TicketDto> ticketDtos = tickets.Select(ticket => ticket.TicketToDto()).ToList();
        return ticketDtos;
    }

    public async Task<TicketDto> UpdateTicket(Guid id, TicketUpdateDto ticketUpdateDto)
    {
        Ticket ticketToUpdate = await repository.GetByIdAsync(new TicketId(id));
        Ticket updatedTicket = await repository.UpdateAsync(ticketToUpdate.UpdateMapper(ticketUpdateDto));
        TicketDto updatedTicketDto = updatedTicket.TicketToDto();
        return updatedTicketDto;
    }
}
