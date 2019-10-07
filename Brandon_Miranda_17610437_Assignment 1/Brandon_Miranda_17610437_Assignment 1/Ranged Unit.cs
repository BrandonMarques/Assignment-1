using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brandon_Miranda_17610437_Assignment_1
{
    class RangedUnit : Unit //couldnt figure out why it wasnt allowing me to create this class
    {
        Random r = new Random();

        public RangedUnit(double Xposition, double Yposition, string team, string image, string name) : base(Xposition, Yposition, team, image, name) //CONSTRUCTOR, AGAIN...
        {
            this.XPosition = Xposition;
            this.YPosition = Yposition;
            this.hp = 70; //Lower health because BALANCE, it cant be as tanky as a melee unit
            this.atck = 3;
            this.atckRange = 3; // felt that was fair..
            this.team = team;
            this.image = image;
            this.name = name;
            this.maxHP = MaxHP = 70;
            this.attacking = Attacking = false;
        }

        public override string ToString()
        {
            string[] unitType = GetType().ToString().Split('.');
            string myType = unitType[unitType.Length - 1];

            return team + "," + Name + "," + myType + "," + (XPosition + 1) + "," + (YPosition + 1) + "," + Hp;
        }
        public override Unit MoveCloseToUnit(Unit[] units)
        {

        }

        public override void InRandgeOfEnemy(Unit enemy)
        {

        }

        public override bool MoveToEnemy(Unit enemy)
        {

        }

        public override int Attack()
        {
            return this.Atck;
        }

        public override void Retreat()
        {
        }
        public override void RecordUnits()
        {

        }

    }// I feel asleep on my keyboard while working and lost huge portions of code not sure how but hey....
}
