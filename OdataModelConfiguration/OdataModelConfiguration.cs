using InfoTecBackEnd.Models;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNetCore.Mvc;

namespace InfoTecBackEnd.OdataModelConfiguration
{
    public class OdataModelConfiguration : IModelConfiguration
    {
        public void Apply(ODataModelBuilder builder, ApiVersion apiVersion)
        {
            builder.EntitySet<BankProjectModel>("ProjectBank");
        }
    }

}
