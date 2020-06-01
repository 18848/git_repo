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

        void UpdateArbitro(IArbitro arbitro);
        void DeleteArbitro();
    }

    /// <summary>
    /// Class Responsible for Storing Arbitro's Data.
    /// </summary>
    [Serializable]
    class Arbitro : Pessoa, IArbitro
    {
        #region Member Values
        private DateTime formacao;
        private CATEGORIA categoria;
        private ASSOCIACAO associacao;
        #endregion

        #region Constructor
        /// <summary>
        /// The Default Constructor.
        /// </summary>
        public Arbitro() : base()
        {
            Formacao = DateTime.Now;
            Categoria = CATEGORIA.ND;
            Associacao = ASSOCIACAO.ND;
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

        #region Functions

        /// <summary>
        /// Updates local Arbitro given external IArbitro.
        /// </summary>
        /// <param name="arbitro"></param>
        public void UpdateArbitro(IArbitro arbitro)
        {
            IPessoa x = arbitro;
            UpdatePessoa(x);
            Formacao = arbitro.Formacao;
            Categoria = arbitro.Categoria;
            Associacao = arbitro.Associacao;
        }
        
        /// <summary>
        /// Logicly deletes Arbitro. (Removes Access.)
        /// </summary>
        public void DeleteArbitro()
        {
            Active = false;
        }

        #endregion

    }
}
