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
    }


    public class Arbitro : Pessoa, IArbitroModel, IPessoaModel
    {
        #region MEMBER VARIABLES
        private DateTime formacao;
        private CATEGORIA categoria;
        private ASSOCIACAO associacao;
        #endregion


        #region CONSTRUCTORS
        /// <summary>
        /// Construtor cheio
        /// </summary>
        /// <param name="nome">Nome do Arbitro</param>
        /// <param name="nacionalidade">Nacionalidade do Arbitro</param>
        /// <param name="dataNascimento">Data de Nascimento do Arbitro</param>
        /// <param name="altura">Aktura do Arbitro</param>
        /// <param name="peso">Peso do Arbitro</param>
        /// <param name="formacao">Data a que o Arbitro de Formou</param>
        /// <param name="categoria">Categoria do Arbitro</param>
        /// <param name="associacao">Local onde o Arbitro se Formou</param>
        public Arbitro(string nome, string nacionalidade, DateTime dataNascimento, float altura, float peso, DateTime formacao, CATEGORIA categoria, ASSOCIACAO associacao) : base(nome, nacionalidade, dataNascimento, altura, peso)
        {
            this.formacao = formacao;
            this.categoria = categoria;
            this.associacao = associacao;
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
        #endregion


        #region FUNCTIONS
        #endregion


        #region OVERIDES
        #endregion
    }
}
