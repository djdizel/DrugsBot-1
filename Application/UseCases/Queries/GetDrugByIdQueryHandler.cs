using Application.Interfaces.Repos;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Queries;

public class GetDrugByIdQueryHandler(IDrugReadRepos drugReadRepos) : IRequestHandler<GetDrugByIdQuery, Drug?>
{
    
    public async Task<Drug?> Handle(GetDrugByIdQuery request, CancellationToken cancellationToken)
    {
        var response = await drugReadRepos.GetByIdAsync(request.Id, cancellationToken);

        return  response;
    }
}