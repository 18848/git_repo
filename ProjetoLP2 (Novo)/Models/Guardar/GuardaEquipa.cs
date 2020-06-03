using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProjetoLP2.Models.Guardar
{
    public interface IGuardaEquipa
    {
        bool Add(IEquipa i);
        bool Save(string fileName);
        bool Load(string fileName);
        IEquipa Find(int id);
        bool FindJogador(int id);
        List<IEquipa> GiveList();
    }

    [Serializable]
    class GuardaEquipa : IGuardaEquipa
    {
        #region Member Values
        public List<IEquipa> list;
        #endregion

        #region Constructors
        public GuardaEquipa()
        {
            list = new List<IEquipa>();
        }
        #endregion

        #region Functions
        public bool Add(IEquipa i)
        {
            if (list != null)
            {
                if (list.Contains(i))
                {
                    return false;
                }
                else
                {
                    list.Add(i);
                    return true;
                }
            }
            else
            {
                list = new List<IEquipa>();
                list.Add(i);
                return true;
            }
        }

        public bool Save(string fileName)
        {
            if (list != null)
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, list);
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

        public bool Load(string fileName)
        {
            if (File.Exists(fileName))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Open);
                    BinaryFormatter bin = new BinaryFormatter();
                    list = (List<IEquipa>)bin.Deserialize(stream);
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

        public IEquipa Find(int id)
        {
            int index = 0;
            IEquipa e = new Equipa();

            foreach (IEquipa i in list)
            {
                index++;
                if (index == id)
                {
                    e = i;
                    break;
                }
            }
            return e;
        }

        public List<IEquipa> GiveList()
        {
            return list;
        }

        public bool FindJogador(int id)
        {
            foreach (IEquipa i in list)
            {
                if(i.Jogadores != null)
                {
                    foreach (int j in i.Jogadores)
                    {
                        if (j == id)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        #endregion
    }
}
