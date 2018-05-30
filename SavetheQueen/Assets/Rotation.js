#pragma strict

public var speed : float;
var RotateLeft : KeyCode;
var RotareRight : KeyCode;
function Update () {
	//GetComponent<Collider>().enabled = false;
	if(Input.GetKey(RotateLeft))
	transform.Rotate (new Vector3 (0, 0, -speed));
	else if(Input.GetKey(RotareRight))
	transform.Rotate (new Vector3 (0, 0, speed));
	else transform.Rotate (new Vector3 (0, 0, 0));
}