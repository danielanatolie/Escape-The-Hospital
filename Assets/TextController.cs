using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class TextController : MonoBehaviour {
	
	public Text text; 
	private enum States {room, doors, bed, window, death, doors_2, field_0, doors_3, 
						window_1, freedom, man}
	private States myState; 
	
	// Use this for initialization
	void Start () {
		myState = States.room;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if(myState == States.room) { room();} 
		else if(myState == States.doors) {
			doors();
		} else if(myState == States.bed) {
			bed ();
		} else if(myState == States.window) {
			windows();
		} else if(myState == States.death) {
			death();
		} else if(myState == States.field_0) {
			field_0(); 
		} else if(myState == States.doors_2) {
			doors_2();
		} else if(myState == States.doors_3) {
			doors_3();
		} else if(myState == States.window_1) {
			window_1();
		} else if(myState == States.man) {
			man();
		}
		else if(myState == States.freedom) { freedom(); }
	}
	
	void room () {
		text.text = "You've awoken in a dark and gloomy broken room. "+
			"You hear something fall down the hallway and your heart starts "+
				"beating faster.\n \n"+
				"Press:\n"+
				"D - To exit your room and go through the hall way doors \n"+
				"B - Hide under your bed \n"+
				"W - Try breaking the window from the room\n"+
				"Space - kill yourself";
		if(Input.GetKeyDown(KeyCode.D)) {
			myState = States.doors;
		}
		else if(Input.GetKeyDown(KeyCode.B)) {
			myState = States.bed;
		}
		else if(Input.GetKeyDown(KeyCode.Space)) {
			myState = States.death;
		}
		else if(Input.GetKeyDown(KeyCode.W)) {
			myState = States.window; 
		}
	}
	
	void death () {
		text.text = "You have been killed. "+
					"Press R to wakeup";
		if(Input.GetKeyDown(KeyCode.R)) {
			myState = States.room;
		}
	}
	
	void doors() {
		text.text = "You walk closer to the doors and try to open them. "+
					"A breathing noise outside stops you from opening the doors.\n\n"+
					"Press:\n"+
					"D - to continue opening the doors\n"+
					"B - Hide under your bed \n"+
					"2+2 - Try breaking the window from the room";
		if(Input.GetKeyDown(KeyCode.D)) {
			myState = States.doors_2;
		}
		else if(Input.GetKeyDown(KeyCode.B)) {
			myState = States.bed;
		}
		else if(Input.GetKeyDown(KeyCode.W)) {
			myState = States.window; 
		}
		else if(Input.GetKeyDown(KeyCode.Space)) {
			myState = States.death;
		}
	}
	
	void bed() {
		text.text = "You start going under your bed and notice nothing there "+
					"While under the bed the room door opens and you see nothin "+
					"Suddently a face appears looking directly at you from the bototm "+
					"Of the door. And it starts coming extremely fast towards you. "+
					"Press the space key to continue"; 
		if(Input.GetKeyDown(KeyCode.Space)) {
			myState = States.death;
		}
	}	
	
	void windows() {
		text.text = "You are now in the window and see the letter F on the ground.";
		if(Input.GetKeyDown(KeyCode.F)) {
			myState = States.field_0;
		}
	}
	
	void doors_2() {
		text.text = "A huge pile of zombies start coming out of the door, eating your last bits. "+
					"Press the space key to fight for your life";
		if(Input.GetKeyDown(KeyCode.Space)) {
			myState = States.death;
		}
	}
	
	void field_0() {
		text.text = "You have jumped out of the window, and landed on a pile of dead bodies "+
					"You notice a door behind you, and a large field ahead with a man staring at you\n\n"+
					"Press:\n"+
					"D - To try to open the door\n"+
					"W - To climb back upto the window\n"+
					"M - To walk towards the man\n";
		if(Input.GetKeyDown(KeyCode.D)) {
			myState = States.doors_3;
		} else if(Input.GetKeyDown(KeyCode.W)) {
			myState = States.window_1;
		} else if(Input.GetKeyDown(KeyCode.M)) {
			myState = States.man;
		}
	}
	
	void doors_3() {
		text.text = "The door is locked, press R to return";
		if(Input.GetKeyDown(KeyCode.R)) {
			myState = States.field_0;
		}
	}
	void window_1() {
		text.text = "You try climbing down the walls, by notice zombies staring down at you. "+
					"Press R to return";
		if(Input.GetKeyDown(KeyCode.R)) {
			myState = States.field_0;
		}
	}
	void man() {
		text.text = "Man - Does every man have an equal oppurtunity to live?\n"+
					"Press:\n"+
					"Y - yes\n"+
					"N - no\n"+
					"R - return\n";
		if(Input.GetKeyDown(KeyCode.Y)) {
			myState = States.freedom;
		} else if(Input.GetKeyDown(KeyCode.N)) {
			myState = States.death;
		} else if(Input.GetKeyDown(KeyCode.R)) {
			myState = States.field_0;
		}	
	}
	void freedom() {
		text.text = "Game completed.\n"+
					"Press Y to play again";
		if(Input.GetKeyDown(KeyCode.Y)) {
			myState = States.room;
		}
	}
}
