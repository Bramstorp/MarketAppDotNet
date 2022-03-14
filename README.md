# MarketAppDotNet
vil ik mere.

# Setup
docker pull mcr.microsoft.com/mssql/server

docker run -e "ACCEPT_EULA=Y" -e "<StrongPasswordYouSet>" -p 1433:1433 -d mcr.microsoft.com/mssql/server

- Hostname: localhost
- Database to connect: blank
- Authentication Type: SQL Login
- Username: sa
- Password: <StrongPasswordYouSet>

dotnet add package Microsoft.EntityFrameworkCore.SqlServer

dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet tool install --global dotnet-ef

dotnet ef migrations add InitialCreate

dotnet ef database update
