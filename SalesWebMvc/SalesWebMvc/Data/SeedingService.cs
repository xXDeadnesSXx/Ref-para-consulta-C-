using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;


namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;
        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecords.Any())
            {//Testa para ver se há algo na base de dados, caso haja não faz nada
                return;
            }

            Department d1 = new Department(1, "Tecnologia");
            Department d2 = new Department(2, "Livraria");
            Department d3 = new Department(3, "Moda");
            Department d4 = new Department(4, "Saúde");

            Seller s1 = new Seller(1, "João", "joao@gmail.com", new DateTime(1980, 02, 01), 845.75, d4);
            Seller s2 = new Seller(2, "Maria", "maria@gmail.com", new DateTime(1985, 11, 03), 1000.50, d3);
            Seller s3 = new Seller(3, "Paulo", "paulo@gmail.com", new DateTime(1990, 09, 15), 1050.00, d2);
            Seller s4 = new Seller(4, "Thiago", "thiago@gmail.com", new DateTime(1995, 06, 20), 900.00, d1);
            Seller s5 = new Seller(5, "Lucas", "lucas@gmail.com", new DateTime(1970, 03, 18), 3000.00, d2);
            Seller s6 = new Seller(6, "Fábio", "fabio@gmail.com", new DateTime(1976, 12, 01), 2500.00, d4);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2000, 06, 01), 20000.0, SaleStatus.Billed, s3);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2001, 06, 01), 25000.0, SaleStatus.Billed, s4);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2002, 06, 01), 30000.0, SaleStatus.Billed, s2);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2003, 06, 01), 35000.0, SaleStatus.Billed, s1);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2004, 06, 01), 40000.0, SaleStatus.Billed, s3);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2005, 06, 01), 45000.0, SaleStatus.Pending, s5);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2006, 06, 01), 50000.0, SaleStatus.Pending, s2);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2007, 06, 01), 55000.0, SaleStatus.Canceled, s1);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2008, 06, 01), 60000.0, SaleStatus.Canceled, s6);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecords.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9);

            _context.SaveChanges();
        }

    }
}
