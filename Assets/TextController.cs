using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class TextController : MonoBehaviour {
	
	public Text text; 
	private enum States {room, doors, bed, window, death, doors_2, freedom}
	private States myState; 
	
	// Use this for initialization
	void Start () {
		myState = States.room;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if(myState == States.room) {
			state_room();
		} else if(myState == States.doors) {
			state_doors();
		} else if(myState == States.bed) {
			state_bed ();
		} else if(myState == States.window) {
			state_windows();
		} else if(myState == States.death) {
			state_death();
		} else if(myState == States.freedom) {
			state_freedom(); 
		} else if(myState == States.doors_2) {
			state_doors_2();
		}
	}
	
	void state_room () {
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
	
	void state_death () {
		text.text = "You have been killed. "+
					"Press R to wakeup";
		if(Input.GetKeyDown(KeyCode.R)) {
			myState = States.room;
		}
	}
	
	void state_doors() {
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
	
	void state_bed() {
		text.text = "You start going under your bed and notice nothing there "+
					"While under the bed the room door opens and you see nothin "+
					"Suddently a face appears looking directly at you from the bototm "+
					"Of the door. And it starts coming extremely fast towards you. "+
					"Press the space key to continue"; 
		if(Input.GetKeyDown(KeyCode.Space)) {
			myState = States.death;
		}
	}	
	
	void state_windows() {
		text.text = "You are now in the window and see the letter F on the ground.";
		if(Input.GetKeyDown(KeyCode.F)) {
			myState = States.freedom;
		}
	}
	
	void state_doors_2() {
		text.text = "A huge pile of zombies start coming out of the door, eating your last bits. "+
					"Press the space key to fight for your life";
		if(Input.GetKeyDown(KeyCode.Space)) {
			myState = States.death;
		}
	}
	
	void state_freedom() {
		text.text = "Congradualtions, you have overcome your fears. "+
					"You may press the space bar to recall your dreams";
		if(Input.GetKeyDown(KeyCode.Space)) {
			myState = States.death;
		}
	}
}
