using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("getallcategory")]
        public IActionResult GetList()
        {
            var categories = _categoryService.GetList();
            if (categories.Success)
            {
                return Ok(categories.Data);
            }
            else
            {
                return BadRequest(categories.Message);
            }

        }
        [HttpGet("getcategorybyid")]
        public IActionResult GetCategoryById(int categoryId)
        {
            var category = _categoryService.GetCategoryById(categoryId);
            if (category.Success)
            {
                return Ok(category.Data);
            }
            else
            {
                return BadRequest(category.Message);
            }

        }
        [HttpPost("add")]
        public IActionResult Add(Category category)
        {
           var added= _categoryService.Add(category);
            if (added.Success)
            {
                return Ok(added.Message);
            }
            else
            {
                return BadRequest(added.Message);
            }
        }
        [HttpPut("Update")]
        public IActionResult Update(Category category)
        {
            var updated = _categoryService.Update(category);
            if (updated.Success)
            {
                return Ok(updated.Message);
            }
            else
            {
                return BadRequest(updated.Message);
            }
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(Category category)
        {
            var deleted = _categoryService.Delete(category);
            if (deleted.Success)
            {
                return Ok(deleted.Success);
            }
            else
            {
                return BadRequest(deleted.Success);
            }
        }
    }
}