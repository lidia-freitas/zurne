using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controllers
{
    class VeiculosController
    {
        private static List<Veiculo> listaVeiculos = new List<Veiculo>();

        public static Veiculo BuscarVeiculo(int id)
        {
            foreach (Veiculo vei in listaVeiculos)
            {
                if (vei.Id == id)
                {
                    return vei;
                }
            }

            return null;
        }

        public static List<Veiculo> ListarVeiculos()
        {
            return listaVeiculos;        
        }

        public static void CadastrarVeiculo(string tipo, string marcamodelo, int ano, string placa, string renavam)
        {
           // Veiculo vei = new Veiculo(tipo, marcamodelo, ano, placa, renavam);

          //vei.Id = listaVeiculos.Count();
           // listaVeiculos.Add(vei);

        }

        public static void EditarVeiculo(int id, string tipo, string marca, string modelo, int ano, string placa, string renavam)
        {
            Veiculo vei = BuscarVeiculo(id);

            if (vei != null) 
            {

                vei.Marca = marca;
                vei.Modelo = modelo;
                vei.Ano = ano;
                //vei.Placa = placa;
                //vei.Renavam = renavam;
            }
        }

        public static void RemoverVeiculo(int id)
        {
            Veiculo vei = BuscarVeiculo(id);
            listaVeiculos.Remove(vei);            
        }
    }
}
