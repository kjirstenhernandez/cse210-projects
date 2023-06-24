using System;

class Program
{
    static void Main(string[] args)
    {
        int menuChoice = 0;
        int secondChoice = 0;
        string name;
        string description;
        int currentPoints;
        List<Goal> goals = new List<Goal>();
        GoalManager goalManager = new GoalManager();

        // Displays Main Menu
        while (menuChoice != 7){
            Console.WriteLine();
            Console.WriteLine($"Your Score: {goalManager.GetScore()}");
            Console.WriteLine($"Level: {goalManager.GetLevel()}");
            Console.WriteLine();     
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1.  Create New Goal");
            Console.WriteLine("2.  List Goals");
            Console.WriteLine("3.  Save Goals");
            Console.WriteLine("4.  Load Goals");
            Console.WriteLine("5.  Record Event");
            Console.WriteLine("6.  Get Level Description");
            Console.WriteLine("7.  Quit");
            Console.Write("Select A Choice from the Menu: ");
            string _userMenuOption = Console.ReadLine();
            menuChoice = int.Parse(_userMenuOption);
            

            // Displays Submenu for Goal Types
            if (menuChoice == 1){
                Console.WriteLine();
                Console.WriteLine("The types of goals are: ");
                Console.WriteLine("1. Simple");
                Console.WriteLine("2. Eternal");
                Console.WriteLine("3. Checklist");
                Console.Write("Select A Choice from the Menu: ");
                string userSecondChoice = Console.ReadLine();
                secondChoice = int.Parse(userSecondChoice);

                if (secondChoice == 1){
                    Console.Write("What is the name of your goal? ");
                    name = Console.ReadLine();
                    Console.Write("What is a short description of your goal? ");
                    description = Console.ReadLine();
                    Console.Write("How many points should this goal be worth? ");
                    string points = Console.ReadLine();
                    currentPoints = int.Parse(points);

                    goals.Add(new Simple(name, description, currentPoints));
                }
                else if (secondChoice == 2){
                    Console.Write("What is the name of your goal? ");
                    name = Console.ReadLine();
                    Console.Write("What is a short description of your goal? ");
                    description = Console.ReadLine();
                    Console.Write("How many points should this goal be worth? ");
                    string points = Console.ReadLine();
                    currentPoints = int.Parse(points);

                    goals.Add(new Eternal(name, description, currentPoints));                    
                }
                else if (secondChoice == 3){
                    Console.Write("What is the name of your goal? ");
                    name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    string points = Console.ReadLine();
                    currentPoints = int.Parse(points);
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    string numTimes = Console.ReadLine();
                    int repeatTimes = int.Parse(numTimes);
                    Console.Write("What is the bonus for acomplishing it that many times? ");
                    string userBonus = Console.ReadLine();
                    int bonusPoints = int.Parse(userBonus);

                    goals.Add(new Checklist(name, description, currentPoints, bonusPoints, repeatTimes));
                    }
                else{
                    Console.WriteLine("Incorrect input.  Please try again.");
                }
            }

            else if (menuChoice == 2){
                Console.WriteLine();
                Console.WriteLine("The goals are:");
                foreach (Goal goal in goals){
                    Console.WriteLine(goal.DisplayGoal());
                }
            }

            else if (menuChoice == 3){
                Console.WriteLine();
                Console.WriteLine("What is the filename you would like to save to? ");
                string filename = Console.ReadLine();
                DataFile dataFile = new DataFile();
                foreach (Goal goal in goals){
                    dataFile.ImportGoals(goal.SaveGoaltoFile());
                }
                dataFile.SaveFile(filename);

            }

            else if (menuChoice == 4){
                goals.Clear();
                Console.WriteLine();
                Console.WriteLine("What is the filename you would like to load? ");
                string filename = Console.ReadLine();
                DataFile dataFile = new DataFile();
                List<string> goalData = dataFile.LoadFile(filename);
                foreach (string item in goalData){
                    string[] goal = item.Split(",");
                    string goalType = goal[0];
                        if (goalType == "Simple"){
                            string goalName = goal[1];
                            string goalDescription = goal[2];
                            int goalPoints = int.Parse(goal[3]);
                            string goalCompletion = goal[4];
                            goals.Add(new Simple(goalName, goalDescription, goalPoints));
                            }
                        else if (goalType == "Eternal"){
                            string goalName = goal[1];
                            string goalDescription = goal[2];
                            int goalPoints = int.Parse(goal[3]);
                            goals.Add(new Eternal(goalName, goalDescription, goalPoints));
                            }
                        else if (goalType == "Checklist"){
                                string goalName = goal[1];
                                string goalDescription = goal[2];
                                int goalPoints = int.Parse(goal[3]);
                                int goalBonus = int.Parse(goal[4]);
                                int goalRepeats = int.Parse(goal[5]);
                                int goalCurrentTimes = int.Parse(goal[6]);
                                goals.Add(new Checklist(goalName, goalDescription, goalPoints, goalBonus, goalRepeats, goalCurrentTimes));
                        }
                }
                
            }

            else if (menuChoice == 5){
                int position = 1;
                
                Console.WriteLine();
                foreach(Goal goal in goals){
                    Console.WriteLine($"{position}. {goal.GetName()}");
                    position += 1;
                }
                Console.WriteLine("What goal did you accomplish?");
                string userResponse = Console.ReadLine();
                int goalChoice = int.Parse(userResponse);
                int index = goalChoice - 1;
                goalManager.SetScore(goals[index].RecordEvent());
                int newScore = goalManager.GetScore();
                goalManager.CheckIncrease();
                Console.WriteLine($"You now have {newScore} points.");
            }

            else if (menuChoice == 6){
                Console.WriteLine();
                Console.WriteLine(goalManager.GetDescription());
            }
            else {
                Console.WriteLine();
                Console.WriteLine("Incorrect input.  Please try again.");
            }
        }
    }
}