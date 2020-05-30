/*
*	<copyright file="ProjetoLP.Models.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Andre</author>
*   <date>5/28/2020 3:49:21 PM</date>
*	<description></description>
**/
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProjetoLP.Models
{
    public interface IGuardarCompeticao
    {
        bool AddCompeticao(ICompeticaoModel e);
        bool SaveCompeticoes(string file);
        bool LoadCompeticoes(string file);
        bool RemoveCompeticao(int id);
        List<ICompeticaoModel> GetCompeticoes();
        ICompeticaoModel GetCompeticao(int id);
    }

    /// <summary>
    /// Purpose:
    /// Created by: Andre
    /// Created on: 5/28/2020 3:49:21 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class GuardarCompeticao : IGuardarCompeticao
    {
        #region Attributes

        IGuardarEquipa gEquipa;

        private List<ICompeticaoModel> competicoes;
        private List<IEquipaModel> equipas;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public GuardarCompeticao()
        {
            competicoes = new List<ICompeticaoModel>();
            equipas = gEquipa.GetEquipas();
        }

        #endregion

        #region Properties

        public bool AddCompeticao(ICompeticaoModel c)
        {
            if (competicoes != null)
            {
                if (competicoes.Contains(c))
                {
                    return false;
                }
                else
                {
                    c.Id = competicoes.Count + 1;
                    c.Active = true;
                    competicoes.Add(c);
                    return true;
                }
            }
            else
            {
                competicoes = new List<ICompeticaoModel>();
                c.Id = competicoes.Count + 1;
                c.Active = true;
                competicoes.Add(c);
                return true;
            }
        }

        public bool SaveCompeticoes(string file)
        {
            if (competicoes != null)
            {
                try
                {
                    Stream stream = File.Open(file, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, competicoes);
                    stream.Close();
                    return true;
                }
                catch (IOException e)
                {
                    throw e;
                }
            }
            return false;
        }

        public bool LoadCompeticoes(string file)
        {
            if (File.Exists(file))
            {
                Stream stream = File.Open(file, FileMode.Open);
                BinaryFormatter bin = new BinaryFormatter();
                competicoes = (List<ICompeticaoModel>)bin.Deserialize(stream);
                stream.Close();
                return true;
            }
            return false;
        }

        public bool RemoveCompeticao(int id)
        {
            foreach (ICompeticaoModel c in competicoes)
                if (c.Id == id && c.Active)
                {
                    c.Active = false;
                    return true;
                }
            return false;
        }

        public List<ICompeticaoModel> GetCompeticoes()
        {
            return competicoes;
        }

        public ICompeticaoModel GetCompeticao(int id)
        {
            return competicoes[id];
        }

        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #endregion
    }
}
