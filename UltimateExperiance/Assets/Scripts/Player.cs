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

    private const int STUDY_VAL = 5;
    private const int SOCIAL_VAL = 5;
    private const float MONEY_LOW = 10.00f;
    private const float MONEY_MID = 15.00f;
    private const float MONEY_HIGH = 20.00F;
    private const float GRANT = 336.11f;

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

    public void raiseStudy()
    {
        if(StudyPoints < 100)
        {
            StudyPoints += STUDY_VAL;

            gameText.text = studyUp;
        }

        else if (StudyPoints >= 100)
        {
            gameText.text = studyStay;
        }

        lowerSocial();
    }

    public void lowerStudy()
    {
        if(StudyPoints > 100)
            StudyPoints -= STUDY_VAL;
    }

    public void raiseSoical()
    {
        if (SocialPoints < 100)
        {
            SocialPoints += SOCIAL_VAL;
            gameText.text = socialUp;
        }

        else if (SocialPoints >= 100)
            gameText.text = socialStay;
    }

    public void lowerSocial()
    {
        if (SocialPoints > 0)
        SocialPoints -= SOCIAL_VAL;
    }

    public void raiseMoney()
    {
        Money += GRANT; ;
    }

    public void lowerMoneyLow()
    {
        if (Money > 0)
            Money -= MONEY_LOW;
    }

    public void lowerMoneyMid()
    {
        if (Money > 0)
            Money -= MONEY_MID;
    }

    public void lowerMoneyHigh()
    {
        if (Money > 0)
            Money -= MONEY_HIGH;
    }

}
