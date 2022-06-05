using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.IRepositories;
using Shared.Repositories;
using Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductFeature.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepo;
        private readonly IMapper _mapper;

        public ProductController(IProductRepository _productRepo, IMapper _mapper)
        {
            this._productRepo = _productRepo;
            this._mapper = _mapper;

        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductDTO>> Get()
        {
            try
            {
                IEnumerable<ProductProduct> listproduct = _productRepo.getAllProducts();
                //if (listProducts.Count() == 0) return BadRequest("Produit n'esxiste pas");
                   
                var dto = _mapper.Map<IEnumerable<ProductDTO>>(listproduct) ;

                return Ok(dto);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
