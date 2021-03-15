using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowText_Door : MonoBehaviour
{
    public GameObject UIObject_door1;                                 // Text before finding the key
    public GameObject UIObject_door2;                                // Text after finding the key
    public GameObject doorisopen;                               // boolean for opendoor detection
    public GameObject hasthekey;                                // boolean for key ownership
    private OpenDoor opendoor_script;                           // OpenDoor script
    private PickKey pickkey_script;                             // Load Key Script

    // Start is called before the first frame update
    void Start()
    {
        UIObject_door1.SetActive(false);
        UIObject_door2.SetActive(false);
        opendoor_script = doorisopen.GetComponent<OpenDoor>();  // get doorisopenvalue
        pickkey_script = hasthekey.GetComponent<PickKey>();     // get hasthekey value
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag== "Player" && pickkey_script.hasthekey == false) 
            // if other object is PLAYER + player does NOT have the key
        {
            UIObject_door1.SetActive(true);
        }
       
        if (other.tag == "Player" && pickkey_script.hasthekey == true) 
            // if other object is PLAYER + player does NOT have the key
        {
            UIObject_door2.SetActive(true);
        }



        if (other.tag == "Player" && opendoor_script.doorisopen == true) // if other object is PLAYER + door is already opened
        {
            UIObject_door1.SetActive(false);
            UIObject_door2.SetActive(false);
        }

    }


    void OnTriggerExit(Collider other)
    {
            UIObject_door1.SetActive(false);
            UIObject_door2.SetActive(false);
    }
}