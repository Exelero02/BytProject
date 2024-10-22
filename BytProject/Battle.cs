namespace BytProject
{
    public class Battle
    {
        public Player Player { get; private set; }
        public Enemy Enemy { get; private set; }
        public bool IsPlayerTurn { get; private set; }

        public Battle(Player player, Enemy enemy)
        {
            Player = player;
            Enemy = enemy;
            IsPlayerTurn = true;
        }

        public void StartBattle()
        {
            Console.WriteLine("The battle begins!");
            while (Player.Alive && Enemy.Alive)
            {
                if (IsPlayerTurn)
                {
                    PlayerTurn();
                }
                else
                {
                    EnemyTurn();
                }
                IsPlayerTurn = !IsPlayerTurn;
            }
            EndBattle();
        }

        public void EndBattle()
        {
            if (!Player.Alive)
            {
                Console.WriteLine($"{Player.Name} has been defeated.");
            }
            else
            {
                Console.WriteLine($"{Enemy.Name} has been defeated.");
                Enemy.GiveExp(Player);
            }
        }

        public void PlayerTurn()
        {
            Console.WriteLine("Player's turn:");
            Player.Attack(Enemy);
        }

        public void EnemyTurn()
        {
            Console.WriteLine("Enemy's turn:");
            Enemy.Attack(Player);
        }
    }

}
