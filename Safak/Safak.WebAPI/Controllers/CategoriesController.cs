using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Safak.Business.Abstract;
using Safak.DataAccess.Abstract;
using Safak.Entities.Concrete;

namespace Safak.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private ICategoriesService _categoriesService;

        public CategoriesController(ICategoriesService categoriesService)
        {
            _categoriesService = categoriesService;
        }

        [HttpGet(template:"getall")]
        public IActionResult GetList()
        {
            var result = _categoriesService.GetList();
            if(result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet(template: "getbyid")]
        public IActionResult Get(int categoryId)
        {
            var result = _categoriesService.GetById(categoryId);
            if(result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost(template: "add")]
        public IActionResult Add(Categories categories)
        {
            var result = _categoriesService.Add(categories);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost(template: "delete")]
        public IActionResult Delete(Categories categories)
        {
            var result = _categoriesService.Delete(categories);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPost(template: "update")]
        public IActionResult Update(Categories categories)
        {
            var result = _categoriesService.Update(categories);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
