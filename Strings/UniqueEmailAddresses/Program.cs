// Problem 929. Unique Email Addresses
// Link https://leetcode.com/problems/unique-email-addresses/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    string[] emails = { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" };
    int output = NumUniqueEmails(emails);
    Console.WriteLine(output);
  }
  public static int NumUniqueEmails(string[] emails)
  {
    HashSet<string> uniqueEmails = new HashSet<string>();

    foreach (string email in emails)
    {
      string normalizedEmail = NormalizeEmail(email);
      uniqueEmails.Add(normalizedEmail);
    }

    return uniqueEmails.Count;
  }

  private static string NormalizeEmail(string email)
  {
    string[] parts = email.Split('@');

    string localName = parts[0];
    string domainName = parts[1];

    int plusIndex = localName.IndexOf('+');

    if (plusIndex != -1)
    {
      localName = localName.Substring(0, plusIndex);
    }

    localName = localName.Replace(".", "");

    return localName + "@" + domainName;
  } 
}
