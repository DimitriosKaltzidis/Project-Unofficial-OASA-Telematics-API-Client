namespace OASA.Telematics.Client
{
    using System;
    using System.Text;

    public static class Extensions
    {
        public static string UnicodeToUtf8(this string originalString)
        {
            var byteSource = Encoding.Unicode.GetBytes(originalString);
            var byteDestination = Encoding.Convert(Encoding.Unicode, Encoding.ASCII, byteSource);
            return Encoding.ASCII.GetString(byteDestination);
        }
    }
}
