using System.Text.RegularExpressions;


Console.WriteLine("Please, enter your phone number:");
string phonenumber = Console.ReadLine();
var matcher = Regex.Match(phonenumber, @"^(\+)(370|371)[0-9 \-\(\)\.]");


if (matcher.Success)
{
    Console.WriteLine("Phone number is correct!");
}
else
{
    Console.WriteLine("Phone number isn't correct!");
}

