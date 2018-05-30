
using UnityEngine;
using System.Collections;

public class butterfly_move : MonoBehaviour
{

	public float sx, sy;

	void Update()
	{
		float x = sx * (Time.deltaTime);
		float y = sy * (Time.deltaTime);

		//Debug.Log (transform.position.x);
		//Debug.Log (transform.position.y);
		if (transform.position.y > 6f) {
			Vector3 temp;
			temp.x=transform.position.x;
			temp.y=-6f;
			temp.z=transform.position.z;
			transform.position=temp;
		}
		 transform.Translate(x, y, 0);
	}
}