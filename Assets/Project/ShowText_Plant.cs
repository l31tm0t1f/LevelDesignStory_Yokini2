using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowText_Plant : MonoBehaviour
{
    public GameObject UIObject;                                 // Text before finding the key
    public GameObject UIObject2;                                // Text after finding the key
    public GameObject doorisopen;                               // boolean for opendoor detection
    public GameObject hastheaxe;                                // boolean for key ownership
    private OpenDoor opendoor_script;                           // OpenDoor script
    private PickAxe pickaxe_script;                             // Load Key Script

    // Start is called before the first frame update
    void Start()
    {
        UIObject.SetActive(false);
        UIObject2.SetActive(false);
        opendoor_script = doorisopen.GetComponent<OpenDoor>();  // get doorisopenvalue
        pickaxe_script = hastheaxe.GetComponent<PickAxe>();     // get hasthekey value
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && pickaxe_script.hastheaxe == false)
        // if other object is PLAYER + player does NOT have the axe
        {
            UIObject.SetActive(true);
        }

        if (other.tag == "Player" && pickaxe_script.hastheaxe == true)
        // if other object is PLAYER + player have the axe
        {
            UIObject2.SetActive(true);
        }

    }


    void OnTriggerExit(Collider other)
    {
        UIObject.SetActive(false);
        UIObject2.SetActive(false);
    }
}