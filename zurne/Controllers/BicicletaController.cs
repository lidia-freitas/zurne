using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class BicicletaController
    {
        private static List<Bicicleta> listaBicicletas = new List<Bicicleta>();

        public static Bicicleta BuscarBicicleta(int id)
        {
            foreach (Bicicleta bike in listaBicicletas)
            {
                if (bike.Id == id)
                {
                    return bike;
                }
            }

            return null;
        }

        public static List<Bicicleta> ListarBicicletas()
        {
            return listaBicicletas;
        }

        public static void CadastrarBicicleta(int marchas, string marca, string modelo, string cor, int ano)
        {
            Bicicleta bike = new Bicicleta(marchas, marca, modelo, cor, ano);
            bike.Id = listaBicicletas.Count();

            listaBicicletas.Add(bike);
        }

        public static void EditarBicicleta(int id, int marchas, string marca, string modelo, string cor, int ano)
        {
            Bicicleta bike = BuscarBicicleta(id);

            bike.Marchas = marchas;
            bike.Marca = marca;
            bike.Modelo = modelo;
            bike.Cor = cor;
            bike.Ano = ano;
        }

        public static void RemoverBicicleta(int id)
        {
            Bicicleta bike = BuscarBicicleta(id);
            listaBicicletas.Remove(bike);
        }
     
    }
}
