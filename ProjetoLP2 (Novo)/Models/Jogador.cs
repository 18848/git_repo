using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLP2.Models
{
    public interface IJogador : IPessoa
    {
        string Alcunha { get; set; }
        int Numero { get; set; }
        POSICAO Posicao { get; set; }

        void UpdateJogador(IJogador jogador);
        void DeleteJogador();
    }

    [Serializable]
    public class Jogador : Pessoa, IJogador
    {
        #region MEMBER VARIABLES
        private string alcunha;
        private int numero;
        private POSICAO posicao;
        #endregion

        #region Constructors
        public Jogador() : base()
        {
            this.alcunha = "";
            this.numero = 0;
            this.posicao = POSICAO.ND;
        }
        #endregion

        #region PROPERTIES
        public string Alcunha
        {
            get { return alcunha; }
            set { alcunha = value; }
        }

        public int Numero
        {
            get { return numero; }
            set
            {
                if ((value > 0) && (value < 99))
                    numero = value;
            }
        }

        public POSICAO Posicao
        {
            get { return posicao; }
            set { posicao = value; }
        }
        #endregion

        #region Functions
        public void UpdateJogador(IJogador jogador)
        {
            Nome = jogador.Nome;
            Nacionalidade = jogador.Nacionalidade;
            DataNascimento = jogador.DataNascimento;
            Altura = jogador.Altura;
            Peso = jogador.Peso;
            Alcunha = jogador.Alcunha;
            Numero = jogador.Numero;
            Posicao = jogador.Posicao;
        }
        public void DeleteJogador()
        {
            Active = false;
        }
        #endregion
    }
}
