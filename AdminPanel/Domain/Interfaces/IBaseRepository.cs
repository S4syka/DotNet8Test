using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces;

public interface IBaseRepository<TEntity> where TEntity : class
{
    IEnumerable<TEntity> Load();

    void Create(TEntity entity);

    TEntity Read(Guid guid);

    void Update(TEntity entity);

    void Delete(Guid guid);
}
