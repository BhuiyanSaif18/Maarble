#pragma strict

var newScene : String;
var prevScene : String;
var i=0;
var timer : float= 30.0;
function Update(){
	timer -=Time.deltaTime;
	Debug.Log(timer);
	if(timer<=0) Application.LoadLevel(prevScene);
}
function OnTriggerEnter2D (hitInfo : Collider2D) {
	
	if(hitInfo.name =="ball1")
		{
			i++;
		}
	if(hitInfo.name =="ball2")
		{
			i++;
		}
	if(i>=2 )
		{
				Application.LoadLevel(newScene);
		}
} 
