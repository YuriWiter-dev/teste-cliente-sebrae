using AutoMapper;
using ProjectTemplate.Application.DTOs;
using ProjectTemplate.Application.Interfaces;
using ProjectTemplate.Domain.Entities;
using ProjectTemplate.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjectTemplate.Application.Services
{
    public class ClienteServicoApp : BaseServicoApp<Cliente, ClienteDto>, IClienteApp
    {
        protected readonly IClienteServico _clienteServico;

        public ClienteServicoApp(IClienteServico clienteServico, IMapper mapper) : base(clienteServico, mapper)
        {
            _clienteServico = clienteServico;
        }
    }
}
