using Reach.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Omu.ValueInjecter;

namespace Reach.Mappers
{
    public class Mapper<TEntity, TInput> : IMapper<TEntity, TInput>
        where TEntity : class,new()
        where TInput : new()
    {
        public TInput MapToInput(TEntity entity)
        {
            var input = new TInput();
            input.InjectFrom(entity);
            return input;
        }

        public TEntity MapToEntity(TInput input, TEntity entity)
        {
            entity.InjectFrom(input);
            return entity;
        }
    }
}