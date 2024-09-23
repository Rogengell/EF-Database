# Entity Framework Core Migrations

## [Setup EF Core](https://github.com/Rogengell/EF-Database/tree/initial-setup)

## [Migrate to Categories](https://github.com/Rogengell/EF-Database/tree/add-categories)

## [Migrate to Product Ratings](https://github.com/Rogengell/EF-Database/tree/add-ratings)

## Merge and Conflict Resolution
All branches where merged, and the conflicts was resolved

## Rollback Plan
1. update to newest version
Type: dotnet ef database update
2. update to specific migration
Type: dotnet ef database update "Migration Name"

Updating and rollback is the same, when you "Update" to an older migration, it will roll back the datebase for you.
The sequence of migrations are:
1. InitialCreate
2. CategorisAndKey
3. ProducktRating
But be carefull, roollback will delete date in the fields that was not there, in the version you rollback to.