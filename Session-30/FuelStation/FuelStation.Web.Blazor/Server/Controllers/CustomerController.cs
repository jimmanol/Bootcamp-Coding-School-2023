using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using System.Data.Common;
using FuelStation.Web.Blazor.Shared;

namespace FuelStation.Web.Blazor.Server.Controllers {
    
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase {

        private readonly IEntityRepo<Customer> _customerRepo;

        public CustomerController(IEntityRepo<Customer> customerRepo) {
            _customerRepo = customerRepo;
        }


        [HttpGet]
        public async Task<IEnumerable<CustomerListDto>> Get() {
            var result = _customerRepo.GetAll();
            return result.Select(customer => new CustomerListDto {
                ID = customer.ID,
                Name = customer.Name,
                Surname = customer.Surname,
                CardNumber = customer.CardNumber
            });
        }

        [HttpGet("{id:Guid}")]
        public async Task<CustomerEditDto?> GetById(Guid id) {
            try {
                var result = _customerRepo.GetById(id);
                if (result == null) {
                    return null;
                }
                CustomerEditDto customer = new CustomerEditDto(result);
                return customer;
            }
            catch (DbException) {
                return null;
            }
        }

        [HttpPost]
        public async Task Post(CustomerEditDto customer) {
            var newCustomer = new Customer(customer.Name, customer.Surname, customer.CardNumber);
            newCustomer.Transactions = new();
            _customerRepo.Add(newCustomer);
        }

        [HttpPut]
        public async Task Put(CustomerEditDto customer) {
            var dbCustomer = await Task.Run(() => { return _customerRepo.GetById(customer.ID); });
            dbCustomer.ID = customer.ID;
            dbCustomer.Name = customer.Name;
            dbCustomer.Surname = customer.Surname;
            dbCustomer.CardNumber = customer.CardNumber;

            dbCustomer.Transactions = customer.Transactions;
            _customerRepo.Update(customer.ID, dbCustomer);
        }


        [HttpDelete("{id:Guid}")]
        public async Task Delete(Guid id) {
            _customerRepo.Delete(id);

        }

    }
}
