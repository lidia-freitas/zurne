using Models;
using Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class OrdemServicoController
    {
        public static OrdemServico BuscarOrdemServico(int id, Contexto ctx)
        {
            return ctx.OrdemServico.Find(id);
        }

        public static OrdemServico BuscarOrdemServico(int id)
        {
            using (Contexto ctx = new Contexto())
            {
                return ctx.OrdemServico.Find(id);
            }
        }

        public static List<OrdemServico> ListarOrdemServicos()
        {
            List<OrdemServico> listaOrdemServico = new List<OrdemServico>();

            using (Contexto ctx = new Contexto())
            {
                listaOrdemServico = ctx.OrdemServico.ToList();
                return listaOrdemServico;
            }
        }

        public static void CadastrarOrdemServico( DateTime data, string latitude, string longitude, double valor, string obs, string tipoVeiculo,
            int cliId, int funcId, int veiId)
        {
            using (Contexto ctx = new Contexto())
            {
                OrdemServico os = new OrdemServico();

                os.Data = data;
                os.Origem = latitude;
                os.Destino = longitude;
                os.Valor = valor;
                os.Obs = obs;

                os.Cliente = ClienteController.BuscarCliente(cliId);
                os.Funcionario = FuncionarioController.BuscarFuncionario(funcId);
                

                switch (tipoVeiculo)
                {
                    case "Automovel":
                        os.Veiculo = AutomovelController.BuscarAutomovel(veiId);
                        break;

                    case "Motocicleta":
                        os.Veiculo = MotocicletaController.BuscarMotocicleta(veiId);
                        break;

                    case "Bicicleta":
                        os.Veiculo = BicicletaController.BuscarBicicleta(veiId);
                        break;
                }

                ctx.OrdemServico.Add(os);
                ctx.SaveChanges();
            }
        }

        //public static void EditarOrdemServico(int id, DateTime data, string latitude, string longitude, double valor, string obs)
        //{
        //    using (Contexto ctx = new Contexto())
        //    {
        //        OrdemServico OS = BuscarOrdemServico(id, ctx);

        //        if (OS != null)
        //        {
        //            OS.Data = data;
        //            OS.Latitude = latitude;
        //            OS.Longitude = longitude;
        //            OS.Valor = valor;
        //            OS.Obs = obs;
        //        }

        //        ctx.Entry(OS).State = System.Data.Entity.EntityState.Modified;
        //        ctx.SaveChanges();
        //    }
        //}

        //public static void RemoverOrdemServico(int id)
        //{
        //    using (Contexto ctx = new Contexto())
        //    {
        //        OrdemServico OS = BuscarOrdemServico(id, ctx);

        //        if (OS != null)
        //        {
        //            ctx.Entry(OS).State = System.Data.Entity.EntityState.Deleted;
        //            ctx.SaveChanges();
        //        }
        //    }
        //}
    }
}
