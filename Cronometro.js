#pragma strict
var Timer = 0.0;
var textTime : String;
function Start () {

}
function Update ()
{


Timer += Time.deltaTime;


GetComponent<GUIText>();
 
}