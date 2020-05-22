/*
*	<copyright file="ProjetoLP.View.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Andre</author>
*   <date>5/21/2020 7:18:15 PM</date>
*	<description></description>
**/
using System;
using ProjetoLP.Controllers;
using ProjetoLP.Models;
using System.Collections.Generic;

namespace ProjetoLP.View
{
    public interface ICompeticaoView
    {
        void SetEquipas();
        void SetArbitros();
        void SetInicio();
        void SetFim();

        void GetEquipas();
        void GetInicio();
        void GetFim();

        void ShowData();
    }

    /// <summary>
    /// Purpose:
    /// Created by: Ze
    /// Created on: 5/21/2020 7:18:15 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class CompeticaoView : ICompeticaoView
    {
        private readonly ICompeticaoController controller;

        #region Constructors
        /// <summary>
        /// View Constructor. Sets |Controller - View| relationship.
        /// </summary>
        /// <param name="cC"> Controller. </param>
        public CompeticaoView(ICompeticaoController cC)
        {
            controller = cC;
            controller.SetView(this);
        }
        #endregion

        #region Properties

        #region SetEquipa
        private bool SetEquipa(out EquipaController newEquipa)
        {
            Console.WriteLine("Equipa Nova.");
            try
            {
                newEquipa = new EquipaController();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                newEquipa = null;
                return false;
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                newEquipa = null;
                return false;
            }
            return true;
        }
        public void SetEquipas()
        {
            List<Equipa> equipaList = new List<Equipa>();
            Console.WriteLine("Insira as equipas. ('.' para parar)");
            EquipaController newEquipa;
            while(SetEquipa(out newEquipa)) 
            {
                Equipa aux = new Equipa(newEquipa.GetNome(), newEquipa.GetFundacao(), newEquipa.GetJogadores());
                equipaList.Add(aux); 
            }
            controller.SetEquipas(equipaList);
        }
        #endregion

        #region SetArbitro
        private bool SetArbitro(out ArbitroController newArbitro)
        {
            Console.WriteLine("Equipa Nova.");
            try
            {
                newArbitro= new ArbitroController();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                newArbitro= null;
                return false;
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                newArbitro = null;
                return false;
            }
            return true;
        }
        public void SetArbitros()
        {
            List<Arbitro> arbitroList = new List<Arbitro>();
            Console.WriteLine("Insira os arbitros. ('.' para parar)");
            ArbitroController newArbitro;
            while (SetArbitro(out newArbitro))
            {
                Arbitro aux = new Arbitro(newArbitro.GetFormacao(), newArbitro.GetCategoria(), 
                    newArbitro.GetAssociacao(), newArbitro.GetNome(), newArbitro.GetNacionalidade(),
                    newArbitro.GetDataNascimento(), newArbitro.GetAltura(), newArbitro.GetPeso());
                arbitroList.Add(aux);
            }
            controller.SetArbitros(arbitroList);
        }
        #endregion

        #region SetJogadores
        private bool SetJogador(out JogadorController newJogador)
        {
            Console.WriteLine("Equipa Nova.");
            try
            {
                newJogador = new JogadorController();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                newJogador = null;
                return false;
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                newJogador = null;
                return false;
            }
            return true;
        }
        public void SetJogadores()
        {
            List<Jogador> jogadorList = new List<Jogador>();
            Console.WriteLine("Insira os arbitros. ('.' para parar)");
            JogadorController newJogador;
            while (SetJogador(out newJogador))
            {
                Jogador aux = new Jogador(newJogador.GetAlcunha(), newJogador.GetNumero(),
                    newJogador.GetPosicao(), newJogador.GetNome(), newJogador.GetNacionalidade(),
                    newJogador.GetDataNascimento(), newJogador.GetAltura(), newJogador.GetPeso());
                jogadorList.Add(aux);
            }
            controller.SetJogadores(jogadorList);
        }
        #endregion


        public void SetInicio()
        {
            Console.Write("Data de Inicio: ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime i))
                controller.SetInicio(i);
        }

        public void SetFim()
        {
            Console.Write("Data de Fim: ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime f))
                controller.SetFim(f);
        }

        public void GetEquipas()
        {
            controller.GetEquipas().ForEach(delegate (Equipa equipa)
            {
                Console.WriteLine(equipa.Nome);
            });
        }

        public void GetInicio()
        {
            Console.WriteLine(controller.GetInicio().ToString());
        }

        public void GetFim()
        {
            Console.WriteLine(controller.GetFim().ToString());
        }

        public void ShowData()
        {
        }

        #endregion
    }
}
