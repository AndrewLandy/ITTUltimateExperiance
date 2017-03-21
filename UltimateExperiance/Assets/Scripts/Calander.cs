using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Calander : MonoBehaviour {

    private Text gameText;

    private enum dayType { SUNDAY, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY};
    private dayType currentDay;

	void Start () {
        currentDay = dayType.SUNDAY;
        gameText = GameObject.Find("txtGameText").GetComponent<Text>();
	}

    public void weekOne()
    {
        switch(currentDay)
        {
            case dayType.SUNDAY:
                {
                    "Congradulations on getting into the Institute of Technology, Tralee.\n"

                    break;
                }

            case dayType.MONDAY:
                {

                    break;
                }

            case dayType.TUESDAY:
                {

                    break;
                }

            case dayType.WEDNESDAY:
                {

                    break;
                }

            case dayType.THURSDAY:
                {

                    break;
                }

            case dayType.FRIDAY:
                {

                    break;
                }

            case dayType.SATURDAY:
                {

                    break;
                }
        }//End Switch

    }//End weekOne()
}
