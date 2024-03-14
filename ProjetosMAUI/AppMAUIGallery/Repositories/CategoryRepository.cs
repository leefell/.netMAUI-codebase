﻿using AppMAUIGallery.Models;
using AppMAUIGallery.Views.Components.Mains;
using AppMAUIGallery.Views.Components.Visuals;
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
                Name = "Layouts",
                Components = new List<Component> {
                    new Component {
                    Title = "StackLayout",
                    Description = "Organização sequencial dos elementos.",
                    Page = typeof(StackLayoutPage)
                    },
                    new Component
                    {
                        Title = "Grid",
                        Description = "Organiza os elementos dentro de uma tabela.",
                        Page = typeof(GridLayoutPage)
                    },
                    new Component
                    {
                        Title = "AbsoluteLayout",
                        Description = "Liberdade total para posicionar e dimensionar os elementos na tela.",
                        Page = typeof(AbsoluteLayoutPage)
                    },
                    new Component
                    {
                        Title = "FlexLayout",
                        Description = "Organiza os elementos de forma sequencial com muitas opções de personalização.\n",
                        Page = typeof(FlexLayoutPage)
                    }
                }
            });
            categories.Add(new Category()
            {
                Name = "Componentes (Views)",
                Components = new List<Component>
                {
                    new Component
                    {
                        Title = "BoxView",
                        Description = "Um componente que cria uma caixa para ser apresentada.",
                        Page = typeof(BoxViewPage)
                    },
                    new Component
                    {
                        Title = "Label",
                        Description = "Apresenta um texto na tela.",
                        Page = typeof(LabelPage)
                    },
                    new Component
                    {
                        Title = "Button",
                        Description = "Apresenta um botão na tela.",
                        Page = typeof(ButtonPage)
                    },
                    new Component
                    {
                        Title = "Image",
                        Description = "Apresenta uma imagem na tela.",
                        Page = typeof(ImagePage)
                    },
                    new Component
                    {
                        Title = "ImageButton",
                        Description = "Apresenta uma imagem com o comportamento de um botão.",
                        Page = typeof(ButtonImagePage)
                    }
                }
            });
            categories.Add(new Category
            {
                Name = "Visuais",
                Components = new List<Component>
                {
                    new Component
                    {
                        Title = "Frame",
                        Description = "Caixa que envolve outros elementos.",
                        Page = typeof(FramePage)
                    },
                    new Component
                    {
                        Title = "Border",
                        Description = "Caixa que envolve outros elementos.",
                        Page = typeof(BorderPage)
                    }
                }
            }); 
            return categories;
        }
    }
}
