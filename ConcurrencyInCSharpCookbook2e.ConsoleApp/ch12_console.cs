using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencyInCSharpCookbook2e.ConsoleApp
{
    class ch12_console
    {
        public async Task Execute()
        {
            /// chapter 12, before recipes
            Console.WriteLine(await new ch12r00B().ModifyValueConcurrentlyAsync());
            /// Run from a threadpool thread (e.g., from Task.Run)
            //await Task.Run(() => new ch12r00B().ModifyValueConcurrentlyAsync());


            //await new ch12r00C().ModifyValueConcurrentlyAsync();

            /// Run from a threadpool thread (e.g., from Task.Run)
            //await Task.Run(() => new ch12r00C().ModifyValueConcurrentlyAsync());


            //Console.WriteLine(await new ch12r00G().PlayWithStackAsync());
        }
    }
}
