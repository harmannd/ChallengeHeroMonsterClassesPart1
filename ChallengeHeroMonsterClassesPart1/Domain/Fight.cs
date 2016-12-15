using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ChallengeHeroMonsterClassesPart1.Domain {
    public class characterInteraction {
        private Character hero, monster;
        private Dice dice = new Dice(10);
        private string result;

        public characterInteraction() {
            hero = new Character("Derek", 100, 25);
            monster = new Character("Nurgle", 300, 10);
        }

        private void attack(Character attacker, Character defender) {
            defender.defend(attacker.attack());
            if (dice.roll() >= 6) {
                defender.defend(attacker.attack());
            }
        }

        public string fight() {
            while (hero.getHealth() > 0 && monster.getHealth() > 0) {
                attack(monster, hero);
                attack(hero, monster);
            }

            displayStats();
            displayWinner();
            return result;
        }

        private void displayStats() {
            result = "Hero " + hero.getName()
                + " HP: " + hero.getHealth()
                + "<br />Monster " + monster.getName()
                + " HP: " + monster.getHealth();
        }

        private void displayWinner() {
            result += "<br /><h2>Winner: " + winner() + "!</h2>";
        }

        private string winner() {
            if (hero.getHealth() > 0) {
                return hero.getName();
            }
            else if (monster.getHealth() > 0) {
                return monster.getName();
            }
            else {
                return "None";
            }
        }
    }
}