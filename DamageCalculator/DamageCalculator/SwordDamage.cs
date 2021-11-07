using System;
using System.Diagnostics;
namespace DamageCalculator
{

    public class SwordDamage
    {
        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;
        private int _roll;
        private bool _flamingDamage;
        private bool _magic;

        public int Roll {
            get { return _roll; }
            set
            {
                _roll = value;
                CalculateDamage();
            }
        }

        public bool Flaming
        {
            get { return _flamingDamage; }
            set
            {
                _flamingDamage = value;
                CalculateDamage();
            }
        }

        public bool Magic
        {
            get { return _magic; }
            set
            {
                _magic = value;
                CalculateDamage();
            }
        }

        public int Damage { get; private set; }

        public SwordDamage(int startingRoll)
        {
            _roll = startingRoll;
            CalculateDamage();
        }

        private void CalculateDamage()
        {
            decimal magicMultiplier = 1M;
            if (Magic) magicMultiplier = 1.75M;
            Damage = BASE_DAMAGE;
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;
            if (Flaming) Damage += FLAME_DAMAGE;
        }
    }
}
