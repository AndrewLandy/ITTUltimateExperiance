using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    private int studyPoints;
    private int socialPoints;
    private float money;

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

    void Start()
    {
        StudyPoints = 0;
        SocialPoints = 100;
        Money = 50.00f;

    }

    public void raiseStudy(int pointsGained)
    {
        StudyPoints += pointsGained;
    }

    public void lowerStudy(int pointsLost)
    {
        StudyPoints -= pointsLost;
    }

    public void raiseSoical(int pointsGained)
    {
        SocialPoints += pointsGained;
    }

    public void lowerSocial(int pointsLost)
    {
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
