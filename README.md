# Entity Framework Core Migrations

## [Setup EF Core](https://github.com/Rogengell/EF-Database/tree/initial-setup)
1. CREATE NEW PROJECT
2. Create a console app
3. Install nuget packages entityframewarkCore , design, sqlServer, tool
4. Create an appsetting file (where the connection is stored)
5. Data folder
    - ECDbcontext.cs file
        - Handles connection
        - Handles tables setup
    - ECDbContextFactory.cs file
        - Sets up where and how to connect
6. In the main / Program.cs file
    - It loads the json file appsettings
    - Setup the whole db and connection 
    - Checker if instance exists if exists it start with the migration 
7. Model folder
    - Products.cs
        - Is a model class
        - Her we configure the table layout
        - Declare the context of the columns
8. After all is setup properly we can run the command dotnet ef migrations add < InitialCreate > 
9. The last step is to run the dotnet ef database update this will update to the newest migration version and the previously not executed migrations

## [Migrate to Categories](https://github.com/Rogengell/EF-Database/tree/add-categories)
1. Model folder
    - Products.cs
        - Add Categories connection
    - Categories.cs
        - Is a model class
        - Her we configure the table layout
        - Declare the context of the columns
        - add product connection
2. After all is setup properly we can run the command dotnet ef migrations add < CategorisAndKey > 
3. The last step is to run the dotnet ef database update this will update to the newest migration version and the previously not executed migrations

## [Migrate to Product Ratings](https://github.com/Rogengell/EF-Database/tree/add-ratings)
1. Model folder
    - Products.cs
        - add ProductRatings connection
    - ProducktRatings.cs
        - Is a model class
        - Her we configure the table layout
        - Declare the context of the columns
        - add product connection
2. After all is setup properly we can run the command dotnet ef migrations add < ProducktRating > 
3. The last step is to run the dotnet ef database update this will update to the newest migration version and the previously not executed migrations

## Merge and Conflict Resolution
All branches where merged, and the conflicts was resolved.
The biggest challenge was the ECDbContextModelSnapshot to merge with out it faling
![Imange Merge](https://github.com/Rogengell/EF-Database/blob/main/Images/Merge%20History.png)
![Imange DateBase](https://github.com/Rogengell/EF-Database/blob/main/Images/Database%20Layout.png)

## Rollback Plan
1. update to newest version
Type: dotnet ef database update
2. update to specific migration
Type: dotnet ef database update < Migration Name >

Updating and rollback is the same, when you "Update" to an older migration, it will roll back the datebase for you.
The sequence of migrations are:
1. InitialCreate
2. CategorisAndKey
3. ProducktRating
But be carefull, roollback will delete date in the fields that was not there, in the version you rollback to.