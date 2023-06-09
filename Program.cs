using System.ComponentModel;
using System;

string[] colours = {
    "Red",
    "Green",
    "Yellow",
    "Blue"
};

Random rnd = new Random();

int treeHeight = rnd.Next(5, 100);
int treeHeightCounter = 0;

for (int i = 0; i < treeHeight + 2; i++)
{
    int colourIndex = rnd.Next(0, colours.Length);

    if (Enum.TryParse(colours[colourIndex], out ConsoleColor selectedColour))
    {
        Console.ForegroundColor = selectedColour;

        if (treeHeightCounter == treeHeight)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.ForegroundColor = selectedColour;
                Console.Write(new string(' ', treeHeight - 2));
                Console.Write("***\n");
            }
            Console.ResetColor();
            break;
        }
        
        Console.Write(new string(' ', treeHeight - i - 1));

        Console.WriteLine(new string('*', i * 2 + 1));
    }
    else
    {
        Console.WriteLine("Failed to set color.");
    }

    Console.ResetColor();
    treeHeightCounter++;
}

