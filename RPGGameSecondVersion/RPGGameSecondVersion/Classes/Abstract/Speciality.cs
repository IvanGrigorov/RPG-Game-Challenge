namespace RPGGameSecondVersion.Classes.Abstract
{
    using System;
    using System.Drawing;

    using RPGGameSecondVersion.Interfaces;
    class Speciality : ISpeciality
    {
        public Speciality(int damage, int requiredLevel, int requiredMana, Image img, string name)
        {
            this.InflictedDamage = damage;
            this.RequiredLevel = requiredLevel;
            this.RequiredMana = requiredMana;
            this.SpecialityImage = img;
            this.Name = name;
        }
        public int InflictedDamage { get; protected set; }

        public int RequiredLevel { get; protected set; }

        public int RequiredMana { get; protected set; }

        public Image SpecialityImage { get; protected set; }

        public string Name { get; protected set; }

        public override string ToString()
        {
            return String.Format("{0} requires {1} level and {2} mana ", this.Name, this.RequiredLevel.ToString(),
                this.RequiredMana.ToString());
        } 
    }
}
