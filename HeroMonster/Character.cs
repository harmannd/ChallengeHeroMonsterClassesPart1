﻿
namespace ChallengeHeroMonsterClassesPart1 {
    class Character {
        private string name;
        private int health;
        private int damageMaximum;

        public Character(string inName, int inHealth, int inDamageMaximum) {
            name = inName;
            health = inHealth;
            damageMaximum = inDamageMaximum;
        }

        public string getName() {
            return name;
        }

        public int getHealth() {
            return health;
        }

        public int attack() {
            Dice attackDice = new Dice(damageMaximum);
            return attackDice.roll();
        }

        public void defend(int damage) {
            health -= damage;
        }
    }
}