Trestlebridge Farms README
​
Trestlebridge farms is an application designed to track and organize various farm resources.
Users will be able to track and organize facilities, animals, produce, stock, and processing.
For each resource, you will find where it will be stored on the farm, what is produces when processed, and how much it produces to make management of your farm as efficient as possible.
Trestlebridge Farms application was built using C# .Net Framework.
​
To install:
1. Install .NET Core
1.	Visit the .NET Tutorial site, click on your OS and follow the steps to install .NET Core.
2.	In your terminal go to your workspace directory and do steps 2 and 3 in the tutorial to verify everything works.
2. Install SQL Server Express
3. Install Visual Studio Community Edition
Visual Studio Workloads
When installing Visual Studio, you will be presented with a variety of Workloads. Select these workloads.
1.	ASP.NET and web development
2.	.NET Core cross-platform development
3.	Install the Visual Studio Code C# Extension
4. Once the installations are complete clone down the code from github.  Open visual studio code and  open terminal run the application by typing DOTNET RUN.
​
Using Trestlebridge Farms Application
When the user first executes FARMS, they will be welcomed to the system and be presented with the following menu.
 +-++-++-++-++-++-++-++-++-++-++-++-++-+
 |T||r||e||s||t||l||e||b||r||i||d||g||e|
 +-++-++-++-++-++-++-++-++-++-++-++-++-+
           |F||a||r||m||s|
           +-++-++-++-++-+
​
1. Create Facility
2. Purchase Animals
3. Purchase Seeds
4. Processing Options (this is a stretch goal)
​
Choose a FARMS option.
​
Facility Creation Options Sub-Menu
If the user chooses option 1, then the following menu should be displayed
1. Grazing field
2. Plowed field
3. Natural field
4. Chicken house
5. Duck house
​
Choose what you want to create.
> _
When the user makes a choice, a new instance of that type of facility should be added to a List<> on your farm.
Animal Purchase Menu
If the user chooses 2 from the main menu, then she should see the following menu, with the animals listed in alphabetical order.
1. Chicken
2. Cow
3. Duck
4. Goat
5. Ostrich
6. Pig
7. Sheep
​
Choose animals to purchase.
> _
When the user enters in what to buy, then display all of the locations in which the animals can be stored. The current number of animals should be displayed for each location.
1. Grazing Field (16 animals)
2. Grazing Field (4 animals)
​
Where would you like to place the animals?
> _
If the user chose to place them in a location that would be over capacity if they were placed there, there will be a display message and show the menu again.
**** That facility is not large enough ****
****     Please choose another one      ****
​
1. Grazing Field (16 animals)
2. Grazing Field (4 animals)
​
Where would you like to place the animals?
> _
Seed Purchase Menu
If the user chooses 3 from the main menu, then the user should see the following menu, with the plants listed in alphabetical order.
1. Sesame
2. Sunflower
3. Wildflower
​
Choose seed to purchase.
> _
When the user makes a choice, then display all of the locations in which the plants can be planted. The current number of plant rows should be displayed for each location.
1. Plowed Field (8 rows of plants)
2. Plowed Field (5 rows of plants)
3. Natural Field (0 rows of plants)
​
Where would you like to plant the Sunflowers?
> _
​
If the user chose to place them in a location that would be over capacity if they were placed there, display a message and show the menu again.
**** That facility is not large enough ****
****     Please choose another one      ****
​
1. Plowed Field (8 rows of plants)
2. Plowed Field (5 rows of plants)
3. Natural Field (0 rows of plants)
​
 +-++-++-++-++-++-++-++-++-++-++-++-++-+
 |T||r||e||s||t||l||e||b||r||i||d||g||e|
 +-++-++-++-++-++-++-++-++-++-++-++-++-+
           |F||a||r||m||s|
           +-++-++-++-++-+
​
With the Treslebridge farms application all your farming dreams will come true.
It certainly is a good day for farming!
~~~~<~~@
​
Collapse



