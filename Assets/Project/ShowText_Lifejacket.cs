using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowText_Lifejacket : MonoBehaviour
{
    public GameObject UIObject;
    public GameObject hasthejacket;                            // 
    private PickJacket pickjacket_script;                         // Load Key Script

    // Start is called before the first frame update
    void Start()
    {
        UIObject.SetActive(false);                           // "key" message is hidden

    }

    void OnTriggerEnter(Collider other)                      // colliding with other object
    {
        pickjacket_script = hasthejacket.GetComponent<PickJacket>();  // aquires "hasthekey" value
        if (other.tag == "Player" && pickjacket_script.hasthejacket == false) // if other object is PLAYER + player does NOT have the jacket yet
        {
            UIObject.SetActive(true);                         // show key message
        }
    }

    void OnTriggerExit(Collider other)
    {
        UIObject.SetActive(false);
    }
}