Take your orders MVC app and create a new model that contains a property that holds a list of your order class. Your code will look something like this:

public List<Order> Orders {get; set;}

Create a new controller and view combo called “Orders” and tie the view to this new model.

In your controller, create a bunch of dummy orders and add them to the list of orders, and then use the view to display the data. 

Try using different forms of razor syntax: @{ code }, @foreach, etc.
