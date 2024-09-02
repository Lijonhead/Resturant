Restaurant Booking System API Documentation
Jag gör androppen i swagger och på engelska så det blir lättare at förstå.


Get All Bookings
URL: /api/Booking/GetAllBookings
Method: GET
Description: Retrieves a list of all bookings.
Response:
200 OK
[
  {
    "bookingId": 1,
    "FK_CustomerId": 123,
    "FK_TableId": 2,
    "BookingDate": "2024-09-03T18:00:00",
    "CustomerAmount": 4
  },
  ...
]

Get Booking By ID
URL: /api/Booking/GetBookingById?id={id}
Method: GET
Description: Retrieves a booking by its ID.
Response:
200 OK
{
  "bookingId": 1,
  "FK_CustomerId": 123,
  "FK_TableId": 2,
  "BookingDate": "2024-09-03T18:00:00",
  "CustomerAmount": 4
}
404 Not Found if the booking does not exist.

Add Booking
URL: /api/Booking/AddBooking
Method: POST
Description: Adds a new booking.
Request Body:
{
  "FK_CustomerId": 123,
  "FK_TableId": 2,
  "BookingDate": "2024-09-03T18:00:00",
  "CustomerAmount": 4
}
Response:
201 Created
{
  "bookingId": 1,
  "FK_CustomerId": 123,
  "FK_TableId": 2,
  "BookingDate": "2024-09-03T18:00:00",
  "CustomerAmount": 4
}

Update Booking
URL: /api/Booking/UpdateBooking?id={id}
Method: PUT
Description: Updates an existing booking.
Request Body:
{
  "FK_CustomerId": 124,
  "FK_TableId": 3,
  "BookingDate": "2024-09-04T19:00:00",
  "CustomerAmount": 5
}
Response:
204 No Content if successful.
404 Not Found if the booking does not exist.

Delete Booking
URL: /api/Booking/DeleteBooking?id={id}
Method: DELETE
Description: Deletes a booking by ID.
Response:
204 No Content if successful.
404 Not Found if the booking does not exist.

Check Table Availability
URL: /api/Booking/available/{tableId}/{date}
Method: GET
Description: Checks if a table is available on a specific date.
Response:
200 OK
{
  "TableId": 2,
  "Date": "2024-09-03T00:00:00",
  "IsAvailable": true
}
200 OK with IsAvailable: false if the table is booked.

Get All Tables
URL: /api/Table/GetAllTables
Method: GET
Description: Retrieves a list of all tables.
Response:
200 OK
[
  {
    "tableId": 1,
    "tableNumber": 1,
    "capacity": 4
  },
  ...
]

Get Table By ID
URL: /api/Table/GetTableById?id={id}
Method: GET
Description: Retrieves a table by its ID.
Response:
200 OK
{
  "tableId": 1,
  "tableNumber": 1,
  "capacity": 4
}
404 Not Found if the table does not exist.

Add Table
URL: /api/Table/AddTable
Method: POST
Description: Adds a new table.
Request Body:
{
  "tableNumber": 1,
  "capacity": 4
}
Response:
201 Created
{
  "tableId": 1,
  "tableNumber": 1,
  "capacity": 4
}


Update Table
URL: /api/Table/UpdateTable?id={id}
Method: PUT
Description: Updates an existing table.
Request Body:
{
  "tableNumber": 2,
  "capacity": 6
}
Response:
204 No Content if successful.
404 Not Found if the table does not exist.

Delete Table
URL: /api/Table/DeleteTable?id={id}
Method: DELETE
Description: Deletes a table by ID.
Response:
204 No Content if successful.
404 Not Found if the table does not exist.

Get All Menus
URL: /api/Menu/GetAllMenus
Method: GET
Description: Retrieves a list of all menus.
Response:
200 OK
[
  {
    "menuId": 1,
    "menuName": "Dinner Menu"
  },
  ...
]

Get Menu By ID
URL: /api/Menu/GetMenuById?id={id}
Method: GET
Description: Retrieves a menu by its ID.
Response:
200 OK
{
  "menuId": 1,
  "menuName": "Dinner Menu"
}
404 Not Found if the menu does not exist.

Add Menu
URL: /api/Menu/AddMenu
Method: POST
Description: Adds a new menu.
Request Body:
{
  "menuName": "Dinner Menu"
}
Response:
201 Created
{
  "menuId": 1,
  "menuName": "Dinner Menu"
}

Update Menu
URL: /api/Menu/UpdateMenu?id={id}
Method: PUT
Description: Updates an existing menu.
Request Body:
{
  "menuName": "Lunch Menu"
}
Response:
204 No Content if successful.
404 Not Found if the menu does not exist.


Delete Menu
URL: /api/Menu/DeleteMenu?id={id}
Method: DELETE
Description: Deletes a menu by ID.
Response:
204 No Content if successful.
404 Not Found if the menu does not exist.

Get All Customers
URL: /api/Customer/GetAllCustomers
Method: GET
Description: Retrieves a list of all customers.
Response:
200 OK
[
  {
    "customerId": 1,
    "name": "John Doe",
    "email": "john@example.com",
    "phone": "123-456-7890"
  },
  ...
]

Get Customer By ID
URL: /api/Customer/GetCustomerById?id={id}
Method: GET
Description: Retrieves a customer by their ID.
Response:
200 OK
{
  "customerId": 1,
  "name": "John Doe",
  "email": "john@example.com",
  "phone": "123-456-7890"
}
404 Not Found if the customer does not exist.

Add Customer
URL: /api/Customer/AddCustomer
Method: POST
Description: Adds a new customer.
Request Body:
{
  "name": "Jane Smith",
  "email": "jane@example.com",
  "phone": "098-765-4321"
}
Response:
201 Created
{
  "customerId": 2,
  "name": "Jane Smith",
  "email": "jane@example.com",
  "phone": "098-765-4321"
}


Update Customer
URL: /api/Customer/UpdateCustomer?id={id}
Method: PUT
Description: Updates an existing customer.
Request Body:
{
  "name": "Jane Doe",
  "email": "janedoe@example.com",
  "phone": "111-222-3333"
}
Response:
204 No Content if successful.
404 Not Found if the customer does not exist.


5. Delete Customer
URL: /api/Customer/DeleteCustomer?id={id}
Method: DELETE
Description: Deletes a customer by ID.
Response:
204 No Content if successful.
404 Not Found if the customer does not exist.