using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface IPessoa
    {
        string Documento{ get; set; }
        string Nomenclatura { get; set; }
        string Email { get; set; }
        string Endereco { get; set; }
    }
}
