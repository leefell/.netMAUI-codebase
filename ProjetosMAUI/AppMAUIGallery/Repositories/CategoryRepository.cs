using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppMAUIGallery.Models;
using AppMAUIGallery.Views.Layouts;

namespace AppMAUIGallery.Repositories
{
    // essa classe vai funcionar tipo um banco de dados
    internal class CategoryRepository
    {
        public CategoryRepository()
        {

        }
        public List<Category> GetCategories()
        {
            // Foi criado uma categoria e um componente

            List<Category> categories = new List<Category>();
            categories.Add(new Category
            {
                Name = "Layout",
                Components = new List<Component> {
                    new Component {
                    Title = "StackLayout",
                    Description = "Organização sequencial dos elementos.",
                    Page = new StackLayoutPage()} }
            });

            return categories;
        }
    }
}
