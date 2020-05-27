/*
*	<copyright file="ProjetoLP.View.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Andre</author>
*   <date>5/20/2020 6:27:56 PM</date>
*	<description></description>
**/
using ProjetoLP.Controllers;
using System;

namespace ProjetoLP.View
{
    public interface IJogadorView
    {
        void SetAlcunha();
        void SetNumero();
        void SetPosicao();
        void AddJogador();
        void EditJogador();

        void ShowData();
    }

    /// <summary>
    /// Purpose:
    /// Created by: Andre
    /// Created on: 5/20/2020 6:27:56 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class JogadorView : IJogadorView
    {
        private IJogadorController controller;
        
        #region Methods

        #region Constructors

        public JogadorView(IJogadorController c)
        {
            controller = c;
            controller.SetView(this);
        }

        #endregion

        #region Properties
        
        private void SetAlcunha()
        {
            Console.Write("Alcunha: ");
            controller.SetAlcunha(Console.ReadLine());
        }
        private void SetNumero()
        {
            Console.Write("Número: ");
            if( int.TryParse(Console.ReadLine(), out int aux) )
                controller.SetNumero(aux);
        }
        private void SetPosicao()
        {
            Console.Write("Posição: ");
            if (POSICAO.TryParse(Console.ReadLine(), out POSICAO aux))
                controller.SetPosicao(aux);
        }

        public void AddJogador()
        {
            SetAlcunha();
            SetNumero();
            SetPosicao();
            controller.AddJogador();
        }

        public void EditJogador()
        {
        }
        
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        public void ShowData()
        {
            Console.WriteLine("Alcunha: " + controller.GetAlcunha() );
            Console.WriteLine("Número: " + controller.GetNumero() );
            Console.WriteLine("Posição: " + controller.GetPosicao() );
        }
        #endregion

        #endregion
    }
}
