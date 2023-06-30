using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthOfWorldTree
{
    public class MonsterBase
    {
        public string Name { get; private set; }
        public int MaxHealth { get; private set; }
        public int Health { get; private set; }
        // public int MaxMana { get; private set; }
        // public int Mana { get; private set; }
        public int Atk { get; private set; }
        public int Def { get; private set; }
        public int Exp { get; private set; }

        public virtual void SetMonsterStatus(string name_, int health_, int atk_, int def_, int exp_)
        {
            Name = name_;
            MaxHealth = health_;
            Health = MaxHealth;
            Atk = atk_;
            Def = def_;
            Exp = exp_;
        }

        public virtual void RecieveDamage(int damage)
        {
            damage -= Def;

            if (damage <= 0)
            {
                damage = 1;
            }

            Health -= damage;

            if(Health <= 0)
            {
                Health = 0;
            }
        }
    }
}
