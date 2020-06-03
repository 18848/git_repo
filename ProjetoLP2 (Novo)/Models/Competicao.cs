using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLP2.Models
{
    public interface ICompeticao
    {
        string Nome { get; set; }
        DateTime Inicio { get; set; }
        DateTime Fim { get; set; }
        List<int> Equipas { get; set; }
        bool Active { get; set; }

        void UpdateCompeticao(ICompeticao competicao);
        void DeleteCompeticao();
        void UpdateEquipa(int id);
        void DeleteEquipa(int id);
    }

    [Serializable]
    public class Competicao : ICompeticao
    {
        #region MEMBER VARIABLES
        private string nome;
        private DateTime inicio;
        private DateTime fim;
        private List<int> equipas;
        private bool active;
        #endregion

        #region CONSTRUCTORS
        public Competicao()
        {
            inicio = DateTime.Now;
        }
        #endregion

        #region PROPERTIES
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public DateTime Inicio
        {
            get { return inicio; }
            set { inicio = value; }
        }
        public DateTime Fim
        {
            get { return fim; }
            set { fim = value; }
        }
        public List<int> Equipas
        {
            get { return equipas; }
            set { equipas = value; }
        }
        public bool Active
        {
            get { return active; }
            set { active = value; }
        }
        #endregion

        #region FUNCTIONS
        public void UpdateCompeticao(ICompeticao competicao)
        {
            Nome = competicao.Nome;
            Inicio = competicao.Inicio;
            Fim = competicao.Fim;
        }

        public void DeleteCompeticao()
        {
            Active = false;
        }

        public void UpdateEquipa(int id)
        {
            if (Equipas == null)
            {
                Equipas = new List<int>();
            }

            Equipas.Add(id);
        }


        public void DeleteEquipa(int id)
        {
            Equipas.Remove(id);
        }
        #endregion

    }
}
