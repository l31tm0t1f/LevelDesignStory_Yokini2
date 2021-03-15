using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowText_Keys : MonoBehaviour
{
    public GameObject UIObject_key;
    public GameObject hasthekey;                            // 
    private PickKey pickkey_script;                         // Load Key Script

    // Start is called before the first frame update
    void Start()
    {
        UIObject_key.SetActive(false);                           // "key" message is hidden

    }

    void OnTriggerEnter(Collider other)                      // colliding with other object
    {
        pickkey_script = hasthekey.GetComponent<PickKey>();  // aquires "hasthekey" value
        if (other.tag == "Player" && pickkey_script.hasthekey == false) // if other object is PLAYER + player does NOT have the key
        {
            UIObject_key.SetActive(true);                         // show key message
        }
    }

    void OnTriggerExit(Collider other)
    {
        UIObject_key.SetActive(false);
    }
}