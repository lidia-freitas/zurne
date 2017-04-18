using Models;
using Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class AutomovelController
    {

        public static Automovel BuscarAutomovel(int id)
        {
            using(Contexto ctx = new Contexto())
            {
                return ctx.Automovel.Find(id);
            }
        }

        public static List<Automovel> ListarAutomoveis()
        {
            using (Contexto ctx = new Contexto())
            {
                return ctx.Automovel.ToList();
            }
        }

        public static void CadastrarAutomovel(double potencia, string marca, string modelo, string cor, int ano)
        {
            using (Contexto ctx = new Contexto())
            {
                Automovel auto = new Automovel(potencia, marca, modelo, cor, ano);
                ctx.Automovel.Add(auto);
                ctx.SaveChanges();
            }
        }

        public static void EditarAuomovel(int id, double potencia, string marca, string modelo, string cor, int ano)
        {
            using (Contexto ctx = new Contexto())
            {
                Automovel auto = BuscarAutomovel(id);

                if (auto != null)
                {
                    auto.Marca = marca;
                    auto.Modelo = modelo;
                    auto.Cor = cor;
                    auto.Ano = ano;
                    auto.Potencia = potencia;            
                }
                ctx.Entry(auto).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public static void RemoverAutomovel(int id)
        {
            using (Contexto ctx = new Contexto())
            {
                Automovel auto = BuscarAutomovel(id);

                if (auto != null)
                {
                    ctx.Entry(auto).State = System.Data.Entity.EntityState.Deleted;
                    ctx.SaveChanges();
                }
            }
        }
    }
}
