using System.Collections.Generic;

namespace DelegatesEventsLinq
{
    public class ContactProvider
    {
        public List<Contact> GetContacts()
        {
            return new List<Contact>()
            {
                new Contact()
                {
                    Id = 1,
                    FirstName = "Danil",
                    LastName = "Alshok"
                },
                new Contact()
                {
                    Id = 2,
                    FirstName = "Yehor",
                    LastName = "Kovalov"
                },
                new Contact()
                {
                    Id = 3,
                    FirstName = "Vadim",
                    LastName = "Neteshin"
                },
                new Contact()
                {
                    Id = 4,
                    FirstName = "Artem",
                    LastName = "Svistunov"
                },
                new Contact()
                {
                    Id = 5,
                    FirstName = "Dariya",
                    LastName = "Kodenko"
                },
                new Contact()
                {
                    Id = 6,
                    FirstName = "Oleg",
                    LastName = "Svistunov"
                },
                new Contact()
                {
                    Id = 7,
                    FirstName = "Elizaveta",
                    LastName = "Smalko"
                }
            };
        }
    }
}
