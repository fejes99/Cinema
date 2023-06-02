using Cinema.Application.Common.Projections.Exceptions;
using Cinema.Application.Common.Tickets.Dtos;
using Cinema.Application.Common.Tickets.Helpers;
using Cinema.Domain.AggregateModels.Projections;
using Cinema.Domain.AggregateModels.Projections.Exceptions;
using Cinema.Domain.AggregateModels.Projections.ValueObjects;
using Cinema.Domain.AggregateModels.Theaters.Seats.ValueObjects;
using Cinema.Domain.AggregateModels.Tickets;
using Cinema.Domain.AggregateModels.Tickets.ValueObjects;
using Cinema.Domain.AggregateModels.Users.ValueObjects;

namespace Cinema.Application.Common.Tickets.UseCases.Impl;

public class TicketUseCase : ITicketUseCase
{
    private readonly ITicketRepository repository;
    private readonly IProjectionRepository projectionRepository;

    public TicketUseCase(ITicketRepository repository, IProjectionRepository projectionRepository)
    {
        this.repository = repository;
        this.projectionRepository = projectionRepository;
    }

    public async Task<TicketDto> CreateTicket(TicketCreateDto ticketCreateDto)
    {
        Projection projection = await projectionRepository.GetByIdAsync(new ProjectionId(ticketCreateDto.ProjectionId));

         if (projection.CheckIsSold())
        {
            await projectionRepository.UpdateAsync(projection);
            throw new ProjectionIsSoldException("Projection is sold out.");

        }

        if (!projection.CanSellTickets()) throw new ProjectionTimeRangeException("Projection is not valid for selling tickets.");

        Ticket ticketToCreate = Ticket.CreateForProjection(new UserId(ticketCreateDto.UserId), new SeatId(ticketCreateDto.SeatId), projection);
        await projectionRepository.UpdateAsync(projection.UpdateIsSold());

        Ticket createdTicket = await repository.CreateAsync(ticketToCreate);
        TicketDto createdTicketDto = createdTicket.TicketToDto();
        return createdTicketDto;
    }

    public async Task DeleteTicket(Guid id)
    {
        Ticket ticket = await repository.GetByIdAsync(new TicketId(id));
        Projection projection = ticket.Projection;

        projection.Tickets.Remove(ticket);

        await projectionRepository.UpdateAsync(projection.UpdateIsSold());

        await repository.DeleteAsync(new TicketId(id));
    }

    public async Task<TicketDetailsDto> GetTicketById(Guid id)
    {
        Ticket ticket = await repository.GetByIdAsync(new TicketId(id));
        TicketDetailsDto ticketDto = ticket.TicketToDetailsDto();
        return ticketDto;
    }

    public async Task<List<TicketDto>> GetTickets()
    {
        List<Ticket> tickets = await repository.GetAllAsync();
        List<TicketDto> ticketDtos = tickets.Select(ticket => ticket.TicketToDto()).ToList();
        return ticketDtos;
    }

    public async Task<List<TicketDetailsDto>> GetTicketsByUserId(Guid userId)
    {
        List<Ticket> tickets = await repository.GetAllByUserIdAsync(new UserId(userId));
        List<TicketDetailsDto> ticketDtos = tickets.Select(ticket => ticket.TicketToDetailsDto()).ToList();
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
