using CoffeeShop.Blazor.Shared;
using CoffeeShop.EF.Repositories;
using CoffeeShop.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Blazor.Server.Controllers {

    [Route("[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase {

        private readonly IEntityRepo<ProductCategory> _productCategoryRepo;

        public ProductCategoryController(IEntityRepo<ProductCategory> productCategoryRepo) {
            _productCategoryRepo = productCategoryRepo;
        }



        [HttpGet]
        public async Task<IEnumerable<ProductCategoryListDto>> Get() {
            var productCategory = _productCategoryRepo.GetAll();
            return productCategory.Select(productCategory => new ProductCategoryListDto {
                Id = productCategory.Id,
                Code = productCategory.Code,
                Description = productCategory.Description,
                ProductType = productCategory.ProductType,
            });
        }

        [HttpGet("{id}")]
        public async Task<ProductCategoryEditDto> GetById(int id) {
            var productCategory = _productCategoryRepo.GetById(id);
            return new ProductCategoryEditDto {
                Id = id,
                Code = productCategory.Code,
                Description = productCategory.Description,
                ProductType = productCategory.ProductType,
            };
        }


        [HttpPost]
        public async Task Post(ProductCategoryEditDto productCategory) {
            var newProductCategory = new ProductCategory(productCategory.Code, productCategory.Description, productCategory.ProductType);
            newProductCategory.ProductType = productCategory.ProductType;
            _productCategoryRepo.Create(newProductCategory);
        }

        [HttpPut]
        public async Task Put(ProductCategoryEditDto productCategory) {
            var dbProductCategory = await Task.Run(() => { return _productCategoryRepo.GetById(productCategory.Id); });
            if (dbProductCategory is null) {
                // if dbProductCategory is null
                return;
            }
            dbProductCategory.Code = productCategory.Code;
            dbProductCategory.Description = productCategory.Description;
            dbProductCategory.ProductType = productCategory.ProductType;
            _productCategoryRepo.Update(productCategory.Id, dbProductCategory);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id) {
            try {
                _productCategoryRepo.Delete(id);
                return Ok();
            }
            catch (DbUpdateException ex) {
                return BadRequest("This Product Category cannot be deleted!");
            }
            catch (KeyNotFoundException ex) {
                return BadRequest($"ProductCategory with id {id} not found!");
            }
        }
    }
}


