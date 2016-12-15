using System;

namespace ChallengeHeroMonsterClassesPart1 {
    public partial class Default : System.Web.UI.Page {
        private CharacterInteraction characterInteraction;

        protected void Page_Load(object sender, EventArgs e) {
            characterInteraction = new CharacterInteraction();
        }

        protected void buttonFight_Click(object sender, EventArgs e) {
            labelResults.Text = characterInteraction.fight();
        }
    }
}