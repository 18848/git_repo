using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using ProjetoLP2.Models;

namespace ProjetoLP2.Models
{
    public interface IGuardaPessoa
    {
        bool Add(IPessoa i);
        bool Save(string fileName);
        bool Load(string fileName);
        //bool Remove(int id);
        List<IPessoa> GiveList();
        IPessoa Find(int id);
    }

    [Serializable]
    class GuardaPessoa : IGuardaPessoa
    {
        #region Member Values
        public List<IPessoa> list;
        #endregion

        #region Constructors
        public GuardaPessoa()
        {
            list = new List<IPessoa>();
        }
        #endregion

        #region Functions
        public bool Add(IPessoa i)
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
                list = new List<IPessoa>();
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
                    list = (List<IPessoa>)bin.Deserialize(stream);
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

        public IPessoa Find(int id)
        {
            int index = 0;
            IPessoa p = new Pessoa();

            foreach (IPessoa i in list)
            {
                index++;
                if (index == id)
                {
                    p = i;
                }
            }
            return p;
        }

        public List<IPessoa> GiveList()
        {
            return list;
        }


        /*public bool Remove(int id)
        {
            IPessoa i = Find(id);
            if (i != null)
            {
                i.IsAtivo = false;
                return true;
            }
            return false;
        }*/
        #endregion
    }
}
