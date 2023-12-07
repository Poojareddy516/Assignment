Information :

Framework - .Net 7.0
Visual Studio 2022

There are three projects
- CustOrderManagement.Api	: Web Api project
- CustOrderManagement.Data	: Entity Framework with InMemory Db
- CustOrderManagement.Tests	: Unit Tests

There is swagger API which can be used for testing web apis

Api 1: Insert customer order details to the ‘Order’ table.
Post - /api/Orders/SaveOrder
Body -
{
  "productId": 1,
  "customerId": 1,
  "orderDate": "2023-12-07T04:39:29.032Z",
  "quantity": 10,
  "pricePaid": 100,
  "shippedDate": "2023-12-07T04:39:29.032Z"
}


Api 2: Get all the pending orders which are not yet shipped to the customers.

Get - /api/Order/GetPendingOrders


Api 3: Get the list of products with AverageCustomerRating in the order of highest to lowest ratings.

Get - /api/Product/GetProductsBaseOnRatings
