/*
*	<copyright file="ProjetoLP.View.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Andre</author>
*   <date>5/21/2020 6:48:39 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using ProjetoLP.Controllers;
using ProjetoLP.Models;

namespace ProjetoLP.View
{
    public interface IEquipaView
    {
        void SetNome();
        void SetFundacao();
        void SetJogador();
        void SetJogadores();
    }

    /// <summary>
    /// Purpose:
    /// Created by: Andre
    /// Created on: 5/21/2020 6:48:39 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class EquipaView : IEquipaView
    {
        IEquipaController controller;

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public EquipaView(IEquipaController c)
        {
            this.controller = c;
            this.controller.SetView(this);
        }

        #endregion

        #region Properties
        void SetNome()
        {
            Console.Write("Nome: ");
            controller.SetNome(Console.ReadLine());
        }
        void SetFundacao()
        {
            DateTime aux;
            Console.Write("Data de Fundação: ");
            if (DateTime.TryParse(Console.ReadLine(), out aux))
                controller.SetFundacao(aux);
        }
        void SetJogador()
        {
            Console.WriteLine("Insira Jogador.");
            controller.SetJogador();
        }

        void SetJogadores()
        {
            Jogador j;
            bool b;
            Console.WriteLine("Insira Jogadores.");
            do
            {
                b = controller.SetJogador();
                j = controller.GetJogador(j.GetIndex);
            } while (b);
            controller.SetJogadores()
        }
        #endregion


        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~EquipaView()
        {
        }
        #endregion

        #endregion
    }
}
