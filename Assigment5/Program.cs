namespace Assigment5
    
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //answer 1
            Book b1 = new Book();
            // b1.passWord ;//غير قابله للاستخدام لان الprivate مرئيه فقط فى ال scope بتاعها الى هو الclass;

            //answer 2
            b1.copiesInStock = 500;//لان الinternal مرئيه داخل الكلاس وداخل البروجيكت طالما فى نفس الassemply

            //answer 3
            b1.Title = "good book";
            Console.WriteLine(b1.Title);
            //answer 4 
            b1.gan=Genra.science;
            Console.WriteLine(b1.gan);
            //answer 5
            Console.WriteLine((int)Genra.fiction);
            Console.WriteLine((int)Genra.nonfiction);
            Console.WriteLine((int)Genra.science);
            //answer 6
            int genreNumber =  1;
            Genra g =(Genra) genreNumber;
            Console.WriteLine(g);
            //answer 7
            Genra genra = Genra.fiction;
            Console.WriteLine(genra.ToString());

            


        }
    }
}
