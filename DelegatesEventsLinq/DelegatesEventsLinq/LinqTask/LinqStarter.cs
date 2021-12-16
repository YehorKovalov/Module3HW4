using System;
using System.Linq;

namespace DelegatesEventsLinq
{
    public class LinqStarter : IStarter
    {
        public void Run()
        {
            var contacts = new ContactProvider().GetContacts();
            if (contacts.Any())
            {
                var contact = contacts.Where(w => w.Id > 2)
                    ?.OrderBy(o => o.FirstName)
                    .ThenBy(t => t.LastName)
                    .Append(new Contact()
                    {
                        Id = 8,
                        FirstName = "Zak",
                        LastName = "Efron"
                    })
                    .FirstOrDefault(f => f.Id > 2);

                Console.WriteLine($"Id: {contact.Id}");
                Console.WriteLine($"Name: {contact.FirstName}");
                Console.WriteLine($"Surname: {contact.LastName}");
            }
        }
    }
}
