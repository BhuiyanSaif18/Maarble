using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Timer1 : MonoBehaviour {

	// Use this for initialization
	public Text counterText;
	public float seconds, minutes;
	public int timer = 30;
	void Start () {
		// int  timer=30 ;
		counterText = GetComponent<Text> () as Text;
	}
	
	// Update is called once per frame
	void Update () {
		
		seconds =  (int)(Time.time % 60f);
		counterText.text =  ":" + seconds.ToString ("00");
	}
}
