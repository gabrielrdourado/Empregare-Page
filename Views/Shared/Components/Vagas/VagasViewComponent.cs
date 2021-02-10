using empregare.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace empregare.Views.Shared.Components.Vagas
{
    public class VagasViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var vagas = new List<VagasModel>();

            vagas.Add(new VagasModel {Cargo = "Vendedor", Cidade = "Ribeirão Preto", Salario = 1500.00});
            vagas.Add(new VagasModel { Cargo = "Programador", Cidade = "Serrana", Salario = 3570.50 });
            vagas.Add(new VagasModel { Cargo = "Design", Cidade = "Campinas", Salario = 1720.00 });
            vagas.Add(new VagasModel { Cargo = "Auxiliar", Cidade = "Ribeirão Preto", Salario = 1356.40 });
            vagas.Add(new VagasModel { Cargo = "Engenheiro", Cidade = "São Paulo", Salario = 3700.00 });
            vagas.Add(new VagasModel { Cargo = "Administrador", Cidade = "Campinas", Salario = 1400.00 });
            vagas.Add(new VagasModel { Cargo = "Vendedor Externo", Cidade = "Jardinópolis", Salario = 2200.00 });
            vagas.Add(new VagasModel { Cargo = "Gerente", Cidade = "São Paulo", Salario = 4730.00 });


            return View(vagas);
        }
    }
}
