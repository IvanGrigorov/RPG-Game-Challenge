using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGameSecondVersion.Interfaces
{
    using System;

    using System.Drawing;
    public interface ISpeciality
    {
        string Name { get; }

        int InflictedDamage { get; }

        int RequiredLevel { get; }

        int RequiredMana { get; }

        Image SpecialityImage { get; }
    }
}
