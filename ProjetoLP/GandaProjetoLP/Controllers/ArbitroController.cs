using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GandaProjetoLP.Models;
using GandaProjetoLP.View;


namespace GandaProjetoLP
{
    public interface IArbitroController
    {
        void SetModel(IArbitroModel arbitroModel);

        void SetFormacao(DateTime f);
        void SetCategoria(CATEGORIA c);
        void SetAssociacao(ASSOCIACAO a);

        DateTime GetFormacao();
        CATEGORIA GetCategoria();
        ASSOCIACAO GetAssociacao();

        void NewArbitro(Arbitro a);
    }

    class ArbitroController
    {
        private Arbitro arbitro;
        private ArbitroView display;

        //public int Criar()
        //{

        //}

        public void SetFormacao(DateTime f)
        {
            arbitro.Formacao = f;
        }

        public void SetCategoria(CATEGORIA c)
        {
            arbitro.Categoria = c;
        }
        public void SetAssociacao(ASSOCIACAO a)
        {
            arbitro.Associacao = a;
        }

        DateTime GetFormacao()
        {
            return arbitro.Formacao;
        }
        CATEGORIA GetCategoria()
        {
            return arbitro.Categoria;
        }
        ASSOCIACAO GetAssociacao()
        {
            return arbitro.Associacao;
        }

    }
}
