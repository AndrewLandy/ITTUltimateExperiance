using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class GameMaster : MonoBehaviour {

    private Text gameText;
    private IEnumerator CO_updateText;

    delegate bool checkPress();
    checkPress isPressed;


	void Start () {

        gameText = GameObject.Find("txtGameText").GetComponent<Text>();
        CO_updateText = updateText();

        isPressed = pressCheckComp();

        StartCoroutine(CO_updateText);
        

    }
	
    //This method should be called everytime the screen is pressed
    private IEnumerator updateText()
    {

        gameText.text = "Congratulations on getting into the Institute of Technology, Tralee!\n" +
            "Tomorrow is your first day of college.";
        yield return new WaitUntil(() => isPressed());

        gameText.text = "Lets get you all setteled in.\nFirst things first, you need food. It's time to go to the shop!";
        yield return new WaitUntil(() => isPressed());

        gameText.text = "We should take this time to buy lots of food, so where not running to the shop every other day.";
        //yield return new WaitUntil(() => isPressed());

        //
        // rest of game text
        //


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
