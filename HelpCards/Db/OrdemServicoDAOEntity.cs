using System;
using System.Collections.Generic;
using System.Linq;

namespace HelpCards
{
    public class OrdemServicoDAOEntity : IDisposable, IOrdemServico
    {
        private Contexto contexto;

        public OrdemServicoDAOEntity()
        {
            this.contexto = new Contexto();
        }

        public void Adicionar(OrdemServico os)
        {
            contexto.OrdemServicos.Add(os);
            contexto.SaveChanges();
        }

        public void Atualizar(OrdemServico os)
        {
            contexto.OrdemServicos.Update(os);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public IList<OrdemServico> OrdemServicos()
        {
            return contexto.OrdemServicos.ToList();
        }

        public void Remover(OrdemServico os)
        {
            contexto.OrdemServicos.Remove(os);
            contexto.SaveChanges();
        }
    }
}
