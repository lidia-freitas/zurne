using Models;
using Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class BicicletaController
    {

        public static Bicicleta BuscarBicicleta(int id)
        {
            using (Contexto ctx = new Contexto())
            {
                return ctx.Bicicleta.Find(id);
            }
        }

        public static List<Bicicleta> ListarBicicletas()
        {
            using(Contexto ctx = new Contexto())
            {
                return ctx.Bicicleta.ToList();
            }
        }

        public static void CadastrarBicicleta(int marchas, string marca, string modelo, string cor, int ano)
        {
            using (Contexto ctx = new Contexto())
            {
                Bicicleta bike = new Bicicleta(marchas, marca, modelo, cor, ano);
                ctx.Bicicleta.Add(bike);
                ctx.SaveChanges();
            }            
        }

        public static void EditarBicicleta(int id, int marchas, string marca, string modelo, string cor, int ano)
        {
            using (Contexto ctx = new Contexto())
            {
                Bicicleta bike = BuscarBicicleta(id);

                if (bike != null)
                {
                    bike.Marchas = marchas;
                    bike.Marca = marca;
                    bike.Modelo = modelo;
                    bike.Cor = cor;
                    bike.Ano = ano;
                }
                ctx.Entry(bike).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public static void RemoverBicicleta(int id)
        {
            using (Contexto ctx = new Contexto())
            {
                Bicicleta bike = BuscarBicicleta(id);

                if (bike != null)
                {
                    ctx.Entry(bike).State = System.Data.Entity.EntityState.Deleted;
                    ctx.SaveChanges();
                }
            }
        }     
    }
}
