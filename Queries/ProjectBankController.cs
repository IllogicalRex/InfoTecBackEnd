using System;
using System.Linq;
using InfoTecBackEnd.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

namespace InfoTecBackEnd.Queries {
    public class ProjectBankController : ODataController
{
    private readonly ResourceDBContext ctx;

    public ProjectBankController(ResourceDBContext ctx)
    {
        this.ctx = ctx;
    }

    [EnableQuery]
    public SingleResult<BankProjectModel> GetProjectBank(Guid key)
    {
        return new SingleResult<BankProjectModel>(ctx.ProjectBank.Where(v => v.Id.Equals(key)));
    }

    [EnableQuery]
    public IQueryable<BankProjectModel> GetProjectBank()
    {
        return ctx.ProjectBank;
    }
}
}