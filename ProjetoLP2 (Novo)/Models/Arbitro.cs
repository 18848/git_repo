using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLP2.Models
{
    public interface IArbitro : IPessoa
    {
        DateTime Formacao { get; set; }
        CATEGORIA Categoria { get; set; }
        ASSOCIACAO Associacao { get; set; }
    }

    class Arbitro : Pessoa, IArbitro
    {
        #region Member Values
        private DateTime formacao;
        private CATEGORIA categoria;
        private ASSOCIACAO associacao;
        #endregion

        #region Constructor
        public Arbitro(DateTime f, CATEGORIA c, ASSOCIACAO a, string nome, string nac, DateTime d, float altura, float peso)
            : base(nome, nac, d, altura, peso)
        {
            formacao = f;
            categoria = c;
            associacao = a;
        }
        public Arbitro() : base()
        {
            this.formacao = DateTime.Now;
            this.categoria = CATEGORIA.ND;
            this.associacao = ASSOCIACAO.ND;
        }
        #endregion

        #region Properties
        public DateTime Formacao
        {
            get { return formacao; }
            set { formacao = value; }
        }
        public CATEGORIA Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public ASSOCIACAO Associacao
        {
            get { return associacao; }
            set { associacao = value; }
        }
        #endregion
    }
}
