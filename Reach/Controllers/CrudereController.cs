using Reach.Core;
using Reach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reach.Controllers
{
    public abstract class CrudereController<TEntity, TCreateInput, TEditInput> : BaseController
        where TEntity : Entity, new()
        where TCreateInput : new()
        where TEditInput : Input, new()
    {
        protected readonly ICrudService<TEntity> service;
        private readonly IMapper<TEntity, TCreateInput> createMapper;
        private readonly IMapper<TEntity, TEditInput> editMapper;

        protected virtual string EditView { get { return "Create"; } }


        public CrudereController(ICrudService<TEntity> service, IMapper<TEntity, TCreateInput> createMapper, IMapper<TEntity, TEditInput> editMapper)
        {
            this.service = service;
            this.createMapper = createMapper;
            this.editMapper = editMapper;
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(TCreateInput input)
        {
            if (!ModelState.IsValid)
            {
                return View(input);
            }

            var entity = createMapper.MapToEntity(input, new TEntity());
            var id = service.Create(entity);
            entity = service.Get(id);


            return RedirectToAction("Index");
        }

        [OutputCache(Duration = 0)]
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var entity = service.Get(id);
            return View("Create", editMapper.MapToInput(entity));
        }

        [HttpPost]
        public ActionResult Edit(TEditInput input)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(EditView, input);
                }

                var old = service.Get(input.Id);
                var entity = editMapper.MapToEntity(input, old);
                service.Save();

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
                throw;
            }
        }
    }
}
