using System;
using System.Collections.Generic;
using InfoTecBackEnd.Models;
using MediatR;

namespace InfoTecBackEnd.Models.RquestBankProject{
    public class BankProjectRequest : IRequest<BankProjectModel> {
        public string Nombre {get; set;}
        public string Direccion {get; set;}
    }

    public class GetAllBankProjectRequest : IRequest<List<BankProjectModel>> {

    }
}