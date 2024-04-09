using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Customer;
using api.Models;

namespace api.Mappers
{
    public static class CustomerMapper
    {
        public static CustomerDto ToCustomerDto(this Customer customerModel)
        {
            return new CustomerDto
            {
                Id = customerModel.Id,
                Username = customerModel.Username,
                Email = customerModel.Email
            };
        } 

        public static Customer ToCustomerFromCreateDto(this CreateCustomerRequestDto customerDto)
        {
            return new Customer
            {
                Username = customerDto.Username,
                Email = customerDto.Email
            };
        }
    }
}