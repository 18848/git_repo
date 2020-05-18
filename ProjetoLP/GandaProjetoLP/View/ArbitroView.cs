/*
*	<copyright file="GandaProjetoLP.View.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Andre</author>
*   <date>5/18/2020 5:20:23 PM</date>
*	<description></description>
**/
using System;
using ProjetoLP.Controllers;
using ProjetoLP.Models;

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

            Console.WriteLine("Data de Formação: ");
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
            Console.WriteLine("Categoria: ");
            aux = Console.ReadLine();

            if (CATEGORIA.TryParse(aux, out c))
                controller.SetCategoria(c);
        }

        public void SetAssociacao()
        {
            string aux;
            ASSOCIACAO a;

            Console.WriteLine("1 -> ALGARVE");
            //Console.WriteLine("2 -> BRAGA");
            //Console.WriteLine("3 -> C2");
            //Console.WriteLine("4 -> C3");
            //Console.WriteLine("5 -> C4");
            //Console.WriteLine("6 -> C5");
            //Console.WriteLine("7 -> C6");
            Console.WriteLine("8 -> VISEU");
            Console.WriteLine("Categoria: ");
            aux = Console.ReadLine();

            if ( ASSOCIACAO.TryParse(aux, out a) )
                controller.SetAssociacao(a);
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
            Console.WriteLine("Formação:" + controller.GetFormacao());
            Console.WriteLine("Categoria:" + controller.GetCategoria());
            Console.WriteLine("Associação:" + controller.GetAssociacao());
        }
        #endregion
    }
}
