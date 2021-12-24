using System;
namespace Animal
{
    public abstract class Canine: Animal
    {
        public bool BelongsToPack { get; protected set; } = false;

    }
}
