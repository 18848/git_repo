using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoLP2.Models.Guardar;
using ProjetoLP2.Models;
using ProjetoLP2.Views;
using System.Data;

namespace ProjetoLP2.Controllers
{
    public interface IJogoController
    {
        void SetView(IJogoView v);
        void SetModel(IGuardaJogo m);
        void SetModelArbitro(IGuardaArbitro m);
        void SetModel(IJogo m);
        void GetAllJogos();
        bool ProcurarJogo(int id);
        void SetJogo();
        void Add(IJogo jogo);
        void GetJogo();
        void Find(int id);
        void UpdateJogo();
        void Update(IJogo jogo);
        void UpdateArbitro();
        void UpdateArbitroModel(int id);
        void DeleteArbitro();
        void DeleteArbitroModel(int id);
        bool ProcurarArbitro(int id);
    }
    

    public class JogoController : IJogoController
{
    #region Member Values
    private IJogo model;
    private IJogoView view;
    private IGuardaJogo list;
    private IGuardaArbitro listArbitro;
    #endregion

    #region Constructor
    public JogoController()
    {
        list = new GuardaJogo();
        list.Load("jogo.bin");
        listArbitro = new GuardaArbitro();
        listArbitro.Load("arbitro.bin");

        view = new JogoView(this);
    }
    #endregion

    #region View-Model-File
    public void SetView(IJogoView v)
    {
        this.view = v;
    }

    public void SetModel(IGuardaJogo m)
    {
        list = m;
    }
    public void SetModelArbitro(IGuardaArbitro m)
    {
            listArbitro = m;
    }
    public void SetModel(IJogo m)
    {
        model = m;
    }

    public void Save()
    {
        list.Save("jogo.bin");
    }
    #endregion

    #region Functions
    public void GetAllJogos()
    {
        int index = 0;
        if (view != null)
        {
            if (list != null)
            {
                List<IJogo> jogos = list.GiveList();
                foreach (IJogo i in jogos)
                {
                    index++;
                    view.ShowAll(i, index);
                }
            }
        }
    }
    public bool ProcurarJogo(int id)
    {
        IJogo jogo;
        if (list != null)
        {
                jogo = list.Find(id);

            if (jogo != null)
            {
                SetModel(jogo);
                return true;
            }
        }
        return false;
    }
    public void SetJogo()
    {
        if (view != null)
        {
            view.AddJogo();
        }
    }
    public void Add(IJogo jogo)
    {
        list.Add(jogo);
    }

    public void GetJogo()
    {
        if (view != null)
        {
            view.GetJogo();
        }
    }
    public void Find(int id)
    {
        if (list != null)
        {
            IJogo jogo = new Jogo();
            List<IArbitro> arbitro = new List<IArbitro>();
            List<IArbitro> newArbitro = new List<IArbitro>();

            jogo = list.Find(id);
            arbitro = listArbitro.GiveList();

            foreach (int e in jogo.Arbitros)
            {
                int index = 0;
                foreach (IArbitro j in arbitro)
                {
                    index++;
                    if (e == index)
                    {
                            newArbitro.Add(j);
                        break;
                    }
                }
            }

            view.ShowOne(jogo, newArbitro);
        }
    }
    public void UpdateJogo()
    {
        if (view != null)
        {
            view.UpdateJogo();
        }
    }
    public void Update(IJogo jogo)
    {
        if (list != null)
        {
            model.UpdateJogo(jogo);
        }
    }

    public void UpdateArbitro()
    {
        if (view != null)
        {
            view.UpdateArbitro();
        }
    }
    public void UpdateArbitroModel(int id)
    {
        if (list != null)
        {
            model.UpdateArbitro(id);
        }
    }
    public bool ProcurarArbitro(int id)
    {
        if (list != null)
        {
            return list.FindArbitro(id);
        }
        return false;
    }

    public void DeleteArbitro()
    {
        if (view != null)
        {
            view.DeleteArbitro();
        }
    }
    public void DeleteArbitroModel(int id)
    {
        if (list != null)
        {
            model.DeleteArbitro(id);
        }
    }
    #endregion
}
}
