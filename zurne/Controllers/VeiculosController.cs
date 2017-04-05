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

        private Veiculo Buscar(int id)
        {
            foreach (Veiculo vei in listaVeiculos)
            {
                if (vei.ID == id)
                {
                    return vei;
                }
            }
            return null;
        }

        public List<Veiculo> Listar()
        {
            return listaVeiculos;
        
        }

        public void CadastrarVeiculo(string tipo, string marcamodelo, int ano, string placa, string renavam)
        {
            Veiculo vei = new Veiculo(tipo, marcamodelo, ano, placa, renavam);
            listaVeiculos.Add(vei);

        }

        public void Remover (int id)
        {
            foreach (Veiculo vei in listaVeiculos)
            {
                if (vei.ID == id)
                {
                    listaVeiculos.Remove(vei);
                }              
            }
        }

        public void Editar(int id, string tipo, string marcamodelo, int ano, string placa, string renavam)
        {
            Veiculo vei = Buscar(id)

            if (vei != null) 
            {
                vei.Tipo = tipo;
                vei.MarcaModelo = marcamodelo;
                vei.Ano = ano;
                vei.Placa = placa;
                vei.Renavam = renavam;
            }
        }
    }
}
