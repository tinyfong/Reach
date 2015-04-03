using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reach.Core
{
    public interface IMapper<TEntity, TInput>
        where TEntity : class ,new()
        where TInput : new()
    {
        TInput MapToInput(TEntity entity);

        TEntity MapToEntity(TInput input, TEntity entity);
    }
}