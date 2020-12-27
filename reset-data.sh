rm app.db
rm hangfire.db
rm Migrations/*
dotnet build
dotnet ef migrations add Initial
dotnet ef database update
dotnet run