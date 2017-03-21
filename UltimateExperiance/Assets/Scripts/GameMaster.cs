using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour {

    private Text gameText;

	void Start () {

        gameText = GameObject.Find("txtGameText").GetComponent<Text>();

        startCollege();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void startCollege()
    {
        gameText.text = "Congratulations on getting into the Institute of Technology, Tralee!\nTomorrow is your first day of college.";
        yield return new WaitUntil();
    }
}
