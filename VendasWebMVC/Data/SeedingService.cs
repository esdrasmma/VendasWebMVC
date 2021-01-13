using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMVC.Models;
using VendasWebMVC.Models.Enums;

namespace VendasWebMVC.Data
{
    public class SeedingService
    {
        private VendasWebMVCContext _context;

        public SeedingService(VendasWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return;
            }
            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Joao da Silva", "joao@jmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Maria Souza", "maria@jmail.com", new DateTime(1988, 2, 11), 7000.0, d2);
            Seller s3 = new Seller(3, "George Pacheco", "george@jmail.com", new DateTime(1994, 11, 1), 2100.0, d3);
            Seller s4 = new Seller(4, "Jennifer Suzy", "jennifer@jmail.com", new DateTime(2000, 4, 22), 3100.0, d4);
            Seller s5 = new Seller(5, "Addan Sandler", "addan@jmail.com", new DateTime(1966, 4, 3), 1500.0, d1);
            Seller s6 = new Seller(6, "Angelina Jolie", "angelina@jmail.com", new DateTime(1978, 2, 4), 4100.0, d3);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2020, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2020, 09, 25), 1000.0, SaleStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2020, 09, 25), 21000.0, SaleStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2020, 09, 26), 1500.0, SaleStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2020, 09, 26), 14000.0, SaleStatus.Billed, s2);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2020, 09, 27), 1000.0, SaleStatus.Billed, s1);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2020, 09, 28), 4000.0, SaleStatus.Billed, s3);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2020, 09, 29), 7000.0, SaleStatus.Billed, s5);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2020, 09, 30), 8000.0, SaleStatus.Billed, s6);



            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4 , s5, s6);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r5, r6, r7, r8, r9);

            _context.SaveChanges();





        }
    }
}
