using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowText_Axe : MonoBehaviour
{
    public GameObject UIObject_axe;
    public GameObject hastheaxe;                            // 
    private PickAxe pickaxe_script;                         // Load Key Script

    // Start is called before the first frame update
    void Start()
    {
        UIObject_axe.SetActive(false);                           // "key" message is hidden

    }

    void OnTriggerEnter(Collider other)                      // colliding with other object
    {
        pickaxe_script = hastheaxe.GetComponent<PickAxe>();  // aquires "hasthekey" value
        if (other.tag == "Player" && pickaxe_script.hastheaxe == false) // if other object is PLAYER + player does NOT have the key
        {
            UIObject_axe.SetActive(true);                         // show key message
        }
    }

    void OnTriggerExit(Collider other)
    {
        UIObject_axe.SetActive(false);
    }
}