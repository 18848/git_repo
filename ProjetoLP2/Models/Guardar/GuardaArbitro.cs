using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetoLP2.Models.Guardar
{
    public interface IGuardaArbitro
    {
        bool AddArbitro(IArbitro i);
        bool Save(string fileName);
        bool Load(string fileName);
        List<IArbitro> GiveList();
        IArbitro Find(int id);
    }
    public class GuardaArbitro : IGuardaArbitro
    {
        #region Member Values
        public List<IArbitro> list;
        #endregion

        #region Constructors
        public GuardaArbitro()
        {
            list = new List<IArbitro>();
        }
        #endregion

        #region Functions
        public bool AddArbitro(IArbitro i)
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
                list = new List<IArbitro>();
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
                    list = (List<IArbitro>)bin.Deserialize(stream);
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

        public IArbitro Find(int id)
        {
            int index = 0;
            IArbitro a = new Arbitro();

            foreach (IArbitro i in list)
            {
                index++;
                if (index == id)
                {
                    a = i;
                    break;
                }
            }
            return a;
        }

        public List<IArbitro> GiveList()
        {
            return list;
        }

        #endregion
    }
}
