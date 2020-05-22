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
        bool SetJogador(IJogadorView jC);
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
        public void SetNome()
        {
            Console.Write("Nome: ");
            controller.SetNome(Console.ReadLine());
        }
        public void SetFundacao()
        {
            DateTime aux;
            Console.Write("Data de Fundação: ");
            if (DateTime.TryParse(Console.ReadLine(), out aux))
                controller.SetFundacao(aux);
        }
        //#region SetJogadores
        //private bool SetJogador(int id, out )
        //{
        //    Console.WriteLine("Equipa Nova.");
        //    try
        //    {
        //        //newJogador = new JogadorController();
        //    }
        //    catch (FormatException e)
        //    {
        //        Console.WriteLine(e.Message);
        //        newJogador = null;
        //        return false;
        //    }
        //    catch (OverflowException e)
        //    {
        //        Console.WriteLine(e.Message);
        //        newJogador = null;
        //        return false;
        //    }
        //    return true;
        //}
        //public void SetJogadores()
        //{
        //    List<Jogador> jogadorList = new List<Jogador>();
        //    Console.WriteLine("Insira os arbitros. ('.' para parar)");
        //    JogadorController newJogador;
        //    while (SetJogador(1, out newJogador))
        //    {
        //        Jogador aux = new Jogador(newJogador.GetAlcunha(), newJogador.GetNumero(),
        //            newJogador.GetPosicao(), newJogador.GetNome(), newJogador.GetNacionalidade(),
        //            newJogador.GetDataNascimento(), newJogador.GetAltura(), newJogador.GetPeso());
        //        jogadorList.Add(aux);
        //    }
        //    controller.SetJogadores(jogadorList);
        //}

        //#endregion


        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #endregion
    }
}
