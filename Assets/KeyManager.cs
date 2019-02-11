using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour {

    private GameObject Key;

    private void Start()
    {
        Key = gameObject;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        LevelManager.instance.gotKey = true;
        Destroy(Key);
    }
}
