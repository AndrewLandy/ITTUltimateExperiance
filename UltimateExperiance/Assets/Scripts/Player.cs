using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public int studyPoints;
    public int socialPoints;
    public float money;

    private Text gameText;

    private const string studyUp = "You  study up on your modules\nYou feel like you have a greater understanding of your course!";
    private const string studyStay = "You study up on your modules\nYou're exausted and feel like you've learned nothing!";
    private const string socialUp = "You spend some time with friends\nYou feel relaxed and had a great time!";
    private const string socialStay = "You spend some time with friends\nYou had a great time but couldn't shake the feeling you should have been working!";

    #region Attributes
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
        StudyPoints = 0;
        SocialPoints = 100;
        Money = 50.00f;

        gameText = GameObject.Find("txtGameText").GetComponent<Text>();

    }

    public void raiseStudy(int pointsGained)
    {
        if(StudyPoints < 100)
        {
            StudyPoints += pointsGained;

            gameText.text = studyUp;
        }

        else if (StudyPoints >= 100)
        {
            gameText.text = studyStay;
        }
    }

    public void lowerStudy(int pointsLost)
    {
        if(StudyPoints > 100)
            StudyPoints -= pointsLost;
    }

    public void raiseSoical(int pointsGained)
    {
        if (SocialPoints < 100)
        {
            SocialPoints += pointsGained;
            gameText.text = socialUp;
        }

        else if (SocialPoints >= 100)
            gameText.text = socialStay;
    }

    public void lowerSocial(int pointsLost)
    {
        if (SocialPoints > 0)
        SocialPoints -= pointsLost;
    }

    public void raiseMoney(float moneyGained)
    {
        Money += moneyGained;
    }

    public void lowerMoney(float moneyLost)
    {
        if (Money > 0)
            Money -= moneyLost;
    }

}
