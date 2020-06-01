using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoLP2.Models;

namespace ProjetoLP2.Models
{
    public interface IJogo
    {
        Equipa EquipaA { get; set; }
        Equipa EquipaB { get; set; }
        List<IArbitro> Arbitros { get; set; }

        void UpdatePessoa(IPessoa pessoa);
        void DeletePessoa();
    }

    public class Jogo
    {

        #region MEMBER VARIABLES
        private Equipa equipaA;
        private Equipa equipaB;
        private List<int> arbitros;
        #endregion


        #region CONSTRUCTORS


        /// <summary>
        /// The Default Constructur.
        /// </summary>
        public Jogo()
        {
            EquipaA = null;
            EquipaB = null;
            Arbitros = null;
        }
        #endregion


        #region PROPERTIES
        /// <summary>
        /// Manipula o atributo "equipaA"
        /// </summary>
        public Equipa EquipaA
        {
            get { return equipaA; }
            set { equipaA = value; }
        }

        /// <summary>
        /// Manipula o atributo "EquipaB"
        /// </summary>
        public Equipa EquipaB
        {
            get { return equipaB; }
            set { equipaB = value; }
        }

        /// <summary>
        /// Manipula o atributo "Arbitros"
        /// </summary>
        public List<int> Arbitros
        {
            get { return arbitros; }
            set { arbitros = value; }
        }
        #endregion


        #region FUNCTIONS

        public void UpdatePessoa(IPessoa pessoa)
        {
            Nome = pessoa.Nome;
            Nacionalidade = pessoa.Nacionalidade;
            DataNascimento = pessoa.DataNascimento;
            Altura = pessoa.Altura;
            Peso = pessoa.Peso;
        }
        public void DeletePessoa()
        {
            Active = false;
        }

        #endregion

    }
}
