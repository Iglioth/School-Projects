using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerMonsterGamePracticeApp
{
    public class Hero
    {
        public int numberOfMonsterKilled { get; set; }

        public Hero(int Number)
        {
            this.numberOfMonsterKilled = Number;
        }

        public void Attack(Monster monster, int damage)
        {
            monster.LoseHealth(damage);
        }

        public void MonsterKilled()
        {
            numberOfMonsterKilled++;
        }
    }
} /*Een programmeur moet van zijn baas binnen een game de class ”Karakter” gaan programmeren. 
 * ”Karakter” is reedsgespecificeerd door middel van een kaartje waar alle verantwoordelijkheden op staan. 
 * Ook krijgt hij een class diagram met een duidelijk overzicht van de Methodes, (waaronder MoveForward en ValDoodNeer) en Attributen (zoals bijvoorbeeld AantalLevens, HaarKleur en AantalWapens). 
 * De programmeur neemt het kaartje en opent het bestaandeprojectin Visual Studio. Daar gaat hij dan de nieuwe Class in programmeren. 
 * Als eerste programmeert hij Fields voor AantalLevens en HaarKleur en vervolgens mapt hij de methodes MoveForward en ValDoodNeer naar C#-Objecten.
 * Als hij de Operation helemaal heeft geprogrammeerd gaat hij deze testen door er met de new-operator een Object van aan te maken. 
 * Hij roept de Methode MoveForward aan om te testen of het karakter de goede kant op beweegt. 
 * Ja, het werkt! Hij maakt nog een instance van ”Karakter” aan om te testen of hetprogrammadan nog steeds werkt. Ja! 
 * Met een voldaan gevoel gaat de programmeur aan het eind van de dag naar huis.*/

