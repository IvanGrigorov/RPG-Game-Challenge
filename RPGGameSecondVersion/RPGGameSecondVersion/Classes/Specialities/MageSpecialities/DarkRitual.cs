namespace RPGGameSecondVersion.Classes.Specialities.MageSpecialities
{
    using System;
    using System.Drawing;

    using RPGGameSecondVersion.Interfaces;
    using RPGGameSecondVersion.Classes.Abstract;
    class DarkRitual : Speciality, ISpeciality
    {
        private const int Damage = 30;
        private const int Level = 2;
        private const int Mana = 20;
        
        public DarkRitual()
            : base(Damage, Level, Mana, Image.FromFile("Dark Ritual.jpg"), "Dark Ritual")
        {

        }
    }
}
