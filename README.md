# Grand Circus Lab Coffee Shop Registration
## Part 1
### Task
Create a User Registration Form using the MVC framework.

### What does the application do?
1. The Index View should have an action link pointing to the registration page.
1. The registration page will register a new user. The form should take in the user’s first and last name, email, and password.
1. When submitted, the page should redirect the user to a summary on a different page. This page will show a message => Welcome {UserName}
1. Go crazy! Design the form by adding different kinds of controls, such as text boxes, drop down lists, radio buttons, and check boxes.

### Build Specifications
* Index page has a working action link to the registration page (1 point).
* Registration page has a form with a valid action and method (1 point) and the four required fields (1 point each = 4 points).
* Result controller takes all four fields correctly through GET or POST (2 points), then returns a view (1 point), passing the correct information along (1 point).
* Result page shows at least the user’s first name with a welcome message (1 point).

### Extended Challenges
* Do form validation! Use HTML5, Controller C# code using regular expressions, or any other methods you can come up with to do validation. Make up your own rules for a valid password.

---
## Part 2
### Task
Expand and improve The Coffee Shop App

### What does the application do?
* Offers more fields on the registration form from last lab.
* Provides additional validation.
* Displays all information from a user model

### Build Specifications
1. Add at least three additional fields of whatever types you want.
    * Experiment with the HTML <fieldset> tag for keeping related form elements together.
    * Experiment with dropdowns, radio buttons, check boxes, etc.
1. Add server-side validation for at least two of those fields. (Others can be optional.) Think about:
    * Add a password confirmation text box.
    * Testing if an email field has a valid email address.
    * Checking if a phone number is properly formatted.
1. Create a new view to display all the properties of a User model. Experiment with the different ways to do this:
    * In the controller action, put each user property into a different ViewBag property, then in the view, print each ViewBag property into the page.
    * Do the same thing as above but use ViewData/
    * Create a User class in the Model, then in the controller action, create a new User object and pass it to the view. At the top of the view use an @model statement to import your model. What code do you need to print the properties?
    * Right click on the views folder and select add -> View. Experiment with the different templates .NET allows you to use.

### Grading Standards
• Registration form has at least 3 additional fields (1 point each).
• Controller action includes validation for at least 2 fields (2 points each = 4 points).
• Controller passes all user data back to the view (3 points).
• View formats and displays all user data (2 points).
