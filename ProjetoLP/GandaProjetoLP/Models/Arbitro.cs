using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLP.Models
{
    public interface IArbitroModel
    {
        DateTime Formacao { get; set; }
        CATEGORIA Categoria { get; set; }
        ASSOCIACAO Associacao { get; set; }

        ID
    }


    public class Arbitro : Pessoa, IArbitroModel, IPessoaModel
    {
        #region MEMBER VARIABLES
        private DateTime formacao;
        private CATEGORIA categoria;
        private ASSOCIACAO associacao;
        private ID id;
        #endregion


        #region CONSTRUCTORS
        public Arbitro(DateTime f, CATEGORIA c, ASSOCIACAO a, string nome, string nac, DateTime d, float altura, float peso) 
            : base(nome, nac, d, altura, peso)
        {
            formacao = f;
            categoria = c;
            associacao = a;
        }
            /// <summary>
            /// Construtor vazio
            /// </summary>
            public Arbitro() : base()
        {
            this.formacao = DateTime.Now;
            this.categoria = CATEGORIA.ND;
            this.associacao = ASSOCIACAO.ND;
        }
        #endregion


        #region PROPERTIES
        /// <summary>
        /// Manipula o atributo "formacao"
        /// </summary>
        public DateTime Formacao
        {
            get { return formacao; }
            set { formacao = value; }
        }

        /// <summary>
        /// Manipula o atributo "categoria"
        /// </summary>
        public CATEGORIA Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }


        /// <summary>
        /// Manipula o atributo "associacao"
        /// </summary>
        public ASSOCIACAO Associacao
        {
            get { return associacao; }
            set { associacao = value; }
        }

        public ID Id
        {
            get { return id; }
            set { id = value; }
        }
        #endregion


        #region FUNCTIONS
        #endregion


        #region OVERIDES
        #endregion
    }
}
