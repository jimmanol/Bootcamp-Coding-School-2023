using CoffeeShop.Blazor.Shared;
using CoffeeShop.Blazor.Shared.Customer;
using CoffeeShop.EF.Repositories;
using CoffeeShop.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace CoffeeShop.Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IEntityRepo<Customer> _customerRepo;
        public CustomerController(IEntityRepo<Customer> customerRepo)
        {

            _customerRepo = customerRepo;

        }
        [HttpGet]
        public async Task<IEnumerable<CustomerListDto>> Get()
        {
            var customerList = _customerRepo.GetAll();

            return customerList.Select(customer => new CustomerListDto
            {
                Id = customer.Id,
                Code = customer.Code,
                Description = customer.Description


            });

        }
        [HttpGet("{Id}")]
        public async Task<CustomerEditDto?> GetById(int id)
        {
            var result = _customerRepo.GetById(id);
            return new CustomerEditDto
            {
                Id = result.Id,
                Code = result.Code,
                Description = result.Description,
             //  Transactions = result.Transactions
            };

        }

        [HttpPost]
        public async Task Post(CustomerEditDto customer)
        {
            var newCustomer = new Customer(customer.Code, customer.Description);
            
                _customerRepo.Create(newCustomer);

            
        }
        [HttpPut]
        public async Task Put(CustomerEditDto customer)
        {
            var dbCustomer = await Task.Run(()=> { return _customerRepo.GetById(customer.Id); });
            
                
                if (dbCustomer is null) { 
                return;
            }
            
            dbCustomer.Code = customer.Code;
            dbCustomer.Description = customer.Description;
         //   dbCustomer.Transactions = customer.Transactions;
            _customerRepo.Update(customer.Id, dbCustomer);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {

            _customerRepo.Delete(id);

        }

    }

}



