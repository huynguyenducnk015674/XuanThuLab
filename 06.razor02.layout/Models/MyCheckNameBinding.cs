using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06.razor02.layout.Models
{
    public class MyCheckNameBinding : IModelBinder
    {

        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            // Lấy model name - tên thuộc tính binding
            string modelName = bindingContext.ModelName;
            // Lấy giá trị gửi đến. Không thiết lập giá trị cho thuộc tính
            ValueProviderResult valueProviderResult = bindingContext.ValueProvider.GetValue(modelName);
            if(valueProviderResult==ValueProviderResult.None) return Task.CompletedTask;
            // Thiết lập cho ModelState giá trị bindinng
            bindingContext.ModelState.SetModelValue(modelName, valueProviderResult);
            // Đọc giá trị đầu tiên
            string value = valueProviderResult.FirstValue;
            if (string.IsNullOrEmpty(value)) return Task.CompletedTask;
            var s = value.ToUpper();
            if (s.Contains("XXX"))
            {
                bindingContext.ModelState.TryAddModelError(modelName, "Không thể chứa XXX");
                return Task.CompletedTask;
            }
            bindingContext.Result = ModelBindingResult.Success(s.Trim());
            return Task.CompletedTask;
        }
    }
}
