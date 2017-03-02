using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public int studyPoints;
    public int socialPoints;

    public float money;

    private GUIControl guiManager;
    #region Properties
    public int StudyPoints
    {
        get
        {
            return studyPoints;
        }

        set
        {
            studyPoints = value;
        }
    }

    public int SocialPoints
    {
        get
        {
            return socialPoints;
        }

        set
        {
            socialPoints = value;
        }
    }

    public float Money
    {
        get
        {
            return money;
        }

        set
        {
            money = value;
        }
    }

    #endregion
    
    void Start()
    {
        guiManager = GameObject.Find("GUIManager").GetComponent<GUIControl>();

        StudyPoints = 0;
        SocialPoints = 100;
        Money = 50.00f;

    }

    public void raiseStudy(int pointsGained)
    {
        if (studyPoints < 100)
        {
            guiManager.updateText("You study for a while.\n" +
                    "You feel like you have a greater understanding of your subjects!");

            StudyPoints += pointsGained;
            lowerSocial(5);
        }

        else
        {
            guiManager.updateText("You study for a while.\n" +
                    "Unfourtunatly nothing stuck, maybe you should take a break!");

            lowerSocial(5);
        }
            
    }

    public void lowerStudy(int pointsLost)
    {
        StudyPoints -= pointsLost;
    }

    public void raiseSoical(int pointsGained)
    {
        if (socialPoints < 100)
        {
            guiManager.updateText("You Socalise for a while.\n" +
                    "You feel relaxed and refreshed. It was a enjoyable few hours!");

            SocialPoints += pointsGained;
        }

        else
            guiManager.updateText("You Socalise for a while.\n" +
                    "You had a good time, but other then that. nothing has changed!");
    }

    public void lowerSocial(int pointsLost)
    {
        if(socialPoints >0 )
            SocialPoints -= pointsLost;
    }

    public void raiseMoney(float moneyGained)
    {
        Money += moneyGained;
    }

    public void lowerMoney(float moneyLost)
    {
        Money -= moneyLost;
    }

}
