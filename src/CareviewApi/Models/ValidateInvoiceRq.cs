﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models
{
    public class ValidateInvoiceRq
    {
        public string ClientNdisNumber { get; set; }
        public List<ValidateInvoiceLine> InvoiceLines { get; set; }
    }
}