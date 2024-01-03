using Game;

ConcretePlayerFactory playerFactory = new();
ConcreteEnemyFactory enemyFactory = new();

IPlayer player = playerFactory.CreatePlayer("Warrior");

IEnemy wizardEnemy = enemyFactory.CreateEnemy("Wizard");
IEnemy zombieEnemy = enemyFactory.CreateEnemy("Zombie");

IWall wall = new Wall();

player.HealthValue = 100;

wizardEnemy.HealthValue = 100;
zombieEnemy.HealthValue = 100;

Console.WriteLine("Player initial health: " + player.HealthValue);
Console.WriteLine("Wizard initial health: " + wizardEnemy.HealthValue);
Console.WriteLine("Zombie initial health: " + zombieEnemy.HealthValue);

Console.WriteLine();

IWeapon rocketLauncher = WeaponFactory.GetWeapon("RocketLauncher");
IProjectile rocket = ProjectileFactory.GetProjectile("Rocket");

player.EquipWeapon(rocketLauncher);
player.Shoot(rocket);
rocket.Impact(wall);

Console.WriteLine();

player.Shoot(rocket);
rocket.Impact(wizardEnemy);

Console.WriteLine();

IWeapon revolver = WeaponFactory.GetWeapon("Revolver");
IProjectile bullet = ProjectileFactory.GetProjectile("Bullet");

player.EquipWeapon(revolver);
player.Shoot(bullet);
bullet.Impact(zombieEnemy);

Console.WriteLine();

IProjectile throwingRevolver = ProjectileFactory.GetProjectile("ThrowingRevolver");
player.Throw(throwingRevolver);
throwingRevolver.Impact(zombieEnemy);

Console.WriteLine();

IWeapon hand = WeaponFactory.GetWeapon("Hand");
zombieEnemy.EquipWeapon(hand);
zombieEnemy.Strike(player);

Console.WriteLine();

Console.WriteLine("Player final health: " + player.HealthValue);
Console.WriteLine("Wizard final health: " + wizardEnemy.HealthValue);
Console.WriteLine("Zombie final health: " + zombieEnemy.HealthValue);
