using CsTsCoder.Shared;

namespace CsTsCoder.Spin.Csharp.Dtos
{
    [CoderEnabled]
    public class AddressDto
    {
        public string Street { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
    }
}
