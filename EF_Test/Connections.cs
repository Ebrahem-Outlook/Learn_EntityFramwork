using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Test
{
    public static class Connections
    {
        public const String sqlConStr = """
            Server=DESKTOP-5PAVE27;
            Database=DB_EF_Test;
            User Id=sa;
            Password=12345;
            TrustServerCertificate=True;
            """;
    }
}
