using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment28sept
{
    public class AccountType
    {
        public string SName { get; set; }
        public List<Customer> Customers=new List<Customer>();
    }
    public class Customer
    {
        public int SId { get; set; }

        public string SName { get; set; }

        public List<Lone> Lones=new List<Lone>();
      
    }
    public class Lone
    {
        public string lone_type { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<AccountType> accounts = new List<AccountType>()
            {
                new AccountType
                {
                    SName="Saving Account",
                    Customers =
                     {
                         new Customer
                         {
                            SId=1,
                            SName="Ram",
                             Lones=
                             {
                                new Lone{lone_type="Home Lone"},
                                new Lone{lone_type="Car Lone"}

                             }
                         },
                         new Customer
                         {
                            SId=2,
                            SName="Sham",
                             Lones=
                             {
                                new Lone{lone_type="Mobile Lone"},
                                new Lone{lone_type="Car Lone"}

                             }
                         },
                         new Customer
                         {
                            SId=3,
                            SName="Rahul",
                             Lones=
                             {
                                new Lone{lone_type="Farmer Lone"},
                                new Lone{lone_type="Home Lone"}

                             }
                         }
                    }
                },
                new AccountType
                {
                    SName="Current Account",
                    Customers =
                     {
                         new Customer
                         {
                            SId=5,
                            SName="Pavan",
                             Lones=
                             {
                                new Lone{lone_type="Education Lone"},
                                new Lone{lone_type="Car Lone"}

                             }
                         },
                         new Customer
                         {
                            SId=6,
                            SName="Pooja",
                             Lones=
                             {
                                new Lone{lone_type="Shop Lone"},
                                new Lone{lone_type="Bissuness Lone"}

                             }
                         },
                         new Customer
                         {
                            SId=9,
                            SName="Pritam",
                             Lones=
                             {
                                new Lone{lone_type="Truck Lone"},
                                new Lone{lone_type="Car Lone"}

                             }
                         }
                    }
                },

            };
         foreach(AccountType a in accounts)
            {
                Console.WriteLine($"{a.SName}");
                foreach(Customer c in a.Customers)
                {
                    Console.WriteLine($"\t{c.SId}   {c.SName}");
                    foreach (Lone l in c.Lones)
                    {
                        Console.WriteLine($"\t  \t  {l.lone_type}");
                    }
                }
            }
        }
    }
}
