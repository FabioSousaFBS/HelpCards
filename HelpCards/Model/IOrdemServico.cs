using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpCards
{
    interface IOrdemServico
    {
        void Adicionar(OrdemServico os);
        void Atualizar(OrdemServico os);
        void Remover(OrdemServico os);
        IList<OrdemServico> OrdemServicos();
    }
}
