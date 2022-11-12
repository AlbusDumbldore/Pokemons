namespace Pocemons
{
    internal class Program
    {
        static void Main()
        {
            Pokemon pokemon1 = new Pokemon(50, 15, 41, 35);
            Pokemon pokemon2 = new Pokemon(50, 10, 56, 69);
            Console.WriteLine("Бой.Pokemon1 vs Pokemon2");
            Console.WriteLine($"Покемон 1. Базовые характеристики: Здоровье - {pokemon1.Health}, Атака - {pokemon1.Attack}, Броня - {pokemon1.Armor}, Ловкость - {pokemon1.Dexterity}.");
            Console.WriteLine($"Покемон 2. Базовые характеристики: Здоровье - {pokemon2.Health}, Атака - {pokemon2.Attack}, Броня - {pokemon2.Armor}, Ловкость - {pokemon2.Dexterity}.");
            Console.WriteLine("Right!");
            Console.WriteLine("Введите команду:");

            string order = Console.ReadLine(); 
           
            while (order != "Бой окончен")
            {
                if (order == "Покемон1 атака")
                {
                    pokemon1.attack(pokemon2);
                    if (pokemon2.Health >= 0)
                    {
                        Console.WriteLine($"Покемон 2. Здоровье - {pokemon2.Health}");
                    }
                    
                    if (pokemon2.Health <= 0)
                    {
                        Console.WriteLine("Покемон 2. Здоровье - 0. Покемон 1 победил");
                    }
                }
                else if (order == "Покемон2 атака")
                {
                    pokemon2.attack(pokemon1);
                    if (pokemon1.Health >= 0)
                    {
                        Console.WriteLine($"Покемон 1. Здоровье - {pokemon1.Health}");
                    }
                    if (pokemon1.Health <= 0)
                    {
                        Console.WriteLine("Покемон 1. Здоровье - 0. Покемон 2 победил");
                    }
                }
                else if (order == "Покемон2 уворот")
                {
                    pokemon1.dexterity(pokemon2);

                    Console.WriteLine($"Покемон 2. Здоровье - {pokemon2.Health}");
                }
                else if (order == "Покемон2 блок")
                {
                    pokemon1.armor(pokemon2);
                    
                    Console.WriteLine($"Покемон 2. Здоровье - {pokemon2.Health}");
                }
                else if (order == "Покемон1 уворот")
                {
                    pokemon2.dexterity(pokemon1);
                   
                    Console.WriteLine($"Покемон 1. Здоровье - {pokemon1.Health}");
                }
                else if (order == "Покемон1 блок")
                {
                    pokemon2.armor(pokemon1);
                  
                    Console.WriteLine($"Покемон 1. Здоровье - {pokemon1.Health}");
                }
                else
                {
                    Console.WriteLine("Неверная команда");
                }
                Console.WriteLine("Введите команду:");
                order = Console.ReadLine();
                

            }    
            

        }
    }

    internal class Pokemon
    {
        public int Health;
        public int Attack;
        public int Armor;
        public int Dexterity;

        public Pokemon(int health, int attack, int armor, int dexterity)
        {
            Health = health;
            Attack = attack;
            Armor = armor;
            Dexterity = dexterity;
        }

        public void attack(Pokemon otherPokemon)
        {
            otherPokemon.Health -= Attack;
        }

        public void armor(Pokemon otherPokemon)
        {
            otherPokemon.Health += 0;
        }

        public void dexterity(Pokemon otherPokemon)
        {
            otherPokemon.Health += 0;
        }
    }
}