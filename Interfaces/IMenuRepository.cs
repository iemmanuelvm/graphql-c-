using GraphqlProject.Models;

namespace GraphqlProject.Interfaces
{
    public interface IMenuRepository
    {
        List<Menu> GetAllMenu();
        Menu GetMenuById(int id);
        Menu AddMenu(Menu menu);
        Menu UpdateMenu(int id, Menu menu);
        void DeleteMenu(int id);
    }
}