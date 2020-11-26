rm app.db
rm Migrations/*
dotnet ef migrations add Initial
dotnet ef database update
dotnet run