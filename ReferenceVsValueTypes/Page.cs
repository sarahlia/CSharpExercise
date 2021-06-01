using System;
using System.Threading.Tasks;

namespace Ref
{
    public class Page
    {
        string result;

        public Page(string name)
        {
            Name = name;
        }

        public string Name
        {
            get;
            set;
        }

        public async void btnStart_Click()
        {
            await SaySomething(); //if the 'await' is OMITTED, the output would be an empty line. Otherwise if it's as written here, "Hello world" would appear after 1000 ms.
            string txtSomeTextBlock;
            txtSomeTextBlock = result;
            Console.WriteLine(result);
        }
        
        async Task<string> SaySomething()
        {
            await Task.Delay(1000); 

            result = "Hello world!";
            return result;
        }
    }
}