using Departamentos.Domain;
using MediatR;

namespace Departamentos.Application.Querys.GetAllDepartaments
{
    public class GetAllDepartamentsQuery : IRequest<List<Departamento>>
    {
    }
}
