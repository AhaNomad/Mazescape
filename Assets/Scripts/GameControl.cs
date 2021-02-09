using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace DigitaleVirkeligheder {
	public class GameControl : MonoBehaviour {
		public Text point;
		public Text scene;
		public Text time;
		private int Tid = 10;

		private int score;


		// Brug dette til initialization
		void Start () {
			score = 0;
			UpdateScore ();			

			//Coroutines er metoder som kan håndtere tid - som du ser nedenfor i metoden showStart venter metoden et par sekunder med WaitForSeconds()
			StartCoroutine (showStart("Scene 1"));
			StartCoroutine (showTime());

		}
	
		//Sætter en ny score, hvis score er større end [..] starter bane 2, hvis score er større end [..] har man vundet 
		public void AddScore (int addScoreValue){
			score += addScoreValue;
			UpdateScore ();
			if(score > 2000){				
				scene.text = "Du vinder";
				scene.enabled = true;
			}
		}

		//Sætter en ny levetid ( = health). Hvis man løber tør for tid har man tabt
		public void AddHealth (int howMuch){
			print ("Giving health: " + howMuch);
			Tid += howMuch;
		}

		void UpdateScore (){
			point.text = "Score: " + score.ToString();
		}
			

		void Lose(){
			scene.text = "Du taber";
			scene.enabled = true;		
		}

		//Viser introtekst i et antal sekunder
		IEnumerator showStart(string t){
			scene.text = t;
			scene.enabled = true;
			yield return new WaitForSeconds (2);
			scene.enabled = false;
		}

		//Viser resterende antal sekunder (= health)
		IEnumerator showTime(){
			while (Tid >= 0) {
				time.text = Tid.ToString() + " Sek";
				yield return new WaitForSeconds (1);
				Tid--;
			}
		}
	}
}

/* Lav et tomt GameObject og kald det GameControl
 * Læg dette script på det. Scriptet har tre felter - hvad mon de gør?
 * Lav et UI Text GameObject - det laver så også et Canvas og et EventSystem
 * Kald Text objektet ScoreText, og lav to til der kunne hedde HealthText og SceneText.
 * Træk disse tre objekter ind på scriptet. Kør, og se hvad der sker

 * Gør teksterne større, og gør dem røde og grønne. Men pas på - dimensionerne skal 
 * følge med op, når man øger skriftstørrelsen

 * Så skal vi have teksterne til at stå rigtigt. Det er deres Rect Transforms vi skal have 
 * fat i. Undersøg hvad der sker når du ændrer på pivot og position. Bemærk, at man kan vælge
 * at rette disse ting til ved hjælp af Shift- og Alt-tasterne

 * Til sidst skal vi have score og helbred til at ændre sig. Kan du regne ud hvordan og hvor?
*/
