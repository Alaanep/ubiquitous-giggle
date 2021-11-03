using System;
namespace PaintBall
{
    public class PaintBallGun
    {
        
        private int _balls = 0;

        public PaintBallGun(int balls, int magazineSize, bool loaded)
        {
            this._balls = balls;
            MagazineSize = magazineSize;
            if (loaded) Reload();
        }

        public int MagazineSize { get; private set; }

        public int BallsLoaded { get; private set; }

        public bool IsEmpty() { return BallsLoaded == 0; }

        public int Balls
        {
            get { return _balls; }
            set
            {
                if (value > 0)
                {
                    _balls = value;
                }
                Reload();
            }
        }

        public void Reload()
        {
            if (_balls > MagazineSize)
            {
                BallsLoaded = MagazineSize;
            } else
            {
                BallsLoaded = _balls;
            }
            Console.WriteLine($"{this} reloaded");
        }

        public bool Shoot()
        {
            if (BallsLoaded == 0) return false;
            BallsLoaded--;
            _balls--;
            return true;
        }

        
    }
}
