using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            SAddressBook newaddressbook = new SAddressBook();
            Contact newcontact = new Contact();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Number to Execute the Address book Program \n1. Create contacts \n2. Add contact \n3. Edit contact \n4. Delete contact \n5. Add contact \n6. Add multiple Address Book with unique name \n7. Check For Duplicate \n8. Search person by city or state \n9. View person by city or state \n10.Count person by city or state \n11. Sort entries using person name \n12. Read  write IO file \n13. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the Contact Information first name, last names, address,city, state, zip, phone number and email id");
                        newcontact.firstname = Console.ReadLine();
                        newcontact.lastname = Console.ReadLine();
                        newcontact.address = Console.ReadLine();
                        newcontact.city = Console.ReadLine();
                        newcontact.state = Console.ReadLine();
                        newcontact.zip = Console.ReadLine();
                        newcontact.phonenumber = Console.ReadLine();
                        newcontact.emailid = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter the Contact Information first name, last names, address,city, state, zip, phone number and email id");
                        newcontact.firstname = Console.ReadLine();
                        newcontact.lastname = Console.ReadLine();
                        newcontact.address = Console.ReadLine();
                        newcontact.city = Console.ReadLine();
                        newcontact.state = Console.ReadLine();
                        newcontact.zip = Console.ReadLine();
                        newcontact.phonenumber = Console.ReadLine();
                        newcontact.emailid = Console.ReadLine();
                        newaddressbook.AddContact(newcontact);
                        newaddressbook.Display();
                        break;
                    case 3:
                        newaddressbook.Editexistingcontact();
                        newaddressbook.Display();
                        break;
                    case 4:
                        newaddressbook.Deletecontact();
                        newaddressbook.Display();
                        break;
                    case 5:
                        Console.WriteLine("Enter the Contact Information first name, last names, address,city, state, zip, phone number and email id");
                        newcontact.firstname = Console.ReadLine();
                        newcontact.lastname = Console.ReadLine();
                        newcontact.address = Console.ReadLine();
                        newcontact.city = Console.ReadLine();
                        newcontact.state = Console.ReadLine();
                        newcontact.zip = Console.ReadLine();
                        newcontact.phonenumber = Console.ReadLine();
                        newcontact.emailid = Console.ReadLine();
                        newaddressbook.AddContact(newcontact);
                        newaddressbook.Display();
                        break;
                    case 6:
                        Console.WriteLine("Enter the Unique Contact to be added: ");
                        string name = Console.ReadLine();
                        newaddressbook.AddUniqueContact(name);
                        newaddressbook.DisplayUniqueContacts();
                        break;
                    case 7:
                        Console.WriteLine("Enter the Unique Contact to be added: ");
                        string duplicatename = Console.ReadLine();
                        newaddressbook.AddUniqueContact(duplicatename);
                        newaddressbook.DisplayUniqueContacts();
                        break;
                    case 8:
                        newaddressbook.Search_person_city_state();
                        break;
                    case 9:
                        newaddressbook.view_person_city_state();
                        break;
                    case 10:
                        newaddressbook.Count_person_city_state();
                        break;
                    case 11:
                        newaddressbook.SortbyName();
                        break;
                    case 12:
                        newaddressbook.Readfile();
                        newaddressbook.WriteUsingStreamWriter();
                        break;
                    case 13:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}