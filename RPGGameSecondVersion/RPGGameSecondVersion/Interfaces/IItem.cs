namespace RPGGameSecondVersion.Interfaces
{
    using System;
    using System.Drawing;

    using RPGGameSecondVersion.Enums;
    public interface IItem
    {
        string Name { get; }

        int Price { get; }

        int ExtraDamage { get; }

        int ExtraDefence { get; }

        int ExtraHealth { get; }
        ItemType Type { get; }

        Image ItemImage { get; }

        string PrintInfoForItem();
    }
}
