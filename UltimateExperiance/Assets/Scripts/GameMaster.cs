using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class GameMaster : MonoBehaviour {

    private Text gameText;
    private List<String> narative = new List<String>();
    int currentLine;

	void Start () {

        gameText = GameObject.Find("txtGameText").GetComponent<Text>();
        readNarative();

        gameText.text = narative[0];
        currentLine = 1;


    }

    void Update()
    {
        if(pressCheckComp())
        {
            gameText.text = narative[currentLine];
            currentLine++;
        }
    }
 
    private void readNarative()
    {
        narative.Add("Congratulations on getting into the Institute of Technology, Tralee!\n" +
                    "Tomorrow is your first day of college.");

        narative.Add("Lets get you all setteled in.\nFirst things first, you need food. It's time to go to the shop!");

        narative.Add("We should take this time to buy lots of food, so where not running to the shop every other day.");
    }

    private bool pressCheckMobile()
    {
        if (Input.touchCount == 1)
        {
            RaycastHit2D touchRay = Physics2D.Raycast(Input.touches[0].position, transform.forward);

            if (touchRay.collider.gameObject == GameObject.Find("txtGameText"))
                return true;
            else
                return false;
        }

        else
            return false;
    }

    // Checks if the mouse is pressed, temp method for dev purposes
    private bool pressCheckComp()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D touchRay = Physics2D.Raycast(Input.mousePosition, transform.forward);

            if (touchRay.collider == GameObject.Find("txtGameText").GetComponent<Collider2D>())
                return true;
            else
                return false;
        }

        else
            return false;
    }

}
