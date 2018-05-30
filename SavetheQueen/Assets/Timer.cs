using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
	//public Transform st;
	// Use this for initialization
	public Text counterText;
	public int seconds, minutes;
	public float timer=31;
	void Start()
	{
		counterText = GetComponent<Text>() as Text;
	}

	// Update is called once per frame
	void Update()
	{
		seconds = (int)timer;
		counterText.text = "Time Left :" + seconds.ToString("00");
		timer -= Time.deltaTime;
	}
}