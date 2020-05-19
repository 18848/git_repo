/*
*	<copyright file="GandaProjetoLP.View.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Andre</author>
*   <date>5/18/2020 7:18:33 PM</date>
*	<description></description>
**/
using GandaProjetoLP.Controllers;
using System;

namespace ProjetoLP.View
{
    public interface IPessoaView
    {
        void SetNome();
        void SetNacionalidade();
        void SetDataNascimento();
        void SetAltura();
        void SetPeso();

        void ShowData();
    }

    /// <summary>
    /// Purpose:
    /// Created by: Andre
    /// Created on: 5/18/2020 7:18:33 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class PessoaView : IPessoaView
    {
        private IPessoaController controller;

        #region Methods

        #region Constructors
        /// <summary>
        /// View Constructor.
        /// Sets | Controller - View | reference.
        /// </summary>
        /// <param name="c"> Controller. </param>
        public PessoaView(IPessoaController c)
        {
            controller = c;
            controller.SetView(this);
        }

        #endregion

        #region Properties

        public void SetNome()
        {
            Console.WriteLine("Nome: ");
            controller.SetNome(Console.ReadLine());
        }
        public void SetNacionalidade()
        {
            Console.WriteLine("Nacionalidade: ");
            controller.SetNacionalidade(Console.ReadLine());
        }
        public void SetDataNascimento()
        {
            DateTime aux;

            Console.WriteLine("Data de Nascimento: ");
            if (DateTime.TryParse(Console.ReadLine(), out aux))
                controller.SetDataNascimento(aux);
        }
        public void SetAltura()
        {
            float aux;

            Console.WriteLine("Altura: "); 
            if (float.TryParse(Console.ReadLine(), out aux))
                controller.SetAltura(aux);
        }
        public void SetPeso()
        {
            float aux;

            Console.WriteLine("Peso: ");
            if ( float.TryParse(Console.ReadLine(), out aux) )
                controller.SetPeso(aux);
        }
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        public void ShowData()
        {
            //Console.WriteLine("Nome: " + controller.Get)
        }
        #endregion

        #endregion
    }
}
