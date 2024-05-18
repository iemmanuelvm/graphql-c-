
using GraphQL.Types;
using GraphqlProject.Interfaces;
using GraphqlProject.Models;

namespace GraphqlProject.Type
{
    public class CategoryType : ObjectGraphType<Category>
    {
        public CategoryType(IMenuRepository menuRepository)
        {
            Field(c => c.Id);
            Field(c => c.Name);
            Field(c => c.ImageUrl);
            Field<ListGraphType<MenuType>>("Menus").Resolve(context =>
            {
                return menuRepository.GetAllMenu();
            });
        }
    }
}