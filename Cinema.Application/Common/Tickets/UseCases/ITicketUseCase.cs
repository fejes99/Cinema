using Cinema.Application.Common.Tickets.Dtos;

namespace Cinema.Application.Common.Tickets.UseCases;

public interface ITicketUseCase
{
    Task<List<TicketDto>> GetTickets();
    Task<List<TicketDetailsDto>> GetTicketsByUserId(Guid userId);
    Task<TicketDetailsDto> GetTicketById(Guid id);
    Task<TicketDto> CreateTicket(TicketCreateDto ticketCreateDto);
    Task<TicketDto> UpdateTicket(Guid id, TicketUpdateDto ticketUpdateDto);
    Task DeleteTicket(Guid id);
}
