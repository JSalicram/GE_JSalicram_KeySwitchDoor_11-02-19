using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour {

    private GameObject Key;

    private void Start()
    {
        Key = gameObject;
        Debug.Log("gotKey " + LevelManager.instance.gotKey);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        LevelManager.instance.gotKey = true;
        Debug.Log("gotKey " + LevelManager.instance.gotKey);
        Destroy(Key);
    }
}
