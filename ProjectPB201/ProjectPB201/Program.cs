namespace ProjectPB201
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Daraqın maksimum güllə tutumunu daxil edin: ");
            int maxBulletCapacity = Convert.ToInt32(Console.ReadLine());

            Weapon weapon = new Weapon(maxBulletCapacity);

            int choice;
            do
            {
                Console.WriteLine("\n0 - İnformasiya almaq üçün");
                Console.WriteLine("1 - Shoot metodu üçün");
                Console.WriteLine("2 - Fire metodu üçün");
                Console.WriteLine("3 - GetRemainBulletCount metodu üçün");
                Console.WriteLine("4 - Reload metodu üçün");
                Console.WriteLine("5 - ChangeFireMode metodu üçün");
                Console.WriteLine("6 - Proqramdan dayandırmaq üçün");
                Console.WriteLine("7 - Edit: 1 - Tutumu dəyişsin, 2 - Güllə sayı dəyişsin");

                Console.Write("Seçim edin (0-7): ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Console.WriteLine($"Silahın qalıq güllə sayı: {weapon.GetRemainBulletCount()}");
                        break;
                    case 1:
                        weapon.Shoot();
                        break;
                    case 2:
                        weapon.Fire();
                        break;
                    case 3:
                        Console.WriteLine($"Silahın qalıq güllə sayı: {weapon.GetRemainBulletCount()}");
                        break;
                    case 4:
                        weapon.Reload();
                        break;
                    case 5:
                        weapon.ChangeFireMode();
                        break;
                    case 7:
                        Console.Write("Seçim edin (1 - Tutumu dəyişsin, 2 - Güllə sayı dəyişsin): ");
                        int editChoice = Convert.ToInt32(Console.ReadLine());
                        if (editChoice == 1)
                        {
                            Console.Write("Yeni maksimum güllə tutumunu daxil edin: ");
                            int newMaxBulletCapacity = Convert.ToInt32(Console.ReadLine());
                            weapon = new Weapon(newMaxBulletCapacity);
                        }
                        else if (editChoice == 2)
                        {
                            Console.Write("Yeni güllə sayını daxil edin: ");
                            int newBulletCount = Convert.ToInt32(Console.ReadLine());
                            weapon = new Weapon(maxBulletCapacity);
                            weapon.Reload(newBulletCount);
                        }
                        break;
                    case 6:
                        Console.WriteLine("Proqram dayandırıldı.");
                        break;
                    default:
                        Console.WriteLine("Yanlış seçim! Xahiş edirəm yenidən cəhd edin.");
                        break;
                }
            } while (choice != 6);
        }
    }
}
