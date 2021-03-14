using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowText_Boat : MonoBehaviour
{
    public GameObject UIObject;                                 // Text before finding the key
    public GameObject UIObject2;                                // Text after finding the key
    public GameObject boatopenerhere;                          // boolean for "can you enter the boat" detection
    public GameObject hasthejacket;                                // boolean for key ownership
    private OpenBoat openboat_script;                           // OpenDoor script
    private PickJacket pickjacket_script;                             // Load Key Script

    // Start is called before the first frame update
    void Start()
    {
        UIObject.SetActive(false);
        UIObject2.SetActive(false);
        openboat_script = boatopenerhere.GetComponent<OpenBoat>();  // get "boat is open" value
        pickjacket_script = hasthejacket.GetComponent<PickJacket>();     // get hasthekey value
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && pickjacket_script.hasthejacket == false)
        // if other object is PLAYER + player does NOT have the key
        {
            UIObject.SetActive(true);
        }

        if (other.tag == "Player" && pickjacket_script.hasthejacket == true)
        // if other object is PLAYER + player have the key
        {
            UIObject2.SetActive(true);
        }


        //if (other.tag == "Player" && openboat_script.boatopenerhere == true) // if other object is PLAYER + boat is opened
        //{
        //    UIObject.SetActive(false);
        //    UIObject2.SetActive(false); // WINNING CONDITION HERE
        //}

    }


    void OnTriggerExit(Collider other)
    {
        UIObject.SetActive(false);
        UIObject2.SetActive(false);
    }
}