using System;

class Program
{
    static void Main(string[] args)
    {
        int choiceMainMenu = 0;
        List<Goal> goals = new List<Goal>();
        int points = 0;
        int completionCounter = 0;
        
        while (choiceMainMenu != 6) {
            Console.WriteLine($"\nYou have {points} points.\n");

            Console.WriteLine("Menu Options");
            Console.WriteLine(" 1. Create new goal");
            Console.WriteLine(" 2. List goals");
            Console.WriteLine(" 3. Save goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice form the menu: ");
            choiceMainMenu = int.Parse(Console.ReadLine());

            if (choiceMainMenu == 1) {
                Console.WriteLine("The types of goals are:");
                Console.WriteLine(" 1. Simple goal");
                Console.WriteLine(" 2. Eternal goal");
                Console.WriteLine(" 3. Checklist goal");
                Console.Write("Which type of goal would you like to create? ");
                int choiceGoalMenu = int.Parse(Console.ReadLine());

                if (choiceGoalMenu == 1) {
                    SimpleGoal simpleGoal = new SimpleGoal();
                    Console.Write("What is the name of your goal? ");
                    simpleGoal.SetName(Console.ReadLine());
                    Console.Write("What is a short description? ");
                    simpleGoal.SetDescription(Console.ReadLine());
                    Console.Write("What is the amount of points associated with this goal? ");
                    simpleGoal.SetPoints(int.Parse(Console.ReadLine()));
                    
                    goals.Add(simpleGoal);
                }
                else if (choiceGoalMenu == 2) {
                    EternalGoal eternalGoal = new EternalGoal();
                    Console.Write("What is the name of your goal? ");
                    eternalGoal.SetName(Console.ReadLine());
                    Console.Write("What is a short description? ");
                    eternalGoal.SetDescription(Console.ReadLine());
                    Console.Write("What is the amount of points associated with this goal? ");
                    eternalGoal.SetPoints(int.Parse(Console.ReadLine()));

                    goals.Add(eternalGoal);
                }
                else if (choiceGoalMenu == 3) {
                    ChecklistGoal checklistGoal = new ChecklistGoal();
                    Console.Write("What is the name of your goal? ");
                    checklistGoal.SetName(Console.ReadLine());
                    Console.Write("What is a short description? ");
                    checklistGoal.SetDescription(Console.ReadLine());
                    Console.Write("What is the amount of points associated with this goal? ");
                    checklistGoal.SetPoints(int.Parse(Console.ReadLine()));
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    checklistGoal.SetCompletionCount(int.Parse(Console.ReadLine()));
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    checklistGoal.SetBonus(int.Parse(Console.ReadLine()));

                    goals.Add(checklistGoal);
                }
                else {
                    Console.WriteLine("Please choose a number from the menu");
                }

            }
            else if (choiceMainMenu == 2) {
                Console.WriteLine("The Goals are:");
                int index = 1;
                foreach (Goal goal in goals) {
                    Console.WriteLine($"{index}. {goal.DisplayGoal()}");
                    index++;
                }
            }
            else if (choiceMainMenu == 3) {
                Console.Write("what is the filename for the goal file? ");
                string filename = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(filename)) {
                    outputFile.WriteLine(points);
                    foreach (Goal goal in goals) {
                        outputFile.WriteLine($"{goal.GetType().Name},{goal.WritingInFileString()}");
                    }
                }
            }
            else if (choiceMainMenu == 4) {
                Console.Write("what is your filename? ");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);
                
                for (int i=0; i<lines.Length; i++) {
                    if (i==0) points = int.Parse(lines[0]);
                    else {
                        string[] parts = lines[i].Split(",");
                        if (parts[0] == "SimpleGoal") {
                            SimpleGoal simpleGoal = new SimpleGoal();
                            simpleGoal.SetName(parts[1]);
                            simpleGoal.SetDescription(parts[2]);
                            simpleGoal.SetPoints(int.Parse(parts[3]));
                            simpleGoal.SetIsComplete(Boolean.Parse(parts[4]));
                            goals.Add(simpleGoal);
                        }
                        else if (parts[0] == "EternalGoal") {
                            EternalGoal eternalGoal = new EternalGoal();
                            eternalGoal.SetName(parts[1]);
                            eternalGoal.SetDescription(parts[2]);
                            eternalGoal.SetPoints(int.Parse(parts[3]));
                            goals.Add(eternalGoal);
                        }
                        else if (parts[0] == "ChecklistGoal") {
                            ChecklistGoal checklistGoal = new ChecklistGoal();
                            checklistGoal.SetName(parts[1]);
                            checklistGoal.SetDescription(parts[2]);
                            checklistGoal.SetPoints(int.Parse(parts[3]));
                            checklistGoal.SetBonus(int.Parse(parts[4]));
                            checklistGoal.SetCompletionCount(int.Parse(parts[5]));
                            checklistGoal.SetCompleted(int.Parse(parts[6]));
                            goals.Add(checklistGoal);
                            completionCounter = checklistGoal.GetCompleted();
                        }
                    }
                }
            }
            else if (choiceMainMenu == 5) {
                int index = 1;
                foreach (Goal goal in goals) {
                    Console.WriteLine($"{index}. {goal.GetName()}");
                    index++;
                }
                Console.Write("Which goal did you accomplish? ");
                int usrIndex = int.Parse(Console.ReadLine());
                
                points += goals[usrIndex-1].GetPoints();

                if (goals[usrIndex-1] is SimpleGoal simpleGoal) {
                    simpleGoal.SetIsComplete(true);
                    Console.WriteLine($"congratulations! You have earned {simpleGoal.GetPoints()} points!");
                }
                else if (goals[usrIndex-1] is EternalGoal eternalGoal) {
                    Console.WriteLine($"congratulations! You have earned {eternalGoal.GetPoints()} points!");
                }
                else if (goals[usrIndex-1] is ChecklistGoal checklistGoal) {
                    completionCounter++;
                    checklistGoal.SetCompleted(completionCounter);
                    if (checklistGoal.GetCompletionCount() == checklistGoal.GetCompleted()) {
                        points += checklistGoal.GetBonus();
                        Console.WriteLine($"congratulations! You have earned {checklistGoal.GetPoints() + checklistGoal.GetBonus()} points!");
                    }
                    else Console.WriteLine($"congratulations! You have earned {checklistGoal.GetPoints()} points!");
                }
                Console.WriteLine($"You now have {points} points.");
            }
            else if (choiceMainMenu == 6) {
                break;
            }
            else {
                Console.WriteLine("Please, choose a number form the menu.");
            }
        }
    }
}