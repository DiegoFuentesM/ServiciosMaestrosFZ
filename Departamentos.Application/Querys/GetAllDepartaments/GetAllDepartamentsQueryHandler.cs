using Departamentos.Domain;
using MediatR;

namespace Departamentos.Application.Querys.GetAllDepartaments
{
    public class GetAllDepartamentsQueryHandler : IRequestHandler<GetAllDepartamentsQuery, List<Departamento>>
    {
        private readonly IMediator _mediator;
        Task<List<Departamento>> IRequestHandler<GetAllDepartamentsQuery, List<Departamento>>.Handle(GetAllDepartamentsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
