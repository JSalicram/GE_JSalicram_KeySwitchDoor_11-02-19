﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LevelManager.instance.flipTheSwitch();
        }
    }
}