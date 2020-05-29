using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProjetoLP.Models
{
    public interface IGuardarEquipa
    {
        bool AddEquipa(IEquipaModel e);
        bool SaveEquipas(string file);
        bool LoadEquipas(string file);
        bool RemoveEquipa(int id);
        List<IEquipaModel> GetEquipas();
        IEquipaModel GetEquipa(int id);
    }

    public class GuardarEquipa
    {
        #region Attributes


        private List<IEquipaModel> equipas;

        #endregion


        #region Properties

        public bool AddEquipa(IEquipaModel e)
        {
            if (equipas != null)
            {
                if (equipas.Contains(e))
                {
                    return false;
                }
                else
                {
                    e.Id = equipas.Count + 1;
                    e.Active = true;
                    equipas.Add(e);
                    return true;
                }
            }
            else
            {
                equipas = new List<IEquipaModel>();
                e.Id = equipas.Count + 1;
                e.Active = true;
                equipas.Add(e);
                return true;
            }
        }

        public bool SaveEquipas(string file)
        {
            if (equipas != null)
            {
                try
                {
                    Stream stream = File.Open(file, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, equipas);
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

        public bool LoadEquipas(string file)
        {
            if (File.Exists(file))
            {
                Stream stream = File.Open(file, FileMode.Open);
                BinaryFormatter bin = new BinaryFormatter();
                equipas = (List<IEquipaModel>)bin.Deserialize(stream);
                stream.Close();
                return true;
            }
            return false;
        }

        public bool RemoveEquipa(int id)
        {
            foreach (IEquipaModel e in equipas)
                if (e.Id == id && e.Active)
                {
                    e.Active = false;
                    return true;
                }
            return false;
        }

        public List<IEquipaModel> GetEquipas()
        {
            return equipas;
        }
        
        public IEquipaModel GetEquipa(int id)
        {
            return equipas[id];
        }

        #endregion



    }
}
