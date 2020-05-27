/*
*	<copyright file="ProjetoLP.Models.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Andre</author>
*   <date>5/27/2020 7:50:41 PM</date>
*	<description></description>
**/
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;

namespace ProjetoLP.Models
{
    public interface IGuardarJogador
    {
        bool AddJogador(IJogadorModel j);
        bool SaveJogadores(string file);
        bool LoadJogadores(string file);
        bool RemoveJogador(int id);
        List<IJogadorModel> GetJogadores();
    }

    [Serializable]
    /// <summary>
    /// Purpose:
    /// Created by: Andre
    /// Created on: 5/27/2020 7:50:41 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class GuardarJogador
    {
        #region Attributes
        List<IJogadorModel> jogadores;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public GuardarJogador()
        {
            jogadores = new List<IJogadorModel>();
        }

        #endregion

        #region Properties
        public bool AddJogador(IJogadorModel j)
        {
            if(jogadores != null)
            {
                if (jogadores.Contains(j))
                {
                    return false;
                }
                else
                {
                    j.Id = jogadores.Count + 1;
                    j.Active = true;
                    jogadores.Add(j);
                    return true;
                }
            }
            else
            {
                jogadores = new List<IJogadorModel>();
                jogadores.Add(j);
                return true;
            }
        }

        public bool SaveJogadores(string file)
        {
            if(jogadores != null)
            {
                try
                {
                    Stream stream = File.Open(file, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, jogadores);
                    stream.Close();
                    return true;
                }
                catch(IOException e)
                {
                    throw e;
                }
            }
            return true;
        }

        public bool LoadJogadores(string file)
        {
            if (File.Exists(file))
            {
                Stream stream = File.Open(file, FileMode.Open);
                BinaryFormatter bin = new BinaryFormatter();
                jogadores = (List<IJogadorModel>)bin.Deserialize(stream);
                stream.Close();
                return true;
            }            
            return true;
        }
        public bool RemoveJogador(int id)
        {
            foreach(Jogador j in jogadores)
                if (j.Id == id && j.Active)
                {
                    j.Active = false;
                    return true;
                }
            return false;
        }
        List<IJogadorModel> GetJogadores()
        {
            return jogadores;
        }
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #endregion
    }
}
