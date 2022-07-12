Console.WriteLine("Lütfen metin veya kelime giriniz: ");
string kelime = Console.ReadLine();
string son = ReverseString(kelime);
Console.WriteLine($"Girdiğiniz değer: {kelime}\nSonuç: {son}");

string ReverseString(string kelime)
{
    char[] charArr = kelime.ToCharArray();
    string reverseString = String.Empty;
    for(int i = charArr.Length - 1; i > -1; i--)
        reverseString += charArr[i];
    return reverseString;
}