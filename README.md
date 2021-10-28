# OnlineStore

1. Ensure your connection strings in appsettings.json point to a local SQL Server instance.

2. Ensure the tool EF was already installed.

    ```
    dotnet tool install --global dotnet-ef
    ```

3. Open a command prompt in the AdminBlazorServer folder and execute the following commands:

    ```
    dotnet restore
    ```
    ```
    dotnet tool restore
    ```
    For Catalog Database
    ```
    dotnet ef database update -c catalogdbcontext -p ../OnlineStore.Infrastructure/OnlineStore.Infrastructure.csproj -s OnlineStore.AdminBlazorServer.csproj
    ```
    For Identity Database
    ```
    dotnet ef database update -c appidentitydbcontext -p ../OnlineStore.Infrastructure/OnlineStore.Infrastructure.csproj -s OnlineStore.AdminBlazorServer.csproj
    ```


4. create migration (from Web folder CLI)
    For Catalog Database
    ```
    dotnet ef migrations add InitialModel --context catalogdbcontext -p ../OnlineStore.Infrastructure/OnlineStore.Infrastructure.csproj -s OnlineStore.AdminBlazorServer.csproj -o Data/Migrations
    ```

    For Identity Database
    ```
    dotnet ef migrations add InitialIdentityModel --context appidentitydbcontext -p ../OnlineStore.Infrastructure/OnlineStore.Infrastructure.csproj -s OnlineStore.AdminBlazorServer.csproj -o Identity/Migrations
    ```

3. Update Database after Creating Migration

    For Catalog Database
    ```
    dotnet ef database update -c catalogdbcontext -p ../OnlineStore.Infrastructure/OnlineStore.Infrastructure.csproj -s OnlineStore.AdminBlazorServer.csproj
    ```
    For Identity Database
    ```
    dotnet ef database update -c appidentitydbcontext -p ../OnlineStore.Infrastructure/OnlineStore.Infrastructure.csproj -s OnlineStore.AdminBlazorServer.csproj
    ```

