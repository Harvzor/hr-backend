# HR Backend

## Startup

- run `dotnet run` or `dotnet watch run` for development

### Setup database

- `dotnet ef migrations add initial` to setup the database entities
- `dotnet ef database update` to actually insert the entities into the db (makesure `appsettings.json` has the right database connection string)
- run the web app and hit the end point `/api/events/setup` to insert a bunch of event data into the database
