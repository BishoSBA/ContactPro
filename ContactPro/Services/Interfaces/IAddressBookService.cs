using ContactPro.Models;

namespace ContactPro.Services.Interfaces
{
    public interface IAddressBookService
    {
        Task AddContactToCategoryAsync(int contactId, int categoryId);
        Task<bool> IsContactInCategory(int contactId, int categoryId);
        Task<IEnumerable<Category>> GetUserCategoriesAsync(string userId);
        Task<ICollection<int>> GetContactCategoryIdsAsync(int contactId);
        Task<ICollection<Category>> GetContactCategoriesAsync(int contactId);
        Task RemoveContactFromCategoryAsync(int contactId, int categoryId);
        IEnumerable<Contact> SearchForContacts(string userId, string searchString);

    }
}
