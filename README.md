# DeLeon_SQLSelectInsertUpdate

C# Windows Forms project for IT1811 Laboratory Exercise 7: SQL Select, Insert, and Update.

## Run
1. Extract the ZIP and open DeLeon_SQLSelectInsertUpdate.sln in Visual Studio.
2. Install the .NET desktop development workload and .NET Framework 4.8 targeting pack if missing.
3. This copy uses SQL Server Express: `.\SQLEXPRESS`, Windows Authentication, database `ClubDB`.
4. Press F5. Existing ClubDB data is reused. If the database or table is missing, the app attempts to create it; your Windows account needs the corresponding SQL permissions. ClubDB.sql can also be executed in SSMS.
5. Register a student; Refresh reloads members. Update opens the second form: select a Student ID, edit details, and Confirm.

## Designer
Right-click FrmClubRegistration.cs or FrmUpdateMember.cs > View Designer (Shift+F7).
Both forms have .Designer.cs and .resx files. Controls are created in InitializeComponent and can be edited visually.

## Connection
Edit builder.DataSource inside DatabaseSetup.cs if your SQL Server instance has a different name. No LocalDB installation is needed for the configured SQLEXPRESS connection. The database name stays ClubDB, so running this and the original against the same server shares members.

## Included
- Both forms, registration and update event handlers, DataGridView, and input validation.
- ClubRegistrationQuery using System.Data.SqlClient and parameterized SELECT, INSERT, UPDATE.
- SQL table matching the handout and corrected BIGINT StudentID parameter.
- Registration IDs continue from the highest existing ID; designed for single-user laboratory use.

## Verification
Project XML, file references, resources, and event wiring checked. Windows compilation, Designer rendering, and SQL execution have not been tested in this Linux environment.
On Windows, register a member, reject a duplicate Student ID, update age, refresh, and restart to confirm persistence. Test blank names, invalid IDs, and invalid ages. Open both forms in Designer.
