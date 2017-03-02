using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class GUIControl : MonoBehaviour
{
    private Player player;
    private Text gameText;

    public void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        gameText = GameObject.Find("txtGameText").GetComponent<Text>();
        
    }

    public void study()
    {
        player.raiseStudy(5);
    }

    public void social()
    {
        player.raiseSoical(5);
    }

    public void updateText(string v)
    {
        gameText.text = v;
    }
}
