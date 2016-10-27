#pragma strict

function Start () {

}

var selectedCharacter : int = 1;
var characterName : String;
var currentSelect : GameObject;


function Update()
{
   if(Input.GetKeyDown(KeyCode.Space))
   {
      characterName = "water";
      currentSelect = GameObject.Find(characterName);
      if(currentSelect.GetComponent.<Renderer>().enabled){
      	currentSelect.GetComponent.<Renderer>().enabled = false;
      }else{
      	currentSelect.GetComponent.<Renderer>().enabled = true;
      }

   }
}