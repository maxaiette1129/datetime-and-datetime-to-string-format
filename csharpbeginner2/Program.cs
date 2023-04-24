namespace csharpbeginner2
{
     class Program
    {
        static void Main(string[] args)
        {
           
            var formatedstring = returnDateTime(DateTime.Now, DateTime.Now.ToString("t"));
            Console.WriteLine(formatedstring);
            
            
        }
        private static string returnDateTime(DateTime myDatetime, string dateFormat)
        {

            return string.Format(dateFormat, myDatetime.Date);
        }
    }
}