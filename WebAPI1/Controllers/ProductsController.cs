using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramewor;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI1.Controllers
{
    [Route("api/[controller]")]
    [ApiController] //attrıbute class ile ilgil bilgi verme imzalama 
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        //Lose coupled -- gevşek bağımlılık soyuta bağımlıkık 
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public ActionResult GetAll()
        {
            
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        

        [HttpPost("add")]

        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

       
    }
}
