#pragma strict

var newScene : String;
var prevScene : String;
var timer : float= 30.0;
function Update(){
	timer -=Time.deltaTime;
	//Debug.Log(timer);
	if(timer<=0) Application.LoadLevel(prevScene);
}
function OnTriggerEnter2D (hitInfo : Collider2D) {
if(hitInfo.name =="ball1")
{
 Application.LoadLevel(newScene);
}
} 
