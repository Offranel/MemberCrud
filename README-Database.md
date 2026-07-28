How to recreate ChurchDB locally

Option 1: Run the SQL script (no EF tools required)

1. Ensure (localdb)\MSSQLLocalDB is available (Visual Studio installs LocalDB).
2. From PowerShell or command prompt run:

   sqlcmd -S "(localdb)\MSSQLLocalDB" -i Database/InitialCreate.sql

Option 2: Use EF Core migrations (requires dotnet-ef)

1. Install the EF CLI if you don't have it:

   dotnet tool install --global dotnet-ef --version 8.0.0

2. From the repo root, run (if you prefer applying the migration directly):

   dotnet ef database update --project MemberCrud/MemberCrud.csproj --startup-project MemberCrud/MemberCrud.csproj

Notes
- The repository includes an initial migration under Migrations/. The SQL script in Database/InitialCreate.sql mirrors that migration.
- Commit the database schema files (migrations + SQL) to source control so teammates can recreate the database locally.
