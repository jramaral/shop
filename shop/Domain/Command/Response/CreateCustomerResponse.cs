﻿using System;

namespace shop.Domain.Command.Response
{
    public class CreateCustomerResponse
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
    }
}