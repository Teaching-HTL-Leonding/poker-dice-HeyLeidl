
int dice1 = 0;
int dice2 = 0;
int dice3 = 0;
int dice4 = 0;
int dice5 = 0;
bool fixed1 = false;
bool fixed2 = false;
bool fixed3 = false;
bool fixed4 = false;
bool fixed5 = false;
string answer = "0";
int diceroll = 1;

void RollDice()
{
    if (fixed1 == false)
    {
        dice1 = Random.Shared.Next(1, 7);
    }
    if (fixed2 == false)
    {
        dice2 = Random.Shared.Next(1, 7);
    }
    if (fixed3 == false)
    {
        dice3 = Random.Shared.Next(1, 7);
    }
    if (fixed4 == false)
    {
        dice4 = Random.Shared.Next(1, 7);
    }
    if (fixed5 == false)
    {
        dice5 = Random.Shared.Next(1, 7);
    }
}
void PrintDice()
{
    Console.WriteLine($"Numbers: {dice1} {dice2} {dice3} {dice4} {dice5}");
    Console.WriteLine($"round: {diceroll}   ");
    diceroll++;

}

void FixDice()
{
    do
    {
        Console.WriteLine("fixing numbers: ");
        answer = (Console.ReadLine()!);
        switch (answer)
        {
            case "1":
                if (fixed1 == false)
                {
                    fixed1 = true;
                }
                else
                {
                    fixed1 = false;
                }
                break;
            case "2":
                if (fixed2 == false)
                {
                    fixed2 = true;
                }
                else
                {
                    fixed2 = false;
                }
                break;
            case "3":
                if (fixed3 == false)
                {
                    fixed3 = true;
                }
                else
                {
                    fixed3 = false;
                }
                break;

            case "4":
                if (fixed4 == false)
                {
                    fixed4 = true;
                }
                else
                {
                    fixed4 = false;
                }
                break;

            case "5":
                if (fixed5 == false)
                {
                    fixed5 = true;
                }
                else
                {
                    fixed5 = false;
                }
                break;
            default:
                break;
        }
    } while (answer != "R");
}
while (diceroll <= 3)
{
    RollDice();
    PrintDice();
    FixDice();
}

if (diceroll > 3)
{
    Console.Write("The game is over");
}
