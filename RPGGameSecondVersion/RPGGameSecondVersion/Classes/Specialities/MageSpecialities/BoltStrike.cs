namespace RPGGameSecondVersion.Classes.Specialities.MageSpecialities
{
    using System;
    using System.Drawing;

    using RPGGameSecondVersion.Interfaces;
    using RPGGameSecondVersion.Classes.Abstract;
    class BoltStrike : Speciality, ISpeciality
    {
        private const int Damage = 100;
        private const int Level = 4;
        private const int Mana = 70;

        public BoltStrike()
            : base(Damage, Level, Mana, Image.FromFile("BoltStrike.png"), "Bolt Strike")
        {

        }
    }
}
