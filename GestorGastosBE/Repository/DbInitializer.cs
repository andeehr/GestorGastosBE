using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorGastosBE.Repository
{
    public class DbInitializer
    {
        public static void Initialize(GGContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.CategoriasGasto.Any()) {
                return;   // DB has been seeded
            }
        }
    }
}
