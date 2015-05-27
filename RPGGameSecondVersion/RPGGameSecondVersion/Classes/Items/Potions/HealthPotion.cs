namespace RPGGameSecondVersion.Classes.Items.Armors
{
    using System;
    using System.Drawing;

    using RPGGameSecondVersion.Interfaces;
    using RPGGameSecondVersion.Classes.Abstract;
    using RPGGameSecondVersion.Enums;
    class HealthPotion : Item, IItem
    {
        private const int PriceConst = 50;
        private const int ExtraDamageConst = 0;
        private const int ExtraDefenceConst = 0;
        private const int ExtraHealthConst = 50;
        public HealthPotion()
            : base(PriceConst, ExtraDamageConst, ExtraDefenceConst, ExtraHealthConst, ItemType.Potion, Image.FromFile("HealthPotion.png"), "Health Potion")
        {

        }
        public override string PrintInfoForItem()
        {
            return base.PrintInfoForItem() +
                String.Format("adds {0} Health Points to the hero ", this.ExtraHealth.ToString());
        }
    }
}
