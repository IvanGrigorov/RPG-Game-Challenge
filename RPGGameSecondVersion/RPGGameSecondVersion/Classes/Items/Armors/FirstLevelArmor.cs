namespace RPGGameSecondVersion.Classes.Items.Armors
{
    using System;
    using System.Drawing;

    using RPGGameSecondVersion.Interfaces;
    using RPGGameSecondVersion.Classes.Abstract;
    using RPGGameSecondVersion.Enums;
    class FirstLevelArmor : Item, IItem
    {
        private const int PriceConst = 50;
        private const int ExtraDamageConst = 0;
        private const int ExtraDefenceConst = 20;
        private const int ExtraHealthConst = 0;
        public FirstLevelArmor()
            : base(PriceConst, ExtraDamageConst, ExtraDefenceConst, ExtraHealthConst, ItemType.Armor, Image.FromFile("FirstLevelArmour.png"), "Leather Armor")
        {

        }

        public override string PrintInfoForItem()
        {
            return base.PrintInfoForItem() + 
                String.Format("adds {0} Defence Points to the hero ", this.ExtraDefence.ToString());
        }
    }
}
