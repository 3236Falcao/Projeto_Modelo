using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Domain.Interfaces
{
    //as interfaces são genéricas, onde recebem um modelo(T) como parâmetro, identificando sobre qual entidade àquela interface irá atuar.
    //Os métodos Post e Put da interface IService recebem como parâmetro a entidade para validação (V) do modelo referente (T).
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        void Insert(TEntity obj);
        void Update(TEntity obj);
        void Delete(int id);
        IList<TEntity> Select();
        TEntity Select(int id);        
    }
}
