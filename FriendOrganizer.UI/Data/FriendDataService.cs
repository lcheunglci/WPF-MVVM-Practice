using FriendOrganizer.Model;
using System.Collections.Generic;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            // TODO: Load data from a real database.
            yield return new Friend { FirstName = "Bob", LastName = "Doe" };
            yield return new Friend { FirstName = "Alice", LastName = "Jackson" };
            yield return new Friend { FirstName = "Carl", LastName = "Smith" };
            yield return new Friend { FirstName = "Tony", LastName = "Stark" };
        }
    }
}
