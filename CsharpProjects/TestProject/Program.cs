string[] GameElements = ["камень", "ножницы", "бумага", "огонь", "вода"];
Random random = new Random();
int playerWins = 0;
int computerWins = 0;

Console.WriteLine("добро пожаловать в игру камень ножницы бумага огонь вода е\n");
while (true)
{
    Console.WriteLine("выбирай или вирус получай 1. камень 2. ножницы 3. бумага 4. огонь 5. вода или не нажимай q для выхода\n");
    string choose = Console.ReadLine();
    if (choose == "q"){
        Console.WriteLine("НУ И ВАЛИ");
        break;
    }
    if (!int.TryParse(choose, out int UserChoose) || UserChoose < 1 || UserChoose > 5){
        Console.WriteLine("выбирай от 1 до 5");
        continue;
    }
    int computerchoose = random.Next(1, 6);
    Console.WriteLine($"вы выбрали: {GameElements[UserChoose - 1]}");
    Console.WriteLine($"компьютер выбрал: {GameElements[computerchoose - 1]}");

    if (UserChoose == computerchoose){
        Console.WriteLine("ну тип ничья бож абаюдно");
    }
    else if ((UserChoose == 1 && (computerchoose == 2 || computerchoose == 4 )) ||
    (UserChoose == 2 && (computerchoose == 3 || computerchoose == 5 )) ||
    (UserChoose == 3 && (computerchoose == 1 || computerchoose == 5 )) ||
    (UserChoose == 4 && (computerchoose == 2 || computerchoose == 3 )) ||
    (UserChoose == 5 && (computerchoose == 1 || computerchoose == 4 ))){
        Console.WriteLine("Игрок выиграл");
        playerWins += 1;
    }
    else{
        Console.WriteLine("компьютер выиграл абаюдно");
        computerWins += 1;
    }
    Console.WriteLine($"победы игрока: {playerWins}, победы компьютера: {computerWins}");

    if (computerWins >= 3){
        Console.WriteLine("компьютер победил немощ");
        break;
    }
    else if (playerWins >= 3){
        Console.WriteLine("тыж мое золотце игрок победил");
        break;
    }
}
