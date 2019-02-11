using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    public static LevelManager instance;

    public SwitchController theSwitch;

    public bool switchEnabled;
    public bool switchOff;

    private void Awake()
    {
        instance = this;
    }

    public void flipTheSwitch()
    {

        if (switchEnabled == true)
        {
            if (switchOff == true)
            {
                theSwitch.turnOn();
                switchOff = false;
            }

            else if (switchOff == false)
            {
                theSwitch.turnOff();
                switchOff = true;
            }
        }
    }

        public void onSwitchTriggerEnter(Collider2D other)
    {
        Debug.Log("enabled");
        switchEnabled = true;
    }

    public void onSwitchTriggerExit(Collider2D other)
    {
        Debug.Log("disabled");
        switchEnabled = false;
    }
}
