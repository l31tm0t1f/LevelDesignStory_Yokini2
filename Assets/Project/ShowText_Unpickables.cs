using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowText_Unpickables : MonoBehaviour
{
    public GameObject UIObject;

    // Start is called before the first frame update
    void Start()
    {
        UIObject.SetActive(false);                           // "key" message is hidden

    }

    void OnTriggerEnter(Collider other)                      // colliding with other object
    {
        if (other.tag == "Player")                           // if other object is PLAYER
        {
            UIObject.SetActive(true);                         // show key message
        }
    }

    void OnTriggerExit(Collider other)
    {
        UIObject.SetActive(false);
    }
}