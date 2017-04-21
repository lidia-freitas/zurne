using Models;
using Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class MotocicletaController
    {

        public static Motocicleta BuscarMotocicleta(int id)
        {
            using (Contexto ctx = new Contexto())
            {
                return ctx.Motocicleta.Find(id);
            }
        }

        public static List<Motocicleta> ListarMotocicletas()
        {
            using (Contexto ctx = new Contexto())
            {
                return ctx.Motocicleta.ToList();   
            }
        }

        public static void cadastrarMotocicleta(int cilindradas, string marca, string modelo, string cor, int ano, int autonomia)
        {
            using (Contexto ctx = new Contexto())
            {
                Motocicleta moto = new Motocicleta(cilindradas, marca, modelo, cor, ano, autonomia);
                ctx.Motocicleta.Add(moto);
                ctx.SaveChanges();
            }
        }

        public static void EditarMotocicleta(int id, int cilindradas, string marca, string modelo, string cor, int ano, int autonomia)
        {
            using (Contexto ctx = new Contexto())
            {

                Motocicleta moto = BuscarMotocicleta(id);

                if (moto != null)
                {
                    moto.Cilindradas = cilindradas;
                    moto.Marca = marca;
                    moto.Modelo = modelo;
                    moto.Cor = cor;
                    moto.Ano = ano;
                    moto.Autonomia = autonomia;
                }
                ctx.Entry(moto).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public static void RemoverMotocicleta(int id)
        {
            using (Contexto ctx = new Contexto())
            {
                Motocicleta moto = BuscarMotocicleta(id);

                if (moto != null)
                {
                    ctx.Entry(moto).State = System.Data.Entity.EntityState.Deleted;
                    ctx.SaveChanges();
                }
            }
        }
    }
}
