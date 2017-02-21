using UnityEngine;
using System.Collections;

public class GUIControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGui()
    {
        if (GUI.Button(new Rect(10, 10, 150, 100), "I am a button")) ;
        print("You clicked the button");
    }
}
