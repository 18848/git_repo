using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GandaProjetoLP.Classes
{
    #region ENUMS
    /// <summary>
    /// Enumerado para Resultado de Operação
    /// </summary>
    enum POSICAO
    {
        ND,
        GuardaRedes,
        Defesa,
        Medio,
        Avancado
    }
    #endregion

    class Jogador : Pessoa
    {
        #region MEMBER VARIABLES
        private string alcunha;
        private int numero;
        private POSICAO posicao;
        #endregion


        #region CONSTRUCTORS
        /// <summary>
        /// Construtor cheio
        /// </summary>
        /// <param name="nome">Nome do Jogador</param>
        /// <param name="nacionalidade">Nacionalidade do Jogador</param>
        /// <param name="dataNascimento">Data de Nascimento do jogador</param>
        /// <param name="altura">Altura do jogador</param>
        /// <param name="peso">peso do jogador</param>
        /// <param name="alcunha">alcunha do jogador</param>
        /// <param name="numero">numero do jogador</param>
        /// <param name="posicao">posicao do jogador</param>
        public Jogador(string nome, string nacionalidade, DateTime dataNascimento, float altura, float peso, string alcunha, int numero, POSICAO posicao) : base(nome, nacionalidade, dataNascimento, altura, peso)
        {
            this.alcunha = alcunha;
            this.numero = numero;
            this.posicao = posicao;
            base.Nome = nome;
            base.Nacionalidade = nacionalidade;
            base.DataNascimento = dataNascimento;
            base.Altura = altura;
            base.Peso = peso;
        }


        /// <summary>
        /// Construtor vazio
        /// </summary>
        public Jogador()
        {
            this.alcunha = "";
            this.numero = 0;
            this.posicao = POSICAO.ND;
            base.Nome = "";
            base.Nacionalidade = "";
            base.DataNascimento = DateTime.Now;
            base.Altura = 0;
            base.Peso = 0;
        }
        #endregion


        #region PROPERTIES
        /// <summary>
        /// Manipula o atributo "alcunha"
        /// </summary>
        public string Alcunha
        {
            get { return alcunha; }
            set { alcunha = value; }
        }

        /// <summary>
        /// Manipula o atributo "numero"
        /// </summary>
        public int Numero
        {
            get { return numero; }
            set
            {
                if ((value > 0) && (value < 99))
                    numero = value;
            }
        }


        /// <summary>
        /// Manipula o atributo "posicao"
        /// </summary>
        public POSICAO Posicao
        {
            get { return posicao; }
            set { posicao = value; }
        }
        #endregion


        #region FUNCTIONS
        #endregion


        #region OVERIDES
        #endregion
    }
}
