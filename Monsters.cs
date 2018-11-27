using System;

namespace RPG
{
    public class Monster
    {
        public string name;
        public int compleation;
        public int stressLevel;
        public bool isCompleate;

        public Monster(string task, int comp, int str, bool isCom)
        {
            name = task;
            compleation = comp;
            stressLevel = str;
            isCompleate = isCom;
        }
    }

    public class Chore : Monster
    {
        public Chore(string task) : base (task, 0, 10, false)
        {

        }
    }

    public class Work : Monster
    {
        public Work(string task) : base (task, 0, 20, false)
        {
            
        }
    }
}