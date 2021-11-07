using System;
namespace DamageCalculator
{
    public class ArrowDamage
    {
        

        private const decimal BASE_MULTIPLIER = 0.35M;
        private const decimal MAGIC_MULTIPLIER = 2.5M;
        private const decimal FLAME_DAMAGE = 1.25M;
        private int _roll;
        private bool _flamingDamage;
        private bool _magic;

        public int Roll
        {
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

        public ArrowDamage(int startingRoll)
        {
            _roll = startingRoll;
            CalculateDamage();
        }

        private void CalculateDamage()
        {
            decimal baseDamage = Roll * BASE_MULTIPLIER;
            if (Magic) baseDamage *= MAGIC_MULTIPLIER;
            if (Flaming) Damage = (int)Math.Ceiling(FLAME_DAMAGE + FLAME_DAMAGE);
            else Damage = (int)Math.Ceiling(baseDamage);
            
        }
    }
}
