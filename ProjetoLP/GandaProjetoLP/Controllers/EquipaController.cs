/*
*	<copyright file="ProjetoLP.Controllers.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Andre</author>
*   <date>5/21/2020 6:44:03 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using ProjetoLP.Models;
using ProjetoLP.View;
using ProjetoLP.Auxilliary;

namespace ProjetoLP.Controllers
{
    public interface IEquipaController
    {
        void SetView(IEquipaView v);

        void SetNome(string n);
        void SetFundacao(DateTime f);
        bool SetJogador();
        void SetJogadores(Jogador j);
        
        string GetNome();
        DateTime GetFundacao();
        List<Jogador> GetJogadores();
        Jogador GetJogador(int index);

        void ShowData();

    }

    /// <summary>
    /// Purpose:
    /// Created by: Andre
    /// Created on: 5/21/2020 6:44:03 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class EquipaController : IEquipaController, IEquipaAuxilliary
    {
        private IEquipaView view;
        private IEquipaModel model;
        private IJogadorView jogador;

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public EquipaController()
        {
            model = new Equipa();

            #region View
            view = new EquipaView(this);

            view.SetNome();
            view.SetFundacao();
            view.SetJogador();
            view.SetJogadores();


            #endregion
        }

        #endregion

        #region Properties

        #region Setters.

        public void SetNome(string n)
        {
            model.Nome = n;
        }
        public void SetFundacao(DateTime f)
        {
            model.Fundacao = f;
        }
        //public Jogador SetJogador()
        //{
        //    Jogador jogador;
        //    try
        //    {
        //        jogador.SetAlcunha();
        //        jogador.SetNumero();
        //        jogador.SetPosicao();
        //    }
        //    catch(FormatException e)
        //    {
        //        return null;
        //    }
        //    catch(Exception e)
        //    {
        //        throw e;
        //    }
        //    return jogador;
        //}
        public void SetJogadores(Jogador j)
        {
            model.Jogadores.Add(j);
        }
        #endregion

        #region Getters.

        public string GetNome()
        {
            return model.Nome;
        }
        public DateTime GetFundacao()
        {
            return model.Fundacao;
        }
        public List<Jogador> GetJogadores()
        {
            //this.model.Jogadores.Sort();
            return model.Jogadores;
        }
        public Jogador GetJogador(int index)
        {
            return model.Jogadores[index];
        }
        #endregion

        public void ShowData()
        {
            Console.WriteLine("Nome: " + this.GetNome() );
            Console.WriteLine("Fundação: " + this.GetFundacao().Date );
            Console.WriteLine("Jogadores: ");
            //this.GetJogadores()
            Console.WriteLine("Escolha Jogador: ");
        }


        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        public void SetView(IEquipaView v)
        {
            this.view = v;
        }
        #endregion
        #endregion
    }
}
