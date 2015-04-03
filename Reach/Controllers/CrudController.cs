using Reach.Core;
using Reach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reach.Controllers
{
    public abstract class CrudController<TEntity, TCreateInput, TEditInput> : BaseController
        where TEntity : Entity, new()
        where TCreateInput : new()
        where TEditInput : Input, new()
    {
        protected readonly ICrudService<TEntity> service;
        private readonly IMapper<TEntity, TCreateInput> createMapper;
        private readonly IMapper<TEntity, TEditInput> editMapper;


        public CrudController(ICrudService<TEntity> service, IMapper<TEntity, TCreateInput> createMapper, IMapper<TEntity, TEditInput> editMapper)
        {
            this.service = service;
            this.createMapper = createMapper;
            this.editMapper = editMapper;
        }

        public virtual ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(createMapper.MapToInput(new TEntity()));
        }

        [HttpPost]
        public ActionResult Create(TCreateInput input)
        {
            if (!ModelState.IsValid)
            {
                return View(input);
            }

            var id = service.Create(createMapper.MapToEntity(input, new TEntity()));
            var entity = service.Get(id);



            return Json(entity);
        }
    }
}
