//The game is called "Trial of the Four Elements"
// Start of game
Console.WriteLine("Welcome, young witch");
        Console.WriteLine("You seek the knowlege of the four element spells?");
        Console.WriteLine("Then you must type the correct word to unlock that spell");
// Spells
Console.WriteLine("To unlock the first spell, the spell of fire, please type in the correct word to unlock the magic of fire");
        string fireAnswer= Console.ReadLine();
// Fire spell, it checks if the user input is correct
if (fireAnswer == "Flame")
{
    Console.WriteLine("You feel warmth flow into your hands. You learned the Fire spell!");
    Console.WriteLine("Congratulations, now time to learn the next spell, the spell of water");
    Console.WriteLine("To unlock the spell of water, please type in the correct word to unlock the magic of water");
    //Water spell, it makes sure the user input is correct
    string WaterAnswer = Console.ReadLine();
    if (WaterAnswer == "Wave")
    {
        Console.WriteLine("You feel a cool breeze flow into your hands. You learned the Water spell!");
        Console.WriteLine("Congratulations, now time to learn the next spell, the spell of earth");
        Console.WriteLine("To unlock the spell of earth, please type in the correct word to unlock the magic of earth");
        // Earth spell, it again checks if the user input is correct
        string EarthAnswer = Console.ReadLine();
        if (EarthAnswer == "Stone")
        {
            Console.WriteLine("You feel a solid force flow into your hands. You learned the Earth spell!");
            Console.WriteLine("Congratulations, now time to learn the next spell, the spell of air");
            Console.WriteLine("To unlock the spell of air, please type in the correct word to unlock the magic of air");
            // Air spell, it checks to make sure you put the right input in
            string AirAnswer = Console.ReadLine();
            if (AirAnswer == "Breeze")
            {
                Console.WriteLine("You feel a light wind flow into your hands. You learned the Air spell!");
                Console.WriteLine("Congratulations, you have learned all four element spells!");
                // This will unlock the Potions Shop
                Console.WriteLine("Thank you for participating, young witch. May your magical journey continue! If you'd like, I could take you to the Potions Shop?");
                if (Console.ReadLine() == "Yes")
                {
                    Console.WriteLine("Follow me, the Potions Shop is just around the corner!");
                    Console.WriteLine("You have arrived at the Potions Shop, where you can find various magical ingredients and potions to aid you on your journey.");
                    Console.WriteLine("Feel free to browse and purchase anything you need. Safe travels, young witch! The End.");
                }
                //If the user says no to the Potions Shop the game just ends
                else
                    Console.WriteLine("Very well, safe travels on your magical journey! The End.");
            }

            else
                Console.WriteLine("The air around you feels heavy and still. You failed to learn the Air spell.");
        }
        else
            Console.WriteLine("The ground beneath you feels hard and unyielding. You failed to learn the Earth spell.");
    }
    else

        Console.WriteLine("The air around you feels dry and arid. You failed to learn the Water spell.");
}
else

    Console.WriteLine("The air around you feels cold and unwelcoming. You failed to learn the Fire spell.");