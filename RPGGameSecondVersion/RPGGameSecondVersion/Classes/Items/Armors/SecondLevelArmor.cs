namespace RPGGameSecondVersion.Classes.Items.Armors
{
    using System;
    using System.Drawing;

    using RPGGameSecondVersion.Interfaces;
    using RPGGameSecondVersion.Classes.Abstract;
    using RPGGameSecondVersion.Enums;
    class SecondLevelArmor : Item, IItem
    {
        private const int PriceConst = 100;
        private const int ExtraDamageConst = 0;
        private const int ExtraDefenceConst = 50;
        private const int ExtraHealthConst = 0;
        public SecondLevelArmor()
            : base(PriceConst, ExtraDamageConst, ExtraDefenceConst, ExtraHealthConst, ItemType.Armor, Image.FromFile("SecondLevelArmour.png"), "Ritual Armor")
        {

        }
        public override string PrintInfoForItem()
        {
            return base.PrintInfoForItem() +
                String.Format("adds {0} Defence Points to the hero ", this.ExtraDefence.ToString());
        }
    }
}
