using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace ProjetoLP2.Models.Guardar
{
    public interface IGuardaJogo
    {
        bool Add(IJogo i);
        bool Save(string fileName);
        bool Load(string fileName);
        IJogo Find(int id);
        bool FindArbitro(int id);
        List<IJogo> GiveList();
    }

    [Serializable]
    public class GuardaJogo : IGuardaJogo
    {
        #region Member Values
        public List<IJogo> list;
        #endregion

        #region Constructors
        public GuardaJogo()
        {
            list = new List<IJogo>();
        }
        #endregion

        #region Functions
        public bool Add(IJogo i)
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
                list = new List<IJogo>();
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
                    list = (List<IJogo>)bin.Deserialize(stream);
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

        public IJogo Find(int id)
        {
            int index = 0;
            IJogo e = new Jogo();

            foreach (IJogo i in list)
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

        public List<IJogo> GiveList()
        {
            return list;
        }

        public bool FindArbitro(int id)
        {
            foreach (IJogo i in list)
            {
                if (i.Arbitros != null)
                {
                    foreach (int j in i.Arbitros)
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
