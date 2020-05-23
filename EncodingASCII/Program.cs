using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncodingASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            Byte[] bytes;
            String chars = "ASCII Encoding Example";

            ASCIIEncoding ascii = new ASCIIEncoding();

            int byteCount = ascii.GetByteCount(chars.ToCharArray(), 6, 8);
            bytes = new Byte[byteCount];
            int bytesEncodedCount = ascii.GetBytes(chars, 6, 8, bytes, 0);

            Console.WriteLine(
                "{0} bytes used to encode string.", bytesEncodedCount
            );

            Console.Write("Encoded bytes: ");
            foreach (Byte b in bytes)
            {
                Console.Write("[{0}]", b);
            }
            Console.WriteLine();




            //Another Example
            const string input = "Dot Net Perls";

            // Invoke GetBytes method.
            // ... You can store this array as a field!
            byte[] array = Encoding.ASCII.GetBytes(input);

            // Loop through contents of the array.
            foreach (byte element in array)
            {
                Console.WriteLine("{0} = {1}", element, (char)element);
            }



            byte[] array2 =
	{
	    68,
	    111,
	    116,
	    32,
	    78,
	    101,
	    116,
	    32,
	    80,
	    101,
	    114,
	    108,
	    115
	};

            string value = ASCIIEncoding.ASCII.GetString(array2);
            Console.WriteLine(value);

            Console.Read();



        }
    }

}


