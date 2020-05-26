/*
*	<copyright file="ProjetoLP.View.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Andre</author>
*   <date>5/18/2020 5:20:23 PM</date>
*	<description></description>
**/
using ProjetoLP.Controllers;
using System;

namespace ProjetoLP.View
{
    public interface IArbitroView
    {
        void SetFormacao();
        void SetCategoria();
        void SetAssociacao();
        void SetId();

        void ShowData();
    }

    /// <summary>
    /// Arbitro View.
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class ArbitroView : IArbitroView
    {
        private readonly IArbitroController controller;

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
            Console.Write("Data de Formação: ");
            if ( DateTime.TryParse(Console.ReadLine(), out DateTime f) )
                controller.SetFormacao(f);
            
            ///else throw exception
        }

        public void SetCategoria()
        {
            foreach (CATEGORIA foo in Enum.GetValues(typeof(CATEGORIA)))
            {
                Console.WriteLine(foo + " = " + ((int)foo).ToString());
            }
            Console.Write("Categoria: ");
            if (CATEGORIA.TryParse(Console.ReadLine(), out CATEGORIA c))
                controller.SetCategoria(c);
        }

        public void SetAssociacao()
        {
            foreach (ASSOCIACAO foo in Enum.GetValues(typeof(ASSOCIACAO)))
            {
                Console.WriteLine(foo + " = " + ((int)foo).ToString());
            }
            Console.Write("Categoria: ");
            if (ASSOCIACAO.TryParse(Console.ReadLine(), out ASSOCIACAO a))
                controller.SetAssociacao(a);
            //else
                //Console.WriteLine(Exception e);
        }
        
        public void SetId()
        {

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
