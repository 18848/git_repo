/*
*	<copyright file="GandaProjetoLP.View.cs" company="IPCA">
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
        IJogadorController controller;

        #region Methods

        #region Constructors

        public JogadorView(IJogadorController c)
        {
            controller = c;
            controller.SetView(this);
        }

        #endregion

        #region Properties
        
        public void SetAlcunha()
        {
            Console.Write("Alcunha: ");
            controller.SetAlcunha(Console.ReadLine());
        }
        public void SetNumero()
        {
            int aux;

            Console.Write("Número: ");
            if( int.TryParse(Console.ReadLine(), out aux) )
                controller.SetNumero(aux);
        }
        public void SetPosicao()
        {
            POSICAO aux;

            Console.Write("Posição: ");
            if (POSICAO.TryParse(Console.ReadLine(), out aux))
                controller.SetPosicao(aux);
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
