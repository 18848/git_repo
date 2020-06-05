using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProjetoLP2.Models.Guardar
{
    public interface IGuardaJogador
    {
        bool Add(IJogador i);
        bool Save(string fileName);
        bool Load(string fileName);
        IJogador Find(int id);
        List<IJogador> GiveList();
    }

    [Serializable]
    class GuardaJogador : IGuardaJogador
    {
        #region Member Values
        public List<IJogador> list;
        #endregion

        #region Constructors
        public GuardaJogador()
        {
            list = new List<IJogador>();
        }
        #endregion

        #region Functions
        public bool Add(IJogador i)
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
                list = new List<IJogador>();
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
                    list = (List<IJogador>)bin.Deserialize(stream);
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

        public IJogador Find(int id)
        {
            int index = 0;
            IJogador j = new Jogador();

            foreach (IJogador i in list)
            {
                index++;
                if (index == id)
                {
                    j = i;
                    break;
                }
            }
            return j;
        }

        public List<IJogador> GiveList()
        {
            return list;
        }
        #endregion
    }
}
