using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collide : MonoBehaviour {



	public  static int Score = 0;
	public Text Displayscore;
	public int bnumber=0;
	public int anumber=0;
	public Text message;
	double message_time;
	public Text timeText;
	public float time;


	//update score
	void Update(){

		Displayscore.GetComponent<Text>().text ="  " + Score.ToString();

		if (message_time>0)
		{
			message_time-=Time.deltaTime;
		} 
		else if (message.enabled)
		{
			message.enabled=false;

		}
			}

	public void OnTriggerEnter(Collider col)
	{

		if (col.gameObject.tag == "Bananaz" && bnumber < 3) {
			
			Score += 3;
			Destroy (col.gameObject);
			bnumber++;

		} else if (col.gameObject.tag == "Bananaz" && bnumber >= 3) {
			message.enabled = true;
			message.text="collected required number of bananas";
			message_time=1.0;
		}

		if (col.gameObject.tag == "applez" && anumber < 3) {
			Score += 2;
			Destroy (col.gameObject);
			anumber++;

		} else if (col.gameObject.tag == "applez" && anumber >= 3) {
			message.enabled = true;
			message.text = "collected required number of bananas";
			message_time = 1.0;
		}

		if(Score >=15)
		{
			SceneManager.LoadScene("congrats");

		}


	}




}