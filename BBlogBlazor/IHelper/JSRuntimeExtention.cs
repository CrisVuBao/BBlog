using Microsoft.JSInterop;

namespace BBlogBlazor.IHelper
{
    public static class JSRuntimeExtention
    {
        public static async ValueTask ToastrSuccess(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("ShowToastrt", "Success", message);
        }

        public static async ValueTask ToastrError(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("ShowToastrt", "Error", message);
        }
    }
}
