using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {

	public GUISkin skin;
	public Transform bar;
	public float speed;
	bool flag, flag1, flag2;


	public float left_left, left_top, left_width, left_height;
	public float right_left, right_top, right_width, right_height;

	/*void start()
	{
	}*/

	/*void OnMouseDown()
	{
		flag = true;
	}

	void OnMouseUp()
	{
		flag1 = false;
		flag2 = false;
	}*/

	void rotate_left()
	{
		//if(flag)
		bar.Rotate (new Vector3 (0, 0, speed));
	}

	void rotate_right()
	{
		//if(flag)
		bar.Rotate (new Vector3 (0, 0, -speed));

	}

	void Update()
	{

			/*if (Input.GetButton ("Button"))
				rotate_left ();
			if (Input.GetButton ("Button"))
				rotate_right ();*/

	}

	/*public void OnGUI()
	{

		GUI.skin = skin;
		if (GUI.Button (new Rect (Screen.width * left_left, Screen.height * left_top, Screen.height * left_width, Screen.width * left_height), "Left", skin.button)) {
			//rotate_left ();
			flag = true;
		} 

		if (GUI.Button (new Rect (Screen.width * right_left, Screen.height * right_top, Screen.height * right_width, Screen.width * right_height), "Right", skin.button)) {
			//rotate_right ();
			flag=true;
		}
	}*/
}
