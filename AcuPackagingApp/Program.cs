using System;
using PX.Data;
using PX.Objects.GL;

namespace AcuPackagingApp
{
    public static class Program
    {
        public static void Main()
        {
            const string userName = @"admin";
            const string tenantName = @"Company";

            using (new PXLoginScope($"{userName}@{tenantName}"))
            {
                var graph = PXGraph.CreateInstance<PXGraph>();
                foreach (Account row in PXSelect<Account>.Select(graph))
                {
                    Console.WriteLine($"{row.AccountCD} - {row.Description}");
                }
            }

            Console.WriteLine("Press any key to exit !");
            Console.ReadKey();
        }
    }
}
