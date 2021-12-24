﻿using System;
namespace Animal
{
    public class Wolf: Canine, IPackHunter
    {
        public Wolf(bool belongsToPack )
        {
            BelongsToPack = belongsToPack;
        }

        public override void MakeNoise()
        {
            if (BelongsToPack)
            {
                Console.WriteLine("I'm in pack");
            }
            Console.WriteLine("Arooooooo");
        }

        public void HuntInPack()
        {
            if (BelongsToPack) {
                Console.WriteLine("I'm going hunting with my pack");        
            } else
            {
                Console.WriteLine("I'm not in a pack");
            }


        }
    }
}
