using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoLP2.Views;
using ProjetoLP2.Controllers;

namespace ProjetoLP2
{
    #region Enums
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
    public enum POSICAO
    {
        ND,
        GUARDA_REDES,
        DEFESA,
        MEDIO,
        AVANCADO
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            PessoaController pessoa = new PessoaController();
            MenuView menu = new MenuView(pessoa);

            menu.Menu();
        }
    }
}
