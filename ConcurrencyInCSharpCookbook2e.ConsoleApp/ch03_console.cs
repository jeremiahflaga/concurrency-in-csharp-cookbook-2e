using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencyInCSharpCookbook2e.ConsoleApp
{
    class ch03_console
    {
        public async Task Execute()
        {
            /// Chapter 3 Jboy's test
            await new ch03r02_JBOY().ProcessValueAsync();
        }
    }
}
