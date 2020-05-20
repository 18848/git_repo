/*
*	<copyright file="GandaProjetoLP.View.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Andre</author>
*   <date>5/18/2020 5:20:23 PM</date>
*	<description></description>
**/
using System;
using ProjetoLP;
using ProjetoLP.Controllers;

namespace ProjetoLP.View
{
    public interface IArbitroView
    {
        void SetFormacao();
        void SetCategoria();
        void SetAssociacao();

        void ShowData();
    }

    /// <summary>
    /// Arbitro View.
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class ArbitroView : IArbitroView
    {
        private IArbitroController controller;

        #region Constructors

        /// <summary>
        /// View Constructor. Sets |Controller - View| relationship.
        /// </summary>
        /// <param name="aC"> Controller. </param>
        public ArbitroView(IArbitroController aC)
        {
            controller = aC;
            controller.SetView(this);
        }

        #endregion

        #region Properties
        public void SetFormacao()
        {
            string aux;
            DateTime f;

            Console.Write("Data de Formação: ");
            aux = Console.ReadLine();
            
            if ( DateTime.TryParse(aux, out f) )
                controller.SetFormacao(f);
            
            ///else throw exception
        }

        public void SetCategoria()
        {
            string aux;
            CATEGORIA c;

            Console.WriteLine("1 -> INTERNATIONAL");
            Console.WriteLine("2 -> C1");
            Console.WriteLine("3 -> C2");
            Console.WriteLine("4 -> C3");
            Console.WriteLine("5 -> C4");
            Console.WriteLine("6 -> C5");
            Console.WriteLine("7 -> C6");
            Console.WriteLine("8 -> ESTAGIARIO");
            Console.Write("Categoria: ");
            aux = Console.ReadLine();

            if (CATEGORIA.TryParse(aux, out c))
                controller.SetCategoria(c);
        }

        public void SetAssociacao()
        {
            string aux;
            ASSOCIACAO a;
            #region WriteLine
            Console.WriteLine(" 1 -> ALGARVE");
            Console.WriteLine(" 2 -> ANGRA_HEROISMO");
            Console.WriteLine(" 3 -> AVEIRO");
            Console.WriteLine(" 4 -> BEJA");
            Console.WriteLine(" 5 -> BRAGA");
            Console.WriteLine(" 6 -> BRAGANCA");
            Console.WriteLine(" 7 -> CASTELO_BRANCO");
            Console.WriteLine(" 8 -> COIMBRA");
            Console.WriteLine(" 9 -> EVORA");
            Console.WriteLine("10 -> GUARDA");
            Console.WriteLine("11 -> HORTA");
            Console.WriteLine("12 -> LEIRIA");
            Console.WriteLine("13 -> LISBOA");
            Console.WriteLine("14 -> MADEIRA");
            Console.WriteLine("15 -> PONTA_DELGADA");
            Console.WriteLine("16 -> COIMBRA");
            Console.WriteLine("17 -> PORTALEGRE");
            Console.WriteLine("18 -> PORTO");
            Console.WriteLine("19 -> SANTAREM");
            Console.WriteLine("20 -> SETUBAL");
            Console.WriteLine("21 -> VIANA_CASTELO");
            Console.WriteLine("22 -> VILA_REAL");
            Console.WriteLine("23 -> VISEU");
            #endregion
            Console.Write("Categoria: ");
            aux = Console.ReadLine();

            if (ASSOCIACAO.TryParse(aux, out a))
                controller.SetAssociacao(a);
            //else
                //Console.WriteLine(Exception e);
        }
        #endregion


        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// Presents Data to Screen.
        /// </summary>
        public void ShowData()
        {
            Console.WriteLine("Formação:" + controller.GetFormacao().Date);
            Console.WriteLine("Categoria:" + controller.GetCategoria());
            Console.WriteLine("Associação:" + controller.GetAssociacao());
        }
        #endregion
    }
}
