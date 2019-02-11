using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    public static LevelManager instance;

    public SwitchController theSwitch;
    public DoorController theDoor;

    public bool switchEnabled;
    public bool switchOff;

    public bool gotKey;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        gotKey = false;

        theSwitch.turnOff();
        switchOff = true;
    }

    public void flipTheSwitch()
    {
        if (switchEnabled && gotKey)
        {
            if (switchOff)
            {
                theSwitch.turnOn();
                StartCoroutine(theDoor.OpenCoroutine());
                switchOff = false;
            }

            else if (!switchOff)
            {
                theSwitch.turnOff();
                StartCoroutine(theDoor.CloseCoroutine());
                switchOff = true;
            }
        }
    }

        public void onSwitchTriggerEnter(Collider2D other)
    {
        switchEnabled = true;
    }

    public void onSwitchTriggerExit(Collider2D other)
    {
        switchEnabled = false;
    }
}
