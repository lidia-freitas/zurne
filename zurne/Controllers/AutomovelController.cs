using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class AutomovelController
    {
        private static List<Automovel> listaAutomoveis = new List<Automovel>();

        public static Automovel BuscarAutomovel(int id)
        {
            foreach (Automovel auto in listaAutomoveis)
            {
                if (auto.Id == id)
                {
                    return auto;
                }
            }

            return null;
        }

        public static List<Automovel> ListarAutomoveis()
        {
            return listaAutomoveis;
        }

        public static void CadastrarAutomovel(double potencia, string marca, string modelo, string cor, int ano)
        {
            Automovel auto = new Automovel(potencia, marca, modelo, cor, ano);

            auto.Id = listaAutomoveis.Count();
            listaAutomoveis.Add(auto);
        }

        public static void EditarAuomovel(int id, double potencia, string marca, string modelo, string cor, int ano)
        {
            Automovel auto = BuscarAutomovel(id);
            
            auto.Marca = marca;
            auto.Modelo = modelo;
            auto.Cor = cor;
            auto.Ano = ano;
            auto.Potencia = potencia;            
        }

        public static void RemoverAutomovel(int id)
        {
            Automovel auto = BuscarAutomovel(id);
            listaAutomoveis.Remove(auto);
        }
           
    }
}
