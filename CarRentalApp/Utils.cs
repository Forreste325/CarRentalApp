using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CarRentalApp
{
    public static class Utils
    {
        public static bool FormIsOpen(string name)
        {
            //looking for open window
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(t => t.Name == name);
            return isOpen;
        }
        public static string HashPassword(string password)
        {
            SHA256 sha = SHA256.Create();

            //Convert the input string to a byte array and compute the hash.
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

            //Create a new Stringbuilder to collect the bytes and create a new string
            StringBuilder sb = new StringBuilder();

            //Loop through each byte of the hased data and format each one as a hex string
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }
            return sb.ToString();
        }

        public static string DefaultHashedPassword()
        {
            SHA256 sha = SHA256.Create();

            //Convert the input string to a byte array and compute the hash.
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes("password@123"));

            //Create a new Stringbuilder to collect the bytes and create a new string
            StringBuilder sb = new StringBuilder();

            //Loop through each byte of the hased data and format each one as a hex string
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
