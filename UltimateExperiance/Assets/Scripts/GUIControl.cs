﻿using UnityEngine;
using System.Collections;

public class GUIControl : MonoBehaviour
{
    private Player player;

    public void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    public void studyNormal()
    {
        player.StudyPoints += 5;
    }

}
