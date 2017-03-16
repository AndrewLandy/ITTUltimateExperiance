using UnityEngine;
using System.Collections;

public class GUIControl : MonoBehaviour
{
    private Player player;
    private const int STUDY_VAL = 5;
    private const int SOCIAL_VAL = 5;

    public void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    public void studyUp()
    {
        player.raiseStudy(SOCIAL_VAL);
        socialDown();
    }

    public void studyDown()
    {
        player.lowerStudy(SOCIAL_VAL);
    }

    public void socialUp()
    {
        player.raiseSoical(SOCIAL_VAL);
    }

    public void socialDown()
    {
        player.lowerSocial(SOCIAL_VAL);
    }

    public void moneyUp(float earn)
    {
        player.raiseMoney(earn);
    }

    public void moneyDown(float spent)
    {
        player.lowerMoney(spent);
    }

}
