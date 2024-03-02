using AnimalShelterManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }

        public override string ToString()
        {
            return $"{Street} {City} {PostalCode}";
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Street;
            yield return City;
            yield return PostalCode;
        }
    }
}
