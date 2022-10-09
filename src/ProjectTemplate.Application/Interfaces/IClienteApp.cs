using ProjectTemplate.Application.DTOs;
using ProjectTemplate.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTemplate.Application.Interfaces
{
    public interface IClienteApp : IBaseApp<Cliente, ClienteDto>
    {
    }
}
