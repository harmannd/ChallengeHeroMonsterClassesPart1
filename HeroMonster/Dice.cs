﻿using System;

namespace ChallengeHeroMonsterClassesPart1 {
    class Dice {
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