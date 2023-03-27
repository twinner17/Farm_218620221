using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pickup: MonoBehaviour
{
	
	public int score = 0;
	public Text ScoreDisplayer;
	
	
	
	//use this for initialization
 void start()
 {
 
 }
 
 void update()
 {
   ScoreDisplayer.GetComponent<Text>().text="Score: " + score.ToString();
 }
 
	 private void OnTriggerEnter(Collider Farm_218620221)
	 {
		 
		 if( Farm_218620221.gameObject.name=="applez")
		 {
			 score+=2;
			 
				Destroy( Farm_218620221.gameObject);
	 }
	 
		  if( Farm_218620221.gameObject.name=="Bananaz")
			 {
				score+=3;
				 
					Destroy( Farm_218620221.gameObject);
	 }
	 
		 if(score==15)
		 {
			 SceneManager.LoadScene("CONGRATULATIONS");
		 }
	 
	}
}