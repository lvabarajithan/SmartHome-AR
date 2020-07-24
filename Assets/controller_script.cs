using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;

public class controller_script : MonoBehaviour, IVirtualButtonEventHandler {

	private string LED_A = "LED A";
	private string LED_A_ON = "LedAOn";
	private string LED_A_OFF = "LedAOff";

	private string LED_B = "LED B";
	private string LED_B_ON = "LedBOn";
	private string LED_B_OFF = "LedBOff";

	public GameObject ledAOn;
	public GameObject ledAOff;
	public GameObject ledBOn;
	public GameObject ledBOff;

	private DatabaseReference rootRef;

	// Use this for initialization
	void Start () {

		FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://smarthome-abb.firebaseio.com/");
		rootRef = FirebaseDatabase.DefaultInstance.RootReference;

		// Led A
		ledAOn = GameObject.Find(LED_A_ON);
		ledAOn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		ledAOff = GameObject.Find(LED_A_OFF);
		ledAOff.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

		// Led B
		ledBOn = GameObject.Find(LED_B_ON);
		ledBOn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		ledBOff = GameObject.Find(LED_B_OFF);
		ledBOff.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	}

	public void OnButtonPressed(VirtualButtonBehaviour vb){
//		if (vb.VirtualButtonName == LED_A_ON) {
//			writeToFirebase (LED_A, 1);
//		}
//		if (vb.VirtualButtonName == LED_A_OFF) {
//			writeToFirebase (LED_A, 0);
//		}
	}

	private void writeToFirebase(string path, int state){
		rootRef.Child (path).Child ("state").SetValueAsync(state);
	}

	public void OnButtonReleased(VirtualButtonBehaviour vb){
		if (vb.VirtualButtonName == LED_A_ON) {
			writeToFirebase (LED_A, 1);
		}
		if (vb.VirtualButtonName == LED_A_OFF) {
			writeToFirebase (LED_A, 0);
		}
		if (vb.VirtualButtonName == LED_B_ON) {
			writeToFirebase (LED_B, 1);
		}
		if (vb.VirtualButtonName == LED_B_OFF) {
			writeToFirebase (LED_B, 0);
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
