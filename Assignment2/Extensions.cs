namespace Assignment2;

public static class Extensions
{
    public static bool isSecure(Uri uri) => uri.Scheme == "https";
    public static int WordCount(string str) => str.Split(" ").Length;
}
