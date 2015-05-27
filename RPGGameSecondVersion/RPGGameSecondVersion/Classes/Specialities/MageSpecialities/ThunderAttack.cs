namespace RPGGameSecondVersion.Classes.Specialities.MageSpecialities
{
    using System;
    using System.Drawing;

    using RPGGameSecondVersion.Interfaces;
    using RPGGameSecondVersion.Classes.Abstract;
    class ThunderAttack : Speciality, ISpeciality
    {
        private const int Damage = 50;
        private const int Level = 3;
        private const int Mana = 50;

        public ThunderAttack()
            : base(Damage, Level, Mana, Image.FromFile("ThunderAttack.png"), "Thunder Attack")
        {

        }
    }
}
