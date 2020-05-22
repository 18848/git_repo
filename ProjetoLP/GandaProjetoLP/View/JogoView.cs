using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoLP.Controllers;
using ProjetoLP.Models;

namespace ProjetoLP.View
{
    public interface IJogoView
    {
        void SetEquipaA(); 
        void SetEquipaB();
        void SetArbitros();

        void GetEquipaA();
        void GetEquipaB();
        void GetArbitros();

        void ShowData();
    }

    /// <summary>
    /// Purpose:
    /// Created by: Ze
    /// Created on: 5/21/2020 7:18:15 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    class JogoView : IJogoView
    {
        private readonly IJogoController controller;

        #region Constructors
        /// <summary>
        /// View Constructor. Sets |Controller - View| relationship.
        /// </summary>
        /// <param name="jC"> Controller. </param>
        public JogoView(IJogoController jC)
        {
            controller = jC;
            controller.SetView(this);
        }
        #endregion

        #region Properties
        public void SetEquipaA()
        {
            Equipa equipa = new Equipa();

            Console.WriteLine("Insira a Equipa Visitada: ");
            equipa.Nome = Console.ReadLine();

            controller.SetEquipaA(equipa);
        }
        public void SetEquipaB()
        {
            Equipa equipa = new Equipa();

            Console.WriteLine("Insira a Equipa Visitante: ");
            equipa.Nome = Console.ReadLine();

            controller.SetEquipaB(equipa);
        }
        public void SetArbitros()
        {
            int count = 0;
            List<Arbitro> arbitros = new List<Arbitro>();
            Arbitro arbitro = new Arbitro();

            Console.WriteLine("Quantos arbitros vai inserir? ");
            int.TryParse(Console.ReadLine(), out count);

            for (int i=0; i<count; i++)
            {
                arbitro.Nome = Console.ReadLine();
                arbitros.Add(arbitro);
            }

            controller.SetArbitros(arbitros);
        }

        public void GetEquipaA()
        {
            Console.WriteLine(controller.GetEquipaA());
        }
        public void GetEquipaB()
        {
            Console.WriteLine(controller.GetEquipaB());
        }
        public void GetArbitros()
        {
            controller.GetArbitros().ForEach(delegate (Arbitro arbitro)
            {
                Console.WriteLine(arbitro.Nome);
            });
        }

        public void ShowData()
        {

        }
        #endregion

    }
}
