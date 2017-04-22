using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRefugiados.Web.Infra.Repository
{
    public interface ICrud<Tipo> : IDisposable
    {
        void Add(Tipo add);
        void Remove(Tipo remove);
        void Edit(Tipo edit);
        Tipo FindById(int key);
        IEnumerable<Tipo> List();
    }
}
