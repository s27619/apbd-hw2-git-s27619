**To run the project**
*1. Make sure you have .NET installed (version 6 or newer).*
**Check it with:**
dotnet --version

*2. Open terminal in the project folder:*
cd apbd-hw2-git-s27619

*3. Build the project:*
dotnet build

*4. Run the app:*
dotnet run

**After run, you’ll see a simple menu in the console.**

How it works on paper. I tried to keep the project simple but still good for course purpose. The Program class is responsible only for the menu and user interaction.All the main logic (like renting equipment or checking overdue rentals) is handled in RentalService. Data is stored in DataStore using lists — no database, just in-memory storage for simplicity. 

Users:
There are two types of users: Student, Employee.
They both inherit from a User class, but each has a different limit for how many items they can rent.

Equipment:
There are three types of equipment: Laptop, Projector, Camera
Both inherit from a base Equipment class and each has different fields. 

I used TryParse for user input so the app doesn’t crash if someone types something wrong.
Basic checks are also done in the service (e.g. max rentals limit).

Each rental has a due date. If the current date is past that date, it shows up in the “Overdue Rentals” list.