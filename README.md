# Async_Inn
Creating MVC application for Hotel Management system.

# Problem Domain
Using your database schema, convert each entity into a model within your newly created MVC web application.

# Azure Deployment
https://asyncinnal.azurewebsites.net/

# Directions
Clone repository to local machine. Open using Visual Studio and run IIS Express

# Visual
![home-page-visual](https://user-images.githubusercontent.com/17580143/47960214-88618580-dfb4-11e8-8853-958bc3f3dcba.png)

# Database Schema
## Tables:
Hotel: The hotel table has the following properties: name, address, and phone number. The promary key for this table is HotelID because it will relate to the next table HotelRoom. The relationship is one-to-many - one hotel has many rooms.

HotelRoom: The hotel room table has the properties rate and pet friendly. The composite keys for this table are HotelID and RoomNumber, this allows us to uniquely identify hotel rooms with the combiantion of those two keys. The foreign key for this table is the RoomID, which relates to the next table.

Room: This table has a name property, layout enum, and primary key of RoomID. The relationship to HotelRoom is one-to-many: one room type can belong to many hotel rooms.

RoomAmenities: This table is a join table made up of composit keys to join the Amenities table and the Room table. The relationship to Room is many-to-one: many amenities belong to one room.

Amenities: This table has a name property and a primary key of ID. The relationship to RoomAmentities is one-to-many: one amenitity can belong to many room amenities.

The navigational properties are present in the tables so that you can query multiple tables in one qyuery. It makes is easier to access and package the data you are accessing. They are also a workaround for the lack of many-to-many relational tables in the entity framework.

# Database Visual
![schemaasyncinn](https://user-images.githubusercontent.com/17580143/47537294-c9052480-d879-11e8-972b-fc31edd0554a.png)

