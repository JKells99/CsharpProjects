// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);
// int total = roll1 + roll2 + roll3;
// bool triple;
// bool doubles; 


// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if((roll1 == roll2 || (roll2==roll3) || (roll1 == roll3)))
// {
//     Console.WriteLine("you Rolled doubles! +2 Points");
//     total+=2;

// }

// if((roll1==roll2) && (roll2 == roll3))
// {
//     Console.WriteLine("You Rolled triples! +6 bonus");
//     total +=6;
// }



// if (total >= 15)
// {
//     Console.WriteLine("You Win!");
// }

// if (total < 15)
// {
//     Console.WriteLine("You Suck Ass....");
// }




// string message = "The quick brown fox jumps over the lazy dog.";
// bool result = message.Contains("dog");
// Console.WriteLine(result);

// if (message.Contains("fox"))
// {
//     Console.WriteLine("What does the fox say?");
// }


// Random random = new Random();
// int daysUntilExpiry = random.Next(12);
// int discountPercentage = 0;

// if (daysUntilExpiry == 0)
// {
//     Console.WriteLine("Your subscription has expired.");
// }
// else if (daysUntilExpiry == 1)
// {
//     discountPercentage = 20;
//     Console.WriteLine($"Your subscription expires within a day!");
//     Console.WriteLine($"Renew now and save {discountPercentage}%!");


// }
// else if (daysUntilExpiry <= 5)
// {
//     discountPercentage = 10;
//     Console.WriteLine($"Your subscription expires in {daysUntilExpiry} days.");
//     Console.WriteLine($"Renew now and save {discountPercentage}%!");


// }
// else if (daysUntilExpiry <= 10)
// {
    
//     Console.WriteLine($"Your subscription will expire soon. Renew now!");
    

// }

// if(discountPercentage > 0)
// {
//     Console.WriteLine($"A Discount Has Been Applied! At {discountPercentage}%");
// }

// string[] fradulentOrdersIds = new string[3];

// fradulentOrdersIds[0] = "A123";
// fradulentOrdersIds[1] = "B456";
// fradulentOrdersIds[2] = "C789";



// string[] fradulentOrdersIds = {"A123","B456","C789"};

// Console.WriteLine($"FIRST: {fradulentOrdersIds[0]}");
// Console.WriteLine($"SECOND: {fradulentOrdersIds[1]}");
// Console.WriteLine($"THIRD: {fradulentOrdersIds[2]}");

// fradulentOrdersIds[0] = "G568";

// Console.WriteLine(" ");

// Console.WriteLine($"FIRST: {fradulentOrdersIds[0]}");
// Console.WriteLine($"SECOND: {fradulentOrdersIds[1]}");
// Console.WriteLine($"THIRD: {fradulentOrdersIds[2]}");

// Console.WriteLine($"There are {fradulentOrdersIds.Length} Fraudulent Orders to Process");

// string[] names = {"Rowena", "Robin","Bao"};
// foreach(string name in names)
// {
//     Console.WriteLine(name);
// }


int[] inventory = {200,450,700,175,250};
int itemNumber = 0;
int itemCount = 0;


foreach(int items in inventory)
{

    itemCount +=  items;
    itemNumber++;

    Console.WriteLine($"Bin {itemNumber} = {items} items (Running total: {itemCount})");


}

    Console.WriteLine($"We Have {itemCount} Items In Stock");






















