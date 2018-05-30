#pragma strict

function OnCollisionEnter2D (colInfo : Collision2D) {
	if(colInfo.collider.tag== "Player"){
		//var velY=GetComponent(Rigidbody2D).velocity.y;
		GetComponent(Rigidbody2D).velocity.y=GetComponent(Rigidbody2D).velocity.y+colInfo.collider.GetComponent(Rigidbody2D).velocity.y/3;
		GetComponent(AudioSource).Play();
	}
}