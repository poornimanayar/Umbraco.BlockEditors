using Perplex.ContentBlocks.Definitions;
using System;
using Umbraco.BlockEditors.PerplexContentBlocks;
using Umbraco.Core.Composing;

namespace Umbraco.BlockEditors.Components
{

    //Composer
    [RuntimeLevel(MinLevel = Umbraco.Core.RuntimeLevel.Run)]
    public class ContentBlockComposer : ComponentComposer<PerplexContentBlocksComponent> { }


    //Component

    public class PerplexContentBlocksComponent : IComponent
    {
        private readonly IContentBlockDefinitionRepository _definitions;

        private readonly DemoContentBlockCategory _demoContentBlockCategory;
        public PerplexContentBlocksComponent(IContentBlockDefinitionRepository definitions)
        {
            _definitions = definitions;
            _demoContentBlockCategory = new DemoContentBlockCategory();
        }

        public void Initialize()
        {

            var heroBlock = new ContentBlockDefinition
            {
                Name = "Hero Content Block", //name of the block
                Id = Guid.Parse("b1f44c8a-8f66-475e-bdd3-21b3a48c157e"),//unique id, create your own guid
                DataTypeKey = Guid.Parse("b9f44c8a-8f66-475e-bdd3-21b3a48c157e"), //datatype key for nested content data type created for the block
                PreviewImage = "/assets/img/hero.png", // Image that shows in the UI as a preview of this block. Relative path from the root of your site to an image.
                Description = "Hero Content Block", //Description of this Content Block
                CategoryIds = new[] //List of ids of the categories this Content Block should appear in. This references the id of a IContentBlockCategory
                {
                    Perplex.ContentBlocks.Constants.Categories.Headers,
                    Perplex.ContentBlocks.Constants.Categories.Content,
                    _demoContentBlockCategory.Id
                },

                Layouts = new IContentBlockLayout[] //List of all layouts of this Content Block
                {
                    new ContentBlockLayout
                    {
                        Id =Guid.Parse("b2f44c8a-8f66-475e-bdd3-21b3a48c157e"), //unique id, create your own guid
                        Name = "Layout 1",//name for layout
                        Description = "Centre Aligned Text", //description
                        PreviewImage = "/assets/img/hero.png", //preview image for backoffice
                        ViewPath = "~/Views/Partials/PerplexContentBlocks/Hero/Layout1.cshtml" //view for website rendering
                    },
                    new ContentBlockLayout
                    {
                        Id = Guid.Parse("b3f44c8a-8f66-475e-bdd3-21b3a48c157e"),
                        Name = "Layout 2",
                        Description = "",
                        PreviewImage = "/assets/img/layout2.png",
                        ViewPath = "~/Views/Partials/PerplexContentBlocks/Hero/Layout2.cshtml"
                    },
                }
            };

            _definitions.Add(heroBlock);

            var podsBlock = new ContentBlockDefinition
            {
                Name = "Pods Block", //name of the block
                Id = Guid.Parse("b4f44c8a-8f66-475e-bdd3-21b3a48c157e"),//unique id
                DataTypeKey = Guid.Parse("d0bf8fe5-7cef-42e8-a8d6-a1af88569679"), //datatype key for nested content data type created for the block
                PreviewImage = "/assets/img/pods.png", // Image that shows in the UI as a preview of this block. Relative path from the root of your site to an image.
                Description = "Pods Content Block", //Description of this Content Block
                CategoryIds = new[] //List of ids of the categories this Content Block should appear in. This references the id of a IContentBlockCategory. See Content Block Categories for more details on categories.
               {
                    Perplex.ContentBlocks.Constants.Categories.Content,
                    _demoContentBlockCategory.Id
                },

                Layouts = new IContentBlockLayout[] //List of all layouts of this Content Block
                {
                    new ContentBlockLayout
                    {
                        Id = Guid.Parse("b5f44c8a-8f66-475e-bdd3-21b3a48c157e"),
                        Name = "Pods",
                        Description = "",
                        PreviewImage = "/assets/img/hero.png",
                        ViewPath = "~/Views/Partials/PerplexContentBlocks/Pods/Pods.cshtml"
                    }
                }
            };

            _definitions.Add(podsBlock);

            var stepsBlock = new ContentBlockDefinition
            {
                Name = "Configuration Steps Block", //name of the block
                Id = Guid.Parse("b6f44c8a-8f66-475e-bdd3-21b3a48c157e"),//unique id
                DataTypeKey = Guid.Parse("7d242d00-e42c-467f-a5d5-dd1d8b75e356"), //datatype key for nested content data type created for the block
                PreviewImage = "/assets/img/steps.png", // Image that shows in the UI as a preview of this block. Relative path from the root of your site to an image.
                Description = "Configuration Steps Content Block", //Description of this Content Block
                CategoryIds = new[] //List of ids of the categories this Content Block should appear in. This references the id of a IContentBlockCategory. See Content Block Categories for more details on categories.
               {
                    Perplex.ContentBlocks.Constants.Categories.Content,
                    _demoContentBlockCategory.Id
                },

                Layouts = new IContentBlockLayout[] //List of all layouts of this Content Block
                {
                    new ContentBlockLayout
                    {
                        Id = Guid.Parse("b7f44c8a-8f66-475e-bdd3-21b3a48c157e"),
                        Name = "Steps",
                        Description = "",
                        PreviewImage = "/assets/img/hero.png",
                        ViewPath = "~/Views/Partials/PerplexContentBlocks/Steps/Steps.cshtml"
                    }
                }
            };

            _definitions.Add(stepsBlock);
        }

        public void Terminate()
        {
            
        }
    }
}