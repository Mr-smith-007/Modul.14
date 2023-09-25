using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTest
{
    class Program
    {

        static void Main(string[] args)
        {
            var contacts = new List<Contact>()
            {
                new Contact() { Name = "Андрей", Phone = 7999945005},
                new Contact() { Name = "Сергей", Phone = 799990455 },
                new Contact() { Name = "Иван", Phone = 79999675 },
                new Contact() { Name = "Игорь", Phone = 795862356 },
                new Contact() { Name = "Анна", Phone = 79235645005 },
                new Contact() { Name = "Василий", Phone = 79035689535 }
            };

            while (true)
            {
                var keychar = Console.ReadKey().KeyChar;
                Console.Clear();


                if (!Char.IsDigit(keychar))
                    Console.WriteLine("Ошибка ввода, введите число");
                else
                {
                    IEnumerable<Contact> page = null;

                    switch (keychar)
                    {
                        case ('1'):
                            page = contacts.Take(2);
                            break;
                        case ('2'):
                            page = contacts.Skip(2).Take(2);
                            break;
                        case ('3'):
                            page = contacts.Skip(4).Take(2);
                            break;
                    }

                    if (page == null)
                    {
                        Console.WriteLine($"Ошибка ввода, страницы с номером {keychar} не существует");
                        continue;
                    }

                    foreach (var contact in page)
                        Console.WriteLine(contact.Name + " " + contact.Phone);
                }
            }
        }

    }
    class Contact
    {
        public string Name { get; set; }
        public long Phone { get; set; }

    }


}