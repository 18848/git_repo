using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProjetoLP2.Models.Guardar
{
    public interface IGuardaCompeticao
    {
        bool Add(ICompeticao i);
        bool Save(string fileName);
        bool Load(string fileName);
        ICompeticao Find(int id);
        bool FindEquipa(int id);
        List<ICompeticao> GiveList();
    }

    [Serializable]
    public class GuardaCompeticao : IGuardaCompeticao
    {
        #region Member Values
        public List<ICompeticao> list;
        #endregion

        #region Constructors
        public GuardaCompeticao()
        {
            list = new List<ICompeticao>();
        }
        #endregion

        #region Functions
        public bool Add(ICompeticao i)
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
                list = new List<ICompeticao>();
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
                    list = (List<ICompeticao>)bin.Deserialize(stream);
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

        public ICompeticao Find(int id)
        {
            int index = 0;
            ICompeticao c = new Competicao();

            foreach (ICompeticao i in list)
            {
                index++;
                if (index == id)
                {
                    c = i;
                    break;
                }
            }
            return c;
        }

        public List<ICompeticao> GiveList()
        {
            return list;
        }

        public bool FindEquipa(int id)
        {
            foreach (ICompeticao i in list)
            {
                if (i.Equipas != null)
                {
                    foreach (int j in i.Equipas)
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
