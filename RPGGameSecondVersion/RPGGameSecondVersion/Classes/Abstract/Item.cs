namespace RPGGameSecondVersion.Classes.Abstract
{
    using System;
    using System.Drawing;

    using RPGGameSecondVersion.Interfaces;
    using RPGGameSecondVersion.Enums;
    class Item : IItem
    {
        public Item(int price, int extraDamage, int extraDefence, int extraHealth, ItemType type, Image itemImage, string name)
        {
            this.Price = price;
            this.ExtraDamage = extraDamage;
            this.ExtraDefence = extraDefence;
            this.Type = type;
            this.ItemImage = itemImage;
            this.Name = name;
            this.ExtraHealth = extraHealth;
        }
        public int Price { get; protected set; }


        public int ExtraDamage { get; protected set; }


        public int ExtraDefence { get; protected set; }


        public Enums.ItemType Type { get; protected set; }

        public Image  ItemImage { get; protected set; }

        public string Name { get; protected set; }

        public int ExtraHealth { get; protected set; }


        public virtual string PrintInfoForItem()
        {
            return this.Name + " ";
        }
    }
}
