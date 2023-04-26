namespace csharpbeginner2
{
     class Program
    {
        static void Main(string[] args)
        {
           
            var formatedstring = returnDateTime(DateTime.Now, DateTime.Now.ToString("t"));
            Console.WriteLine(formatedstring);
            Console.WriteLine();

            //overwriting the formatedstring content
            formatedstring = returnDateTime(DateTime.Today, DateTime.Today.ToString("tt"));
            Console.WriteLine(formatedstring);

            var formated = date2(DateTime.Today, DateTime.Today.ToString("MMM"));
            Console.WriteLine(formated);

            //other way 

            DateTime date = DateTime.Now;

            string format = date.ToString("F");

            Console.WriteLine(format);


        }
        private static string returnDateTime(DateTime myDatetime, string dateFormat)
        {

            return string.Format(dateFormat, myDatetime.Date);
        }
        public static string date2(DateTime dateTime, string dateFormat) 
        {
            return dateTime.ToString(dateFormat);
        }
    }
}