using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using InfoTecBackEnd.Models;
using InfoTecBackEnd.Models.RquestBankProject;
using MediatR;
namespace InfoTecBackEnd.Handlers {
    public class ProjectBankHandler : IRequestHandler<BankProjectRequest, BankProjectModel>
    {
        private readonly ResourceDBContext ctx;

        public ProjectBankHandler(ResourceDBContext ctx)
        {
            this.ctx = ctx;
        }

        // Implements and encapsulates the real business logic
        public async Task<BankProjectModel> Handle(BankProjectRequest request, CancellationToken cancellationToken)
        {
            var person = new BankProjectModel
            {
                Nombre = request.Nombre,
                Direccion = request.Direccion
            };
            ctx.Add(person);

            await ctx.SaveChangesAsync();

            return person;
        }

    }

    public class GetAllProjectBankHandler : IRequestHandler<GetAllBankProjectRequest, List<BankProjectModel>>
    {
        private readonly ResourceDBContext ctx;

        public GetAllProjectBankHandler(ResourceDBContext ctx)
        {
            this.ctx = ctx;
        }

        // Implements and encapsulates the real business logic

        public Task<List<BankProjectModel>> Handle(GetAllBankProjectRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult( ctx.ProjectBank.ToList());
        }
    }
}
