using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPB201
{
    public class Weapon
    {
        private int bulletCount;
        private int maxBulletCapacity;
        private FireMode fireMode;

        public Weapon(int maxBulletCapacity)
        {
            this.maxBulletCapacity = maxBulletCapacity;
            this.bulletCount = maxBulletCapacity; 
            this.fireMode = FireMode.Single; 
        }

        public void Shoot()
        {
            if (bulletCount > 0)
            {
                Console.WriteLine("Güllə atıldı!");
                bulletCount--;
            }
            else
            {
                Console.WriteLine("Güllə yoxdur!");
            }
        }

        public void Fire()
        {
            if (bulletCount > 0)
            {
                Console.WriteLine($"Bütün güllələr atəşləndi: {bulletCount} güllə");
                bulletCount = 0;
            }
            else
            {
                Console.WriteLine("Güllə yoxdur!");
            }
        }

        public int GetRemainBulletCount()
        {
            return bulletCount;
        }

        public void Reload(int newBulletCount)
        {
            bulletCount = maxBulletCapacity;
            Console.WriteLine($"Silah yenidən dolduruldu. Cəmi {maxBulletCapacity} güllə daxil edildi.");
        }

        public void ChangeFireMode()
        {
            fireMode = fireMode == FireMode.Single ? FireMode.Automatic : FireMode.Single;
            Console.WriteLine($"Atış modu dəyişdirildi: {fireMode}");
        }

        internal void Reload()
        {
            throw new NotImplementedException();
        }
    }
}
