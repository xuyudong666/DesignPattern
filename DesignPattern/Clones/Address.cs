﻿namespace DesignPattern.Clones
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }

        public Address(string street,
                       string city,
                       string state,
                       string country,
                       string postalCode)
        {
            Street = street;
            City = city;
            State = state;
            Country = country;
            PostalCode = postalCode;
        }
        public Address()
        {
        }
        public override string ToString()
        {
            return $"{Street}, {City}, {State}, {PostalCode}, {Country}";
        }
    }
}
