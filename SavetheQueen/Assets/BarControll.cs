using UnityEngine;
using System.Collections;

public class BarControll : MonoBehaviour {

	public float speed;
	public Transform bar;

	void rotate_left()
	{
		bar.Rotate (new Vector3 (0, 0, speed));
	}
	void rotate_right()
	{
		bar.Rotate (new Vector3 (0, 0, -speed));
	}

	void Update () {
		foreach (Touch touch in Input.touches) {
			Vector3 position = Camera.main.ScreenToWorldPoint (touch.position);
			if (position.x < -5) {
				if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
					rotate_left ();
			} else if (position.x > 5) {
				if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
					rotate_right ();
			}
		}
	}
}
