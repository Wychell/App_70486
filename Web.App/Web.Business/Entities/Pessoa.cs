using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Business.Entities
{
    public class Pessoa : Entity
    {
        public Pessoa()
        {

        }

        public Pessoa(long id): base(id)
        {

        }

        public string Nome { get; set; }
    }
}
