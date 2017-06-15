# Tools:
  + Visual studio 2013 update 5
  + MVC 5
  + .Net framework 4.5
  
# Requirement is confused:
  + [Advanced Requirements]: Model will have only 4 properties: FirstName, LastName, Email, DateOfBirth (datetime) AND Date Of Birth field must be either 3 text-boxes or 3 drop-down lists for Year,Month, Day. 
  + -> You want the model have 4 properties but what are properties present for 3 text-boxes/3 drop-down lists @@?
  + -> I assume you can do it. OK, what will happen if end-user disabled javascript and entered values for 3 text-boxes as following data: DD/MM/YYYY is 31/02/2017 - in this case we cannot parse to datetime with this value, so that the validation on server side is failed and you cannot auto fill value of day, month and year for 3 text-boxed above @@
  + -> Maybe I'm wrong =)) please correct me - tell me your solution =))
    
# Passed requirement(I hope so =)))
  + Validation with Data Annotation: [UserViewModel.cs](https://github.com/newbiecse/Studio60Test/blob/master/Studio60.Demo/ViewModels/UserViewModel.cs)
  + Custom Model Binding: [UserBinder.cs](https://github.com/newbiecse/Studio60Test/blob/master/Studio60.Demo/CustomBinders/UserBinder.cs)
  + Custom Validation on client side: [validators.customize.js](https://github.com/newbiecse/Studio60Test/blob/master/Studio60.Demo/Scripts/validators.customize.js)
  + Custom Validation on server side: [DOBAttribute.cs](https://github.com/newbiecse/Studio60Test/blob/master/Studio60.Demo/ViewModels/Validators/DOBAttribute.cs) and [DOBFieldAttribute.cs](https://github.com/newbiecse/Studio60Test/blob/master/Studio60.Demo/ViewModels/Validators/DOBFieldAttribute.cs)
  + Form submission: [UserController.cs](https://github.com/newbiecse/Studio60Test/blob/master/Studio60.Demo/Controllers/UserController.cs)
  + Regex: [UserViewModel.cs](https://github.com/newbiecse/Studio60Test/blob/master/Studio60.Demo/ViewModels/UserViewModel.cs) - for simple I don't want to use regex for email =))
  
# Expectation:
  + If I'm fail - please tell me what's my wrong =)). Have a nice day =))!
