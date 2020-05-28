using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLP.Models
{
    public interface IGuardarEquipa
    {
        bool AddEquipa(Equipa e);
        bool SaveEquipas(string file);
        bool LoadEquipas(string file);
        bool RemoveEquipa(int id);
        List<IEquipaModel> GetEquipas(int id);
    }

    public class GuardarEquipa
    {
        #region Attributes

        List<IEquipaModel> equipas;

        #endregion


        #region Properties

        bool AddEquipa(Equipa e)
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

        bool SaveEquipas(string file)
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

        bool LoadEquipas(string file)
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

        bool RemoveEquipa(int id)
        {
            foreach (IEquipaModel in equipas)
                if (e.Id == id && e.Active)
                {
                    e.Active = false;
                    return true;
                }
            return false;
        }

        List<IEquipaModel> GetEquipas(int id)
        {
            return equipas;
        }

        #endregion



    }
}
