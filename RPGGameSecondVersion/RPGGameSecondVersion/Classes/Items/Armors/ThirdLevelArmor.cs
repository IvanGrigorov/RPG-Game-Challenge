namespace RPGGameSecondVersion.Classes.Items.Armors
{
    using System;
    using System.Drawing;

    using RPGGameSecondVersion.Interfaces;
    using RPGGameSecondVersion.Classes.Abstract;
    using RPGGameSecondVersion.Enums;
    class ThirdLevelArmor : Item, IItem
    {
        private const int PriceConst = 150;
        private const int ExtraDamageConst = 0;
        private const int ExtraDefenceConst = 100;
        private const int ExtraHealthConst = 0;
        public ThirdLevelArmor()
            : base(PriceConst, ExtraDamageConst, ExtraDefenceConst, ExtraHealthConst, ItemType.Armor, Image.FromFile("ThirdLevelArmour.jpg"), "Ultimate Armor")
        {

        }
        public override string PrintInfoForItem()
        {
            return base.PrintInfoForItem() +
                String.Format("adds {0} Defence Points to the hero ", this.ExtraDefence.ToString());
        }
    }
}
