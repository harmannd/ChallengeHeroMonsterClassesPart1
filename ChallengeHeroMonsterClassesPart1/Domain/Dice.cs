using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeHeroMonsterClassesPart1.Domain {
    public class Dice {
        private int sides;
        private Random random = new Random();

        public Dice(int inSides) {
            sides = inSides;
        }

        public int roll() {
            return random.Next(sides);
        }
    }
}