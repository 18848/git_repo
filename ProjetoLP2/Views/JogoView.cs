using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoLP2.Models;
using ProjetoLP2.Controllers;
using ProjetoLP2.Models.Guardar;
using System.Diagnostics;

namespace ProjetoLP2.Views
{
    public interface IJogoView
    {
        void ShowAll(IJogo i, int id);
        void ShowOne(IJogo i, List<IArbitro> arbitros);
        void AddJogo();
        void GetJogo();
        void UpdateJogo();
        void UpdateArbitro();
        void DeleteArbitro();
    }
    public class JogoView : IJogoView
    {
        #region Member Values
        private IJogoController controller;
        #endregion

        #region Constructor
        public JogoView(IJogoController c)
        {
            controller = c;
            controller.SetView(this);
        }
        #endregion

        #region Functions
        public void ShowAll(IJogo i, int id)
        {
            Console.WriteLine("\nID: " + id.ToString());
            Console.WriteLine(i.EquipaA + " " + i.ResultadoA + " - " + i.ResultadoB + " " + i.EquipaA);
        }
        public void ShowOne(IJogo i, List<IArbitro> arbitros)
        {
            Console.WriteLine(i.EquipaA + " " + i.ResultadoA + " - " + i.ResultadoB + " " + i.EquipaA);

            if (arbitros != null)
            {
                foreach (IArbitro foo in arbitros)
                {
                    Console.WriteLine("Nome: " + foo.Nome);
                }
            }
        }
        public void AddJogo()
        {
            IJogo x = new Jogo();

            try
            {
                Console.Write("\nEquipa A: ");
                x.EquipaA = int.Parse(Console.ReadLine());

                Console.Write("\nEquipa B: ");
                x.EquipaB = int.Parse(Console.ReadLine());

                Console.Write("\nGolos Equipa A: ");
                x.ResultadoA = int.Parse(Console.ReadLine());

                Console.Write("\nnGolos Equipa B: ");
                x.ResultadoB = int.Parse(Console.ReadLine());

                controller.Add(x);
            }
            catch (FormatException e)
            {
                throw e;
            }
            catch (OverflowException e)
            {
                throw e;
            }
        }

        public void GetJogo()
        {
            try
            {
                Console.Write("ID: ");
                int.TryParse(Console.ReadLine(), out int id);

                controller.Find(id);
            }
            catch (FormatException e)
            {
                throw e;
            }
            catch (OverflowException e)
            {
                throw e;
            }
        }

        public void UpdateJogo()
        {
            IJogo x = new Jogo();
            bool validar;

            try
            {
                Console.Write("ID: ");
                int.TryParse(Console.ReadLine(), out int id);
                validar = controller.ProcurarJogo(id);

                if (validar)
                {
                    Console.Write("\nEquipa A: ");
                    x.EquipaA = int.Parse(Console.ReadLine());

                    Console.Write("\nEquipa B: ");
                    x.EquipaB = int.Parse(Console.ReadLine());

                    Console.Write("\nGolos Equipa A: ");
                    x.ResultadoA = int.Parse(Console.ReadLine());

                    Console.Write("\nnGolos Equipa B: ");
                    x.ResultadoB = int.Parse(Console.ReadLine());

                    controller.Update(x);
                }

            }
            catch (FormatException e)
            {
                throw e;
            }
            catch (OverflowException e)
            {
                throw e;
            }
        }

        public void UpdateArbitro()
        {
            bool validarE, validarJ, sair = false;

            try
            {
                Console.Write("ID do Jogo: ");
                int.TryParse(Console.ReadLine(), out int x);
                validarE = controller.ProcurarJogo(x);

                if (validarE)
                {
                    while (!sair)
                    {
                        Console.Write("\nID do Arbitro: ");
                        int.TryParse(Console.ReadLine(), out int id);

                        if (id != 0)
                        {
                            validarJ = controller.ProcurarArbitro(id);

                            if (validarJ)
                            {
                                controller.UpdateArbitroModel(id);
                                Console.WriteLine("Inserido com sucesso");
                            }
                            else
                            {
                                Console.WriteLine("O Arbitro não pode ser selecionado");
                            }
                        }
                        else
                        {
                            sair = true;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("O Jogo não pode ser selecionado");
                    Console.ReadKey();
                }

            }
            catch (FormatException e)
            {
                throw e;
            }
            catch (OverflowException e)
            {
                throw e;
            }
        }
        public void DeleteArbitro()
        {
            bool validarE, validarJ;

            try
            {
                Console.Write("ID do Jogo: ");
                int.TryParse(Console.ReadLine(), out int x);
                validarE = controller.ProcurarJogo(x);

                if (validarE)
                {
                    Console.Write("\nID do Arbitro: ");
                    int.TryParse(Console.ReadLine(), out int id);

                    validarJ = controller.ProcurarArbitro(id);

                    if (!validarJ)
                    {
                        controller.DeleteArbitroModel(id);
                        Console.WriteLine("Removido com sucesso");
                    }
                    else
                    {
                        Console.WriteLine("Arbitro nao encontrado");
                    }
                }
                else
                {
                    Console.WriteLine("O jogo não pode ser selecionado");
                    Console.ReadKey();
                }

            }
            catch (FormatException e)
            {
                throw e;
            }
            catch (OverflowException e)
            {
                throw e;
            }
        }
        #endregion
    }
}
