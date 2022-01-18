using CsTsCoder.Shared;
using System;
using System.Collections.Generic;

namespace CsTsCoder.Spin.Csharp.Dtos
{
    [CoderEnabled]
    public class PersonDto
    {
        public string SSN { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime DoB { get; set; }
        public IEnumerable<AddressDto> Addresses { get; set; }
    }
}
