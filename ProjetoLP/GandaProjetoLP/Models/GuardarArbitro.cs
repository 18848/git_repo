/*
*	<copyright file="ProjetoLP.Models.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Andre</author>
*   <date>5/27/2020 11:06:21 PM</date>
*	<description></description>
**/
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProjetoLP.Models
{
    public interface IGuardarArbitro
    {
        bool AddArbitro(IArbitroModel a);
        bool SaveArbitros(string file);
        bool LoadArbitros(string file);
        bool RemoveArbitros(int id);
    }

    /// <summary>
    /// Purpose:
    /// Created by: Andre
    /// Created on: 5/27/2020 11:06:21 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class GuardarArbitro : IGuardarArbitro
    {
        #region Attributes
        private List<IArbitroModel> arbitros;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public GuardarArbitro()
        {
            arbitros = new List<IArbitroModel>();
        }

        #endregion

        #region Properties
        public bool AddArbitro(IArbitroModel a)
        {
            if (arbitros != null)
            {
                if (arbitros.Contains(a))
                {
                    return false;
                }
                else
                {
                    a.Id = arbitros.Count + 1;
                    a.Active = true;
                    arbitros.Add(a);
                    return true;
                }
            }
            else
            {
                arbitros = new List<IArbitroModel>();
                arbitros.Add(a);
                return true;
            }
        }

        public bool SaveArbitros(string file)
        {
            if (arbitros != null)
            {
                try
                {
                    Stream stream = File.Open(file, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, arbitros);
                    stream.Close();
                    return true;
                }
                catch (IOException e)
                {
                    throw e;
                }
            }
            return true;
        }

        public bool LoadArbitros(string file)
        {
            if (File.Exists(file))
            {
                Stream stream = File.Open(file, FileMode.Open);
                BinaryFormatter bin = new BinaryFormatter();
                arbitros = (List<IArbitroModel>)bin.Deserialize(stream);
                stream.Close();
                return true;
            }
            return true;
        }
        public bool RemoveArbitros(int id)
        {
            foreach (Arbitro a in arbitros)
                if (a.Id == id && a.Active)
                {
                    a.Active = false;
                    return true;
                }
            return false;
        }

        public List<IArbitroModel> GetArbitro()
        {
            return arbitros;
        }
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #endregion
    }
}
