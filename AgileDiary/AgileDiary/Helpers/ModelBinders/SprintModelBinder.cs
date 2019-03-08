using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Threading.Tasks;
using AgileDiary.Models.ViewModels;

namespace AgileDiary.Helpers.ModelBinders
{
    public class SprintModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
            {
                throw new ArgumentNullException(nameof(bindingContext));
            }
            var startDateValues = bindingContext.ValueProvider.GetValue("Sprint.StartDate");
            var rewardValues = bindingContext.ValueProvider.GetValue("Sprint.Reward");
            var idValues = bindingContext.ValueProvider.GetValue("Sprint.Id");

            string startDateString = startDateValues.FirstValue;
            DateTime parsedStartDate;
            DateTime.TryParse(startDateString, out parsedStartDate);
            string reward = rewardValues.FirstValue;
            Guid id;
            if (string.IsNullOrEmpty(idValues.FirstValue))
            {
                id =  Guid.NewGuid();
            }
            else{
                Guid.TryParse(idValues.FirstValue, out id);
            }

            bindingContext.Result = ModelBindingResult.Success(new SprintViewModel { Id = id, StartDate = parsedStartDate, Reward = reward });
            return Task.CompletedTask;
        }
    }
}
