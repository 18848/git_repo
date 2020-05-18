/*
*	<copyright file="GandaProjetoLP.View.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Andre</author>
*   <date>5/18/2020 5:20:23 PM</date>
*	<description></description>
**/
using GandaProjetoLP.Models;
using System;

namespace GandaProjetoLP.View
{
    public interface IArbitroView
    {
        void Formacao();
        void Categoria();
        void Associacao();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class ArbitroView : IArbitroView
    {
        #region Attributes
        private IArbitroController controller;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public ArbitroView()
        {
        }

        #endregion

        #region Properties
        public void Formacao()
        {
            string aux;
            DateTime f;

            Console.WriteLine("Data de Formação: ");
            aux = Console.ReadLine();
            
            if ( DateTime.TryParse(aux, out f) )
                controller.Formacao(f);
            
            ///else throw exception
        }

        public void Categoria()
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
                controller.Categoria(c);
        }

        public void Associacao()
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
                controller.Associacao(a);
        }
        #endregion


        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        
        #endregion
    }
}
