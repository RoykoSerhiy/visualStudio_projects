using System;

namespace AbstractFactory
{
    class Program
    {

        abstract class AbstractHorse { }
        abstract class AbstractHorseman {
            public abstract void Interact(AbstractHorse ah);
        
        }

        class Horse : AbstractHorse
        {

        }
        class Horseman : AbstractHorseman
        {
            public override void Interact(AbstractHorse ah)
            {
                Console.WriteLine(this.GetType().Name + " interact with"
                    + ah.GetType().Name);
            }
        }

        class EnemyHorse : AbstractHorse { }
        class EnemyHorseman : AbstractHorseman {

            public override void Interact(AbstractHorse ah)
            {
                Console.WriteLine(this.GetType().Name + " interact with"
                    + ah.GetType().Name);
            }

        }


        abstract class AbstractFactory
        {
            public abstract AbstractHorse CreateUnitHorse();
            public abstract AbstractHorseman CreateUnitHorseman(); 
        }

        class ConcreteFactory : AbstractFactory
        {
            public override AbstractHorse CreateUnitHorse()
            {
                return new Horse();
            }

            public override AbstractHorseman CreateUnitHorseman()
            {
                return new Horseman();
            }
        }

        class ConctreteEnemyFactory : AbstractFactory
        {
            public override AbstractHorse CreateUnitHorse()
            {
                return new EnemyHorse();
                     
            }
            public override AbstractHorseman CreateUnitHorseman()
            {
                return new EnemyHorseman();
            }
        }

        class Player
        {
            private AbstractHorse _abstractHorse;
            private AbstractHorseman _abstractHorseman;

            public Player(AbstractFactory factory)
            {
                _abstractHorse = factory.CreateUnitHorse();
                _abstractHorseman = factory.CreateUnitHorseman();
            }

            public void Run()
            {
                _abstractHorseman.Interact(_abstractHorse);
            }
        }

        static void Main()
        {
            AbstractFactory factory1 = new ConcreteFactory();
            Player player = new Player(factory1);

            player.Run();
            AbstractFactory factory2 = new ConctreteEnemyFactory();

            Player enemy = new Player(factory2);
            enemy.Run();
        }
    }
}
