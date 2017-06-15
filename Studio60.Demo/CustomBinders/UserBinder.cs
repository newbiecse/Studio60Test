using Studio60.Demo.ViewModels;
using System;
using System.ComponentModel;
using System.Web.Mvc;

namespace Studio60.Demo.CustomBinders
{
    public class UserBinder : DefaultModelBinder
    {
        protected override object GetPropertyValue(ControllerContext controllerContext, ModelBindingContext bindingContext, 
            PropertyDescriptor propertyDescriptor, IModelBinder propertyBinder)
        {
            if (propertyDescriptor.ComponentType == typeof(UserViewModel))
            {
                if (propertyDescriptor.Name == "DateOfBirth")
                {
                    int day = 0;
                    Int32.TryParse(bindingContext.ValueProvider.GetValue("DOBDay").AttemptedValue, out day);

                    int month = 0;
                    Int32.TryParse(bindingContext.ValueProvider.GetValue("DOBMonth").AttemptedValue, out month);

                    int year = 0;
                    Int32.TryParse(bindingContext.ValueProvider.GetValue("DOBYear").AttemptedValue, out year);

                    DateTime dob = DateTime.MinValue;
                    DateTime.TryParse(string.Format("{0}/{1}/{2}", month, day, year), out dob);

                    return dob;
                }
            }

            return base.GetPropertyValue(controllerContext, bindingContext, propertyDescriptor, propertyBinder);
        }
    }
}