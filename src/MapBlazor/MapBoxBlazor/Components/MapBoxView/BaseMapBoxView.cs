using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MatBlazor;

namespace MapBoxBlazor
   
{
    public class BaseMapBoxView : BaseMatDomComponent
    {
        protected async override Task OnFirstAfterRenderAsync()
        {
            await base.OnFirstAfterRenderAsync();
            await JsInvokeAsync<object>("mapbox.Map.init", "123");
        }

    }
}
