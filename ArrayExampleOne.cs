//Creates a new list and adds elements
           List<string> names = new List<string>();

           names.Add("Hemory");
           names.Add("Scott");
           names.Add("Nick");

            //The List Initializer 
           List<string> names2 = new List<string> {"David", "Brian", "Prime"};
_________________________________________________________________________________________________
//Create a list of integers
         List<int> numbers = new List<int> {1, 2, 3, 4};

         //Create a list of doubles
         List<double> dunNum = new List<double> {1.5, 2.5, 3.5 };

         //Create a list of characters
         List<char> letter = new List<char> {'h', 'e', 'm', 'o', 'r', 'y'};

         //Create a list of bools
         List<bool> isCorrect = new List<bool> {true, false, true, false};
_________________________________________________________________________________________________
//iterating with a for loop
         for (int i = 0; i < names.Count; i++)
         {
             Console.WriteLine(names[i]);
         }

         //iterating with a foreach
         foreach (string name in names)
         {
             Console.WriteLine(name);
         }
		 
		 //iterate through a list of ints
		 //iterate through a list of doubles
		 //iterate through a list of characters
		 //iterate through a list of bools
____________________________________________________________________________________________
//iterate through list and format each name in a foreach
            foreach (string name in names)
            {
                Console.WriteLine($"{name} is coming to the party!");
            }

            //iterate through list and format each name in a foreach
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"{names[i]} is coming to the partay!");
            }


            Console.WriteLine("Press enter to exit the program");
            Console.ReadLine();
____________________________________________________________________________________________
//Create a new list for party guests
            List<string> partyGuest = new List<string>();

            bool keepGoing = true;

            while (keepGoing)
            {
                //Ask user to enter a name
                Console.WriteLine("If you are coming to the party, what is your name? ");

                string guestName = Console.ReadLine();

                //Add the name to the partyGuest list

                partyGuest.Add(guestName);

                Console.WriteLine("Would you like to continue? y or n?");

                string answer = Console.ReadLine();

                if (answer.ToLower() != "y")
                {
                    keepGoing = false;
                }

                Console.WriteLine("Here is the guest list as of current");

                foreach (string guest in partyGuest)
                {
                    Console.WriteLine(guest);
                }
____________________________________________________________________________________________














//Checking values and keeping count
 List<int> ages = new List<int> {18, 23, 9, 33, 54, 21};


            int countOfGreaters = 0;
            int countOfLessers = 0;

            Console.WriteLine($"You have {ages.Count} in the list");


            foreach (int age in ages)
            {
                
                

                if (age >= 18)
                {
                    Console.WriteLine($"The value {age} is greater than 18. ");
                    countOfGreaters++;
                }
                else
                {
                    Console.WriteLine($"The value {age} is not greater than 18. ");
                    countOfLessers++;
                }

            }

            Console.WriteLine($"The final tally is Greaters: {countOfGreaters} and Lessers: {countOfLessers}");





            Console.WriteLine("Press enter to exit the program");
            Console.ReadLine();










_________________________________________________________________________________________________
/* Write a program that is has a list of zip codes. This list of zipcode determine whether you deliver here or not.
            If it matches then you will deliver. If it does not match, ask if they would like the zipcode added and then add it to the list of zip codes*/
        List<string> zipCodes = new List<string>();

        zipCodes.Add("48051");
        zipCodes.Add("48043");
        zipCodes.Add("48471");
        zipCodes.Add("48899");
        zipCodes.Add("48473");
        zipCodes.Add("48491");
        zipCodes.Add("48536");
        zipCodes.Add("48972");
        zipCodes.Add("48772");
        zipCodes.Add("48402");
        zipCodes.Add("48431");
    

           Console.WriteLine("Let's check to see if we deliver in your area.");
           Console.WriteLine("Please enter your 5 digit zip code");

           string input = Console.ReadLine();

           if (zipCodes.Contains(input))
           {
               Console.WriteLine("Congrats, we do deliver in your area.");
           }
           else
           {
               Console.WriteLine("I am sorry, we do not currently deliver in your area.");
               zipCodes.Add(input);

               Console.WriteLine("Our delivery options has been updated");

               Console.WriteLine("Here is our new list");

               foreach (string zipCode in zipCodes)
               {
                   Console.WriteLine(zipCode);
               }
            }

          

Console.WriteLine("Press enter to exit the program");
            Console.ReadLine();
_________________________________________________________________________________________________
		 /* FOR LOOP EXAMPLE: Write a program that is has a list of zip codes. This list of zipcode determine whether you deliver here or not.
             If it matches then you will deliver. If it does not match, ask if they would like the zipcode added and then add it to the list of zip codes*/
            List<string> zipCodes = new List<string>();

            zipCodes.Add("48051");
            zipCodes.Add("48043");
            zipCodes.Add("48471");
            zipCodes.Add("48899");
            zipCodes.Add("48473");
            zipCodes.Add("48491");
            zipCodes.Add("48536");
            zipCodes.Add("48972");
            zipCodes.Add("48772");
            zipCodes.Add("48402");
            zipCodes.Add("48431");


            Console.WriteLine("Let's check to see if we deliver in your area.");
            Console.WriteLine("Please enter your 5 digit zip code");

            string input = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < zipCodes.Count; i++)
            {
                if (input == zipCodes[i])
                {
                    found = true;
                    break;
                }
            }

            if (found == true)
            {
                Console.WriteLine("Congrats, we do deliver in your area.");
            }
            else
            {
                Console.WriteLine("I am sorry, we do not currently deliver in your area.");
                zipCodes.Add(input);

                Console.WriteLine("Our delivery options has been updated");

                Console.WriteLine("Here is our new list");

                foreach (string zipCode in zipCodes)
                {
                    Console.WriteLine(zipCode);
                }
            }



            Console.WriteLine("Press enter to exit the program");
            Console.ReadLine();	
