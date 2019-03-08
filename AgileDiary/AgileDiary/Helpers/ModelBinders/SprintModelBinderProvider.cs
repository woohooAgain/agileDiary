using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using AgileDiary.Models.ViewModels;

namespace AgileDiary.Helpers.ModelBinders
{
    public class SprintModelBinderProvider : IModelBinderProvider
    {
        private readonly IModelBinder binder = new SprintModelBinder();

        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            return context.Metadata.ModelType == typeof(SprintViewModel) ? binder : null;
        }
    }
}
