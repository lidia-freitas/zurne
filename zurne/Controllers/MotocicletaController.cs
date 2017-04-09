using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class MotocicletaController
    {
        private static List<Motocicleta> listaMotocicletas = new List<Motocicleta>();

        public static Motocicleta BuscarMotocicleta(int id)
        {
            foreach (Motocicleta moto in listaMotocicletas)
            {
                if (moto.Id == id)
                {
                    return moto;
                }
            }

            return null;
        }

        public static List<Motocicleta> ListarMotocicletas()
        {
            return listaMotocicletas;
        }

        public static void cadastrarMotocicleta(int cilindradas, string marca, string modelo, string cor, int ano)
        {
            Motocicleta moto = new Motocicleta(cilindradas, marca, modelo, cor, ano);
            moto.Id = listaMotocicletas.Count();

            listaMotocicletas.Add(moto);
        }

        public static void EditarMotocicleta(int id, int cilindradas, string marca, string modelo, string cor, int ano)
        {
            Motocicleta moto = BuscarMotocicleta(id);

            moto.Cilindradas = cilindradas;
            moto.Marca = marca;
            moto.Modelo = modelo;
            moto.Cor = cor;
            moto.Ano = ano;       
        }

        public static void RemoverMotocicleta(int id)
        {
            Motocicleta moto = BuscarMotocicleta(id);
            listaMotocicletas.Remove(moto);
        }
    }
}
