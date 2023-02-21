using CoffeeShop.Blazor.Shared;
using CoffeeShop.EF.Repositories;
using CoffeeShop.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Blazor.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase {

        private readonly IEntityRepo<Product> _productRepo;

        public ProductController(IEntityRepo<Product> productRepo) {
            _productRepo = productRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductListDto>> Get() {
            var product = _productRepo.GetAll();
            return product.Select(product => new ProductListDto {
                Id = product.Id,
                Code = product.Code,
                Description = product.Description,
                Cost = product.Cost,
                Price = product.Price,
                ProductCategoryId = product.ProductCategoryId
            });
        }

        [HttpGet("{id}")]
        public async Task<ProductEditDto> GetById(int id) {
            var product = _productRepo.GetById(id);
            return new ProductEditDto {
                Id = id,
                Code = product.Code,
                Description = product.Description,
                Cost = product.Cost,
                Price = product.Price,
                ProductCategoryId = product.ProductCategoryId
            };
        }

        [HttpPost]
        public async Task Post(ProductEditDto product) {
            var newProduct = new Product(product.Code, product.Description, product.Cost, product.Price) { 
            ProductCategoryId = product.ProductCategoryId,
            };
            _productRepo.Create(newProduct);
        }

        [HttpPut]
        public async Task Put(ProductEditDto product) {
            var taskUpdate = _productRepo.GetById(product.Id); 
            taskUpdate.Code = product.Code;
            taskUpdate.Description = product.Description;
            taskUpdate.Cost = product.Cost;
            taskUpdate.Price = product.Price;
            taskUpdate.ProductCategoryId = product.ProductCategoryId;
            taskUpdate.ProductCategory = null!;
            _productRepo.Update(product.Id, taskUpdate);
        }



        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id) {
            try {
                _productRepo.Delete(id);
                return Ok();
            }
            catch (DbUpdateException ex) {
                return BadRequest("This Product cannot be deleted!");
            }
            catch (KeyNotFoundException ex) {
                return BadRequest($"Product with id {id} not found!");
            }
        }
    }
}

