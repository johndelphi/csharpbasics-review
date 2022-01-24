using System;
using System.Linq;
namespace csharpbasics_review
{
  class Program
  {
    static void Main(string[] args)
    {
      //linq queries and opperators
      var usersQuery = new string[] { "jeff", "tom","john","mark"};
      var userQuery = from user in usersQuery
                      where user.Contains("m")
                      orderby user.Length ascending
                                            select user;
      foreach(var user in usersQuery)
      {
                Console.WriteLine(user);
      }
      
    }
  }
}
