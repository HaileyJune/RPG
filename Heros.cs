using System;

namespace RPG
{
    public class Hero
    {
        public string name;
        public int stress;
        public int energy;
        public int willpower;
        // Yes I know this is never used.
        // No I am not ready to give it up yet.

        public Hero (string MyName, int st, int en, int wi)
        {
            name = MyName;
            stress = st;
            energy = en;
            willpower = wi;
        }

        public void WorkOn(Monster task)
        {
            if (task == null)
            {
                System.Console.WriteLine("Please select a valid task.");
            }
            else if (task.isCompleate == true)
            {
                System.Console.WriteLine("This is already finished!");
            }
            else if (stress + task.stressLevel > 100)
            {
                System.Console.WriteLine("{0} is too stressed to work on this.", name);
            }
            else if (energy - task.stressLevel < 0)
            {
                System.Console.WriteLine("{0} is too tired to work on this.", name);
            }
            else if (task.compleation + 10 > 100)
            {
                System.Console.WriteLine("Well done! {0} finished {1}!", name, task.name);
                task.isCompleate = true;
                energy = energy - task.stressLevel;
            }
            else
            {
                System.Console.WriteLine("{0} worked on {1}.", name, task.name);
                task.compleation = task.compleation + 10;
                stress = stress + task.stressLevel;
                energy = energy - task.stressLevel;
            }
        }

        public void Rest()
        {
            if (stress - 10 < 0)
            {
                stress = 0;
            }
            else
            {
                stress = stress - 10;
            }
            if (energy + 50 > 100)
            {
                energy = 100;
            }
            else
            {
                energy = energy + 50;
            }
            System.Console.WriteLine("You've rested. Now your energy is at {0} and your stress is at {1}", energy, stress);
        }

        public void BingeTV()
        {
            if (energy - 10 < 0)
            {
                System.Console.WriteLine("You are too tired to stay up and watch this.");
            }
            else
            {
                if (stress - 30 < 0)
                {
                    stress = 0;
                }
                else
                {
                    stress = stress - 30;
                }
                energy = energy - 10;
                System.Console.WriteLine("You finished a season in one sitting. Your energy is now at {0} and your stress is at {1}.", energy, stress);
            }
        }

        public void GetInfo()
        {
            System.Console.WriteLine("###########");
            System.Console.WriteLine("Name: {0}", name);
            System.Console.WriteLine("Stress: {0}", stress);
            System.Console.WriteLine("Energy: {0}", energy);
            System.Console.WriteLine("###########");
        }
    }

    class TypeA : Hero
    {
        public TypeA(string MyName) : base (MyName, 50, 100, 100)
        {
        }
    }

    class TypeB : Hero
    {
        public TypeB(string MyName) : base (MyName, 0, 50, 100)
        {
        }
    }
}