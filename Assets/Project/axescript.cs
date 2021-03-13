using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class axescript : MonoBehaviour
{
    public Component plantdestroyerhere;
    public GameObject axegone;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E))
            axegone.SetActive(false);

        if (Input.GetKey(KeyCode.E))
            plantdestroyerhere.GetComponent<BoxCollider>().enabled = false;




    }
}
