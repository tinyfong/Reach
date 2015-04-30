using Reach.Core;
using Reach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reach.Controllers
{
    [OutputCache(Duration = 0)]
    public abstract class CrudereController<TEntity, TCreateInput, TEditInput> : BaseController
        where TEntity : Entity, new()
        where TCreateInput : new()
        where TEditInput : Input, new()
    {
        protected readonly ICrudService<TEntity> service;
        private readonly IMapper<TEntity, TCreateInput> createMapper;
        private readonly IMapper<TEntity, TEditInput> editMapper;

        protected virtual string EditView { get { return "Edit"; } }


        public CrudereController(ICrudService<TEntity> service, IMapper<TEntity, TCreateInput> createMapper, IMapper<TEntity, TEditInput> editMapper)
        {
            this.service = service;
            this.createMapper = createMapper;
            this.editMapper = editMapper;
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(EditView);
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


        [HttpGet]
        public ActionResult Edit(int id)
        {
            string returnUrl = this.Request.UrlReferrer.PathAndQuery;

            if (Url.IsLocalUrl(returnUrl))
            {
                ViewBag.ReturnUrl = returnUrl;
            }
            var entity = service.Get(id); 
            var model = editMapper.MapToInput(entity);
            return View(EditView, model);
        }

        [HttpPost]
        public ActionResult Edit(TEditInput input, string returnUrl)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(returnUrl))
                {
                    returnUrl = Url.Action("Videos");
                }

                if (!ModelState.IsValid)
                {
                    return View(EditView, input);
                }

                var old = service.Get(input.Id);
                var entity = editMapper.MapToEntity(input, old);
                service.Save();


                return Redirect(returnUrl);

            }
            catch (Exception ex)
            {
                return Content(ex.Message);
                throw;
            }
        }

        public ActionResult Delete(int id)
        {
            string returnUrl = this.Request.UrlReferrer.PathAndQuery;

            if (Url.IsLocalUrl(returnUrl))
            {
                ViewBag.ReturnUrl = returnUrl;
            }

            return View("ConfirmDelete", new DeleteInput() { Id = id });
        }

        [HttpPost]
        public ActionResult Delete(DeleteInput input, string returnUrl)
        {
            if (string.IsNullOrWhiteSpace(returnUrl))
            {
                returnUrl = Url.Action("Videos");
            }

            service.Delete(input.Id);

            return Redirect(returnUrl);
        }

    }
}
