using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickAxe : MonoBehaviour
{
    public Component plantdestroyerhere;
    public GameObject axegone;
    public bool hastheaxe;
    // Start is called before the first frame update
    void Start()
    {
        hastheaxe = false;                                                  // player does NOT have an axe
    }

    // Update is called once per frame
    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E))
        {
            axegone.SetActive(false);
            plantdestroyerhere.GetComponent<BoxCollider>().enabled = false;
            hastheaxe = true;
        }
    }
}
