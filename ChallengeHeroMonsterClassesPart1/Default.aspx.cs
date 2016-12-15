using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ChallengeHeroMonsterClassesPart1.Domain;

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