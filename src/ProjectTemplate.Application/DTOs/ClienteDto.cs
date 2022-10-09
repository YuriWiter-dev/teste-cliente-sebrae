using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectTemplate.Application.DTOs
{
    public class ClienteDto : BaseEntidadeDTO
    {
        public string Nome{ get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string PlacaCarro { get; set; }

        //public string NomeTelefone => Nome + "-" + Telefone;
    }
}
