using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {
    private GameObject Door;

    private void Start()
    {
        Door = gameObject;
    }

    public IEnumerator OpenCoroutine()
    {
        for (float f = 1f; f >= 0; f -= 0.1f)
        {
            Door.transform.Translate(0,0.2f,0);
            yield return new WaitForSeconds(0.05f);
        }
    }

    public IEnumerator CloseCoroutine()
    {
        for (float f = 1f; f >= 0; f -= 0.1f)
        {
            Door.transform.Translate(0,-0.2f, 0);
            yield return new WaitForSeconds(0.05f);
        }
    }
}
