// -------------------------------------------------
//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="IPCA">
//     Copyright IPCA. All rights reserved.
// </copyright>
// <date> 24/04/2020 </date>
// <author> ZeCosgrove & AndreCardoso </author>
// <version>1.0</version>
// <desc>Projeto de LP2</desc>
//-------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoLP.Controllers;

namespace ProjetoLP
{

    #region ENUMS

    #region ARBITRO
    /// <summary>
    /// Enumerado para as possiveis CATEGORIAS
    /// </summary>
    public enum CATEGORIA
    {
        ND = 0,
        INTERNACIONAL,
        C1,
        C2,
        C3,
        C4,
        C5,
        C6,
        ESTAGIARIO
    }

    /// <summary>
    /// Enumerador para as possiveis ASSOCIACOES (distritos)
    /// </summary>
    public enum ASSOCIACAO
    {
        ND = 0,
        ALGARVE,
        ANGRA_HEROISMO,
        AVEIRO,
        BEJA,
        BRAGA,
        BRAGANCA,
        CASTELO_BRANCO,
        COIMBRA,
        EVORA,
        GUARDA,
        HORTA,
        LEIRIA,
        LISBOA,
        MADEIRA,
        PONTA_DELGADA,
        PORTALEGRE,
        PORTO,
        SANTAREM,
        SETUBAL,
        VIANA_CASTELO,
        VILA_REAL,
        VISEU
    }
    #endregion

    #region JOGADOR
    /// <summary>
    /// Enumerador para POSICAO
    /// </summary>
    public enum POSICAO
    {
        ND,
        GUARDA_REDES,
        DEFESA,
        MEDIO,
        AVANCADO
    }
    #endregion

    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }
}
