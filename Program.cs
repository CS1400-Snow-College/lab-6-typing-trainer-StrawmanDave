// David Barlow Typing Trainer 10/22/24

// Clear the screen so it looks nice
Console.Clear();

// Brief instructions
Console.Write("This is a typing challenge you can not use backspace and mistakes will be shown with red.");

// puts a space in between the explanation and the typing phrase
Console.WriteLine();

string phrase1 = "The quick brown fox jumps over the lazy dog.";
string phrase2 = "Bob the builder can he build it yes he can.";
string phrase3 = "Some say the point to life is happiness what do you think the point of life is?";
string phrase4 = "Music is a wonderful thing it can sooth the mind, hype someone up, or even tell a story!";
string phrase5 = "Literature; you either love it or hate it, but communication is one thing that makes humans advanced.";

//random number for a random line
Random rand = new Random();
int randomNum = rand.Next(0,5);

//array that stores the phrases
string[] typingPhrases = new string [5] {phrase1, phrase2, phrase3, phrase4, phrase5};
string chosenPhrase = typingPhrases[randomNum];

//writes the chosen phrase and the number corresponding with it.
Console.Write($"{chosenPhrase} {randomNum}");
Console.WriteLine();