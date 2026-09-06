using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Channels;

namespace c_assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            {
                Book B1 = new Book();
                object name = B1;
                Console.WriteLine(name);
            }
        }


     
        class Book
        {
            string title;
            int pages;
        }
    }
}