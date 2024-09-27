//start main

DisplayMenu();
int userChoice = GetMenuChoice();
System.Console.WriteLine(userChoice);
RouteEm(userChoice);

//end main


static void DisplayMenu(){
    Console.Clear();
    System.Console.WriteLine("1. Plain Topping-less Pizza Slice\n2. Cheese Pizza Slice\n3. Pepperoni Pizza Slice\n4. Exit ");
}

static int GetMenuChoice(){
    System.Console.WriteLine("Enter Menu Choice");
    return int.Parse(Console.ReadLine());
}
static void RouteEm(int userChoice){
    if (userChoice == 1){
        System.Console.WriteLine("You chose Plain Topping-less Pizza Slice");
        PlainPizza();
    }
    else if (userChoice == 2){
        System.Console.WriteLine("You chose Cheese Pizza Slice");
        CheesePizza();
    }
    else if (userChoice == 3){
        System.Console.WriteLine("You chose Pepperoni Pizza Slice");
        PepperoniPizza();
    }
    else if (userChoice == 4){
        System.Console.WriteLine("You chose to Exit");
    }
    else{
        System.Console.WriteLine("Your input is invalid");
    }
}

static void PlainPizza(){
    Random rnd = new Random();
    int number = rnd.Next(8,13);
    System.Console.WriteLine($"Plain Pizza {number} x12");
    for (int i = number; i >= 1; i--){
        for (int j = 1; j <= i; j++){
           Console.Write("*" + " "); 
        }
       Console.WriteLine();
    }
    
    }

static void CheesePizza(){
Random rnd = new Random();
    int number = rnd.Next(8,13);
    System.Console.WriteLine($"Cheese Pizza {number} x12");
    for (int i = number; i >= 1; i--){
        for (int j = 1; j <= i; j++){
            // if first row -> print star
            //else if first collumn -> print star
            //else if last in row -> print star
            //else print # 
         if (i == number){
         Console.Write("*" + " ");
         }
         else if (j == 1){
            Console.Write("*" + " ");
         }
         else if (j == i){
            Console.Write("*" + " ");
         }
         else{
            Console.Write("#" + " ");
         }
        }
    Console.WriteLine();
}
}

static void PepperoniPizza(){
Random rnd = new Random();
    int number = rnd.Next(8,13);
    System.Console.WriteLine($"Pepperoni {number} x12");
    for (int i = number; i >= 1; i--){
        for (int j = 1; j <= i; j++){

            if (i == number){
         Console.Write("*" + " ");
         }
         else if (j == 1){
            Console.Write("*" + " ");
         }
         else if (j == i){
            Console.Write("*" + " ");
         }
         else{
            int chance = rnd.Next(1,3);
            if(chance == 1){
                Console.Write("[]" + " ");

            }
            else{
                Console.Write("#" + " ");
            }
         
        }
   
        }
        Console.WriteLine();
}
}