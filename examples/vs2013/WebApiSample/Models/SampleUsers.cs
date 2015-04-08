using System.Collections.Generic;

namespace WebApiSample.Models
{
    public static class SampleUsers
    {
        private static int id = 0;

        public static IEnumerable<User> GetUsers()
        {
            id = 0;

            yield return new User { Id = GetId(), Username = GetUsername(), FirstName = "Sheldon", LastName = "Cooper" };
            yield return new User { Id = GetId(), Username = GetUsername(), FirstName = "Leonard", LastName = "Hofstadter" };
            yield return new User { Id = GetId(), Username = GetUsername(), FirstName = "Howard", LastName = "Wolowitz" };
            yield return new User { Id = GetId(), Username = GetUsername(), FirstName = "Rajesh", LastName = "Koothrappali" };
            yield return new User { Id = GetId(), Username = GetUsername(), FirstName = "Amy", LastName = "Farrah Fowler" };
            yield return new User { Id = GetId(), Username = GetUsername(), FirstName = "Stuart", LastName = "Bloom" };
        }


        private static int GetId()
        {
            return ++id;
        }

        private static string GetUsername()
        {
            return id.ToString().PadLeft(5, '0');
        }
    }
}