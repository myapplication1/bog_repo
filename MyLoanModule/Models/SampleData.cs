using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLoanModule.Models {
    static class SampleData {
        public static List<Order> Orders = new List<Order>() {
            new Order {
                AccountID = 10248,
                AccountDate = new DateTime(1996, 7, 4),
                ShipCountry = "Ghana",
                ShipCity = "Kumasi",
                CustomerName = "Grant Bills"
            },
            new Order {
                AccountID = 10249,
                AccountDate = new DateTime(1996, 7, 5),
                ShipCountry = "France",
                ShipCity = "Paris",
                CustomerName = "Will Anne"
            },
            new Order {
                AccountID = 10250,
                AccountDate = new DateTime(1996, 9, 4),
                ShipCountry = "Ghana",
                ShipCity = "Accra",
                CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10296,
                AccountDate = new DateTime(1996, 9, 3),
                ShipCountry = "Ghana",
                ShipCity = "Tema",
                CustomerName = "Francis Banini"
            },
            new Order {
                AccountID = 10252,
                AccountDate = new DateTime(1996, 7, 9),
                ShipCountry = "Belgium",
                ShipCity = "Charleroi",
                CustomerName = "CR7 Ronaldo"
            },
            new Order {
                AccountID = 10253,
                AccountDate = new DateTime(1996, 7, 10),
                ShipCountry = "Brazil",
                ShipCity = "Rio de Janeiro",
                CustomerName = "Marcelo Boy"
            },
            
            new Order {
                AccountID = 10256,
                AccountDate = new DateTime(1996, 7, 15),
                ShipCountry = "Brazil",
                ShipCity = "Resende",
                CustomerName = "Ghana Boys"
            },
            new Order {
                AccountID = 10257,
                AccountDate = new DateTime(1996, 7, 16),
                ShipCountry = "Venezuela",
                ShipCity = "San Cristóbal",
                CustomerName = "Agya Koo"
            },
            new Order {
                AccountID = 10258,
                AccountDate = new DateTime(1996, 7, 17),
                ShipCountry = "Austria",
                ShipCity = "Graz",
                CustomerName = "Kojo Nkansah"
            },
            new Order {
                AccountID = 10259,
                AccountDate = new DateTime(1996, 7, 18),
                ShipCountry = "Mexico",
                ShipCity = "México D.F.",
                CustomerName = "Francisco Chang"
            },
            new Order {
                AccountID = 10260,
                AccountDate = new DateTime(1996, 7, 19),
                ShipCountry = "Germany",
                ShipCity = "Köln",
               CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10261,
                AccountDate = new DateTime(1996, 7, 19),
                ShipCountry = "Brazil",
                ShipCity = "Rio de Janeiro",
                  CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10262,
                AccountDate = new DateTime(1996, 7, 22),
                ShipCountry = "USA",
                ShipCity = "Albuquerque",
                 CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10263,
                AccountDate = new DateTime(1996, 7, 23),
                ShipCountry = "Austria",
                ShipCity = "Graz",
                   CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10264,
                AccountDate = new DateTime(1996, 7, 24),
                ShipCountry = "Sweden",
                ShipCity = "Bräcke",
                  CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10265,
                AccountDate = new DateTime(1996, 7, 25),
                ShipCountry = "France",
                ShipCity = "Strasbourg",
                   CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10266,
                AccountDate = new DateTime(1996, 7, 26),
                ShipCountry = "Finland",
                ShipCity = "Oulu",
                 CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10267,
                AccountDate = new DateTime(1996, 7, 29),
                ShipCountry = "Germany",
                ShipCity = "München",
                   CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10268,
                AccountDate = new DateTime(1996, 7, 30),
                ShipCountry = "Venezuela",
                ShipCity = "Caracas",
                  CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10269,
                AccountDate = new DateTime(1996, 7, 31),
                ShipCountry = "USA",
                ShipCity = "Seattle",
                CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10270,
                AccountDate = new DateTime(1996, 8, 1),
                ShipCountry = "Finland",
                ShipCity = "Oulu",
                  CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10271,
                AccountDate = new DateTime(1996, 8, 1),
                ShipCountry = "USA",
                ShipCity = "Lander",
              CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10272,
                AccountDate = new DateTime(1996, 8, 2),
                ShipCountry = "USA",
                ShipCity = "Albuquerque",
                 CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10273,
                AccountDate = new DateTime(1996, 8, 5),
                ShipCountry = "Germany",
                ShipCity = "Cunewalde",
                  CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10274,
                AccountDate = new DateTime(1996, 8, 6),
                ShipCountry = "France",
                ShipCity = "Reims",
                  CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10275,
                AccountDate = new DateTime(1996, 8, 7),
                ShipCountry = "Italy",
                ShipCity = "Bergamo",
                 CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10276,
                AccountDate = new DateTime(1996, 8, 8),
                ShipCountry = "Mexico",
                ShipCity = "México D.F.",
                 CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10277,
                AccountDate = new DateTime(1996, 8, 9),
                ShipCountry = "Germany",
                ShipCity = "Leipzig",
                  CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10278,
                AccountDate = new DateTime(1996, 8, 12),
                ShipCountry = "Sweden",
                ShipCity = "Luleå",
                  CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10279,
                AccountDate = new DateTime(1996, 8, 13),
                ShipCountry = "Germany",
                ShipCity = "Frankfurt a.M.",
                 CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10280,
                AccountDate = new DateTime(1996, 8, 14),
                ShipCountry = "Sweden",
                ShipCity = "Luleå",
                  CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10281,
                AccountDate = new DateTime(1996, 8, 14),
                ShipCountry = "Spain",
                ShipCity = "Madrid",
                  CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10282,
                AccountDate = new DateTime(1996, 8, 15),
                ShipCountry = "Spain",
                ShipCity = "Madrid",
                  CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10283,
                AccountDate = new DateTime(1996, 8, 16),
                ShipCountry = "Venezuela",
                ShipCity = "Barquisimeto",
                 CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10284,
                AccountDate = new DateTime(1996, 8, 19),
                ShipCountry = "Germany",
                ShipCity = "Frankfurt a.M.",
               CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10285,
                AccountDate = new DateTime(1996, 8, 20),
                ShipCountry = "Germany",
                ShipCity = "Cunewalde",
                  CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10286,
                AccountDate = new DateTime(1996, 8, 21),
                ShipCountry = "Germany",
                ShipCity = "Cunewalde",
                  CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10287,
                AccountDate = new DateTime(1996, 8, 22),
                ShipCountry = "Brazil",
                ShipCity = "Rio de Janeiro",
                  CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10288,
                AccountDate = new DateTime(1996, 8, 23),
                ShipCountry = "Italy",
                ShipCity = "Reggio Emilia",
                  CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10289,
                AccountDate = new DateTime(1996, 8, 26),
                ShipCountry = "UK",
                ShipCity = "London",
                  CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10290,
                AccountDate = new DateTime(1996, 8, 27),
                ShipCountry = "Brazil",
                ShipCity = "Sao Paulo",
                 CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10291,
                AccountDate = new DateTime(1996, 8, 27),
                ShipCountry = "Brazil",
                ShipCity = "Rio de Janeiro",
                 CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10292,
                AccountDate = new DateTime(1996, 8, 28),
                ShipCountry = "Brazil",
                ShipCity = "Sao Paulo",
               CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10293,
                AccountDate = new DateTime(1996, 8, 29),
                ShipCountry = "Mexico",
                ShipCity = "México D.F.",
                  CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10294,
                AccountDate = new DateTime(1996, 8, 30),
                ShipCountry = "USA",
                ShipCity = "Albuquerque",
                  CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10295,
                AccountDate = new DateTime(1996, 9, 2),
                ShipCountry = "Nigeria ",
                ShipCity = "Lagos",
                 CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10296,
                AccountDate = new DateTime(1996, 9, 3),
                ShipCountry = "Ghana",
                ShipCity = "Tema",
                CustomerName = "Kristotro Amoah"
            },
            new Order {
                AccountID = 10297,
                AccountDate = new DateTime(1996, 9, 4),
                ShipCountry = "Ghana",
                ShipCity = "Accra",
                CustomerName = "Kristotro Amoah"
            }
        };
    }
}
