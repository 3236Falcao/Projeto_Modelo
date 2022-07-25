using FluentValidation;
using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Domain.Interfaces
{
    // as interfaces são genéricas, onde recebem um modelo (T) como parâmetro, identificando sobre qual entidade àquela interface irá atuar.
    //Os métodos Post e Put da interface IService recebem como parâmetro a entidade para validação (V) do modelo referente (T).
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        TEntity Add<TValidator>(TEntity obj) where TValidator : AbstractValidator<TEntity>;

        void Delete(int id);

        IList<TEntity> Get();

        TEntity GetById(int id);

        TEntity Update<TValidator>(TEntity obj) where TValidator : AbstractValidator<TEntity>;
    }
}
