using BBlog.Models;
using BBlogBlazor.Services.IRepository;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BBlogBlazor.Pages.Blog.BlogDetail
{
    public partial class BlogDetail
    {
        [Inject] public IPostClient PostClient { get; set; }
        [Inject] IJSRuntime JSRuntime { get; set; }

        private bool _loadingContent = false;
        private ElementReference _quillJSReadEditorDiv;

        [Parameter]
        public string PostId { get; set; }

        private PostDto PostDetail { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            _loadingContent = true;
            PostDetail = await PostClient.GetPostDetail(PostId);

            StateHasChanged();

            await JSRuntime.InvokeVoidAsync("QuillFunctions.createQuill", _quillJSReadEditorDiv, false);

            if (string.IsNullOrEmpty(PostDetail.Content) == false)
            {
                await JSRuntime.InvokeAsync<object>("QuillFunctions.setQuillContent", _quillJSReadEditorDiv, PostDetail.Content);
            }

            await JSRuntime.InvokeAsync<object>("QuillFunctions.disableQuillEditor", _quillJSReadEditorDiv);
            _loadingContent = false;
            StateHasChanged();
        }
    }
}
