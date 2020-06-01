using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLP2.Models
{
    public interface IEquipa
    {
        string Nome { get; set; }
        DateTime Fundacao { get; set; }
        List<int> Jogadores { get; set; }
        bool Active { get; set; }

        void UpdateEquipa(IEquipa equipa);
        void DeleteEquipa();
    }

    public class Equipa : IEquipa
    {
        #region MEMBER VARIABLES
        private string nome;
        private DateTime fundacao;
        private List<int> jogadores;
        private bool active;
        #endregion

        #region CONSTRUCTORS
        public Equipa()
        {
            Nome = "";
            Fundacao = DateTime.Now;
            Jogadores = null;
        }
        #endregion

        #region PROPERTIES
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public DateTime Fundacao
        {
            get { return fundacao; }
            set { fundacao = value; }
        }
        public List<int> Jogadores
        {
            get { return jogadores; }
            set { jogadores = value; }
        }
        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        #endregion

        #region FUNCTIONS
        public void UpdateEquipa(IEquipa equipa)
        {
            Nome = equipa.Nome;
            Fundacao = equipa.Fundacao;
        }

        public void DeleteEquipa()
        {
            Active = false;
        }
        #endregion
    }
}
