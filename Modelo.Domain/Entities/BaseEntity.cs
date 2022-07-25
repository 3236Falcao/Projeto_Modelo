using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Domain.Entities
{
    public abstract class BaseEntity
    {
        // todos os modelos devem possuir um Id
        public virtual int id { get; set; }
    }
}
