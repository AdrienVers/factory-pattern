namespace Game
{
    public abstract class Character : ICharacter, IEntity
    {
        public string Name { get; set; } = string.Empty;
        public string OutfitColor { get; set; } = string.Empty;
        public int HealthValue { get; set; }
        public IWeapon? EquippedWeapon { get; protected set; }

        public void TakeDamage(int damage)
        {  
            HealthValue -= damage;
            if (HealthValue <= 0)
            {
                Console.WriteLine($"{GetType().Name} is dead!");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} takes {damage} damage and has " + HealthValue + "/100" + " health remaining.");
            }
        }

        public void EquipWeapon(IWeapon weapon)
        {
            EquippedWeapon = weapon;
            Console.WriteLine($"{GetType().Name} equipped " + weapon.Name);
        }

        public void Shoot(IProjectile projectile)
        {
            if (EquippedWeapon is IShootable shootableWeapon)
            {
                if (projectile != null)
                {
                    Console.WriteLine($"{GetType().Name} shoots {projectile.GetType().Name} with {EquippedWeapon.Name}");
                    shootableWeapon.Shoot(projectile);
                }
                else
                {
                    Console.WriteLine($"{GetType().Name} cannot shoot: no projectile.");
                }
            }
            else
            {
                Console.WriteLine($"{GetType().Name}'s weapon cannot shoot.");
            }
        }

        public void Strike(IEntity target)
        {
            if (EquippedWeapon != null)
            {
                if (target is ICharacter characterTarget)
                {
                    Console.WriteLine($"{GetType().Name} strikes {target.GetType().Name} with {EquippedWeapon.Name}");
                    EquippedWeapon.Strike();
                    characterTarget.TakeDamage(EquippedWeapon.DamageValue);
                }
                else if (target is IObject objectTarget)
                {
                    Console.WriteLine("Object is struck");
                }
                else
                {
                    Console.WriteLine("No target");
                }
            }
            else
            {
                Console.WriteLine($"{GetType().Name} has no weapon to strike with.");
            }
        }


         public void Throw(IProjectile projectile)
        {
            if (EquippedWeapon is IThrowable throwableWeapon)
            {
                if (projectile != null)
                {
                    Console.WriteLine($"{GetType().Name} throw {projectile.GetType().Name} with {EquippedWeapon.Name}");
                    throwableWeapon.Throw(projectile);
                    EquippedWeapon = null;
                }
                else
                {
                    Console.WriteLine($"{GetType().Name} cannot throw: no projectile.");
                }
            }
            else
            {
                Console.WriteLine($"{GetType().Name}'s weapon cannot be throwable.");
            }
        }

        public void Reload()
        {
            if (EquippedWeapon is IShootable reloadableWeapon)
            {
                reloadableWeapon.Reload();
                Console.WriteLine($"{GetType().Name} reloads the {EquippedWeapon.Name}");
            }
            else if (EquippedWeapon != null)
            {
                Console.WriteLine($"{EquippedWeapon.Name} cannot be reloaded.");
            }
        }
    }
}