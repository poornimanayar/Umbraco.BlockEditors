using Perplex.ContentBlocks.Categories;
using System;
using Umbraco.Core.Composing;

namespace Umbraco.BlockEditors.PerplexContentBlocks
{

    public class DemoContentBlockCategoryComposer : ComponentComposer<DemoContentBlockCategorySetUpComponent> { }

    public class DemoContentBlockCategorySetUpComponent : IComponent
    {
        private readonly IContentBlockCategoryRepository _contentBlockCategoryRepository;

        public DemoContentBlockCategorySetUpComponent(IContentBlockCategoryRepository contentBlockCategoryRepository)
        {
            _contentBlockCategoryRepository = contentBlockCategoryRepository;
        }

        public void Initialize()
        {
            _contentBlockCategoryRepository.Add(new DemoContentBlockCategory());
        }

        public void Terminate()
        {

        }
    }

    public class DemoContentBlockCategory : IContentBlockCategory
    {
        public Guid Id => Guid.Parse("b1f44c1a-8f66-475e-bdd3-21b3a48c157e");

        public string Name => "Umbraco Block Editors Demo";

        public string Icon => "icon-heart";

        public bool IsHidden => false;

        public bool IsEnabledForHeaders => true;

        public bool IsDisabledForBlocks => false;
    }
}