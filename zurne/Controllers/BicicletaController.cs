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

        public static Bicicleta BuscarBicicleta(int id, Contexto ctx)
        {
            return ctx.Bicicleta.Find(id);            
        }

        public static Bicicleta BuscarBicicleta(int id)
        {
            using (Contexto ctx = new Contexto())
            {
                return ctx.Bicicleta.Find(id);
                
            }
        }

        public static List<Bicicleta> ListarBicicletas()
        {
            List<Bicicleta> listaBike = new List<Bicicleta>();

            using(Contexto ctx = new Contexto())
            {
                listaBike = ctx.Bicicleta.ToList();
                return listaBike;
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
                Bicicleta bike = BuscarBicicleta(id, ctx);

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
                Bicicleta bike = BuscarBicicleta(id, ctx);

                if (bike != null)
                {
                    ctx.Entry(bike).State = System.Data.Entity.EntityState.Deleted;
                    ctx.SaveChanges();
                }
            }
        }     
    }
}
