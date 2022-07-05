namespace BlazorWebAsApp.Client.Services.CategoryService;

public interface ICategoryService
{
    List<Category> Categories { get; set; }
    List<Category> AdminCategories { get; set; }
    event Action OnChange;
    Task GetCategories();
    Task GetAdminCategories();
    Task AddCategory(Category category);
    Task UpdateCategory(Category category);
    Task DeleteCategory(int categoryId);
    Category CreateNewCategory();
}