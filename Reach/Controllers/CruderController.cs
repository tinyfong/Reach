using Reach.Core;
using Reach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reach.Controllers
{
    public class CruderController<TEntity, TInput> : CrudereController<TEntity, TInput, TInput>
        where TInput : Input, new()
        where TEntity : Entity, new()
    {
        public CruderController(ICrudService<TEntity> service, IMapper<TEntity, TInput> mapper)
            : base(service, mapper, mapper)
        {

        }
    }
}