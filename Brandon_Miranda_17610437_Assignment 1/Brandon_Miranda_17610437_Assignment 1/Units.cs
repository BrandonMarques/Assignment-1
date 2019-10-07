using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brandon_Miranda_17610437_Assignment_1 // I feel asleep on my keyboard while working and lost huge portions of code not sure how but hey....
{
   
        abstract class Unit
        {
            protected double xPosition; //Protected Definitions for question 1.3
            protected double yPosition;
            protected int hp;
            protected int atck;
            protected int maxHP;
            protected int atckRange;
            protected string team;
            protected string image;
            protected string name;
            protected bool attacking; //Boolean set for attacks

            public double XPosition
            { get => xPosition; set => xPosition = value; }
            public double YPosition
            { get => yPosition; set => yPosition = value; }// REPEAT 100000 times now XD
            public int Hp
            { get => hp; set => hp = value; }
            public int Atck
            { get => atck; set => atck = value; }
            public int AtckRange
            { get => atckRange; set => atckRange = value; } //Thanks for the slides XD Really came in handy
            public int MaxHP
            { get => maxHP; set => maxHP = value; }
            public string Team
            { get => team; set => team = value; }
            public string Image
            { get => image; set => image = value; }
            public string Name
            { get => name; set => name = value; }
            public bool Attacking
            { get => attacking; set => attacking = value; } //this took me an hour ;-; spelling is not my forte')

            public Unit(double Xposition, double Yposition, string team, string image, string name) // 
            {
            }

            public abstract Unit MovetoCLoseEnemy(Unit[] units);

            public abstract bool InRangeOfEnemy(Unit enemy);

            public abstract void MoveToEnemy(Unit enemy); 

            public abstract int Attack();// kinda obvious lol

            public abstract void Retreat();// It's A TRAAAAAAP, its actually just the move function

            public abstract void RecordsUnits();//created to save the units 

        }
}



