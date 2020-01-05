using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencyInCSharpCookbook2e.ConsoleApp
{
    class ch02_console
    {
        public async Task Execute()
        {

            /// Chapter 2 Recipe 1
            /// Daily cat facts! : https://alexwohlbruck.github.io/cat-facts/
            //var catFacts_withRetries = await new ch02r01().DownloadStringWithRetries(new System.Net.Http.HttpClient(), "https://cat-fact.herokuapp.com/facts/random?animal_type=cat&amount=2");
            //Console.WriteLine(catFacts_withRetries);

            //var catFacts_withTimeout = await new ch02r01().DownloadStringWithTimeout(new System.Net.Http.HttpClient(), "https://cat-fact.herokuapp.com/facts/random?animal_type=cat&amount=2");
            //Console.WriteLine(catFacts_withTimeout);


            /// Chapter 2 Recipe 3
            await new ch02r03().CallMyMethodAsync();
        }
    }
}
