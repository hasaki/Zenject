using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Zenject
{
    public interface ITickable
    {
        void Tick();
    }

    public interface IFixedTickable
    {
        void FixedTick();
    }

    public interface ILateTickable
    {
        void LateTick();
    }
}

