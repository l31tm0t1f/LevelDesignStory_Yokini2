using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver_Script : MonoBehaviour
{
    public GameObject UIObject;
    // Start is called before the first frame update
    void Start()
    {
        UIObject.SetActive(false);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            UIObject.SetActive(true);

        }
    }

    void OnTriggerExit(Collider other)
    {
        Application.Quit();
    }
}



