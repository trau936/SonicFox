using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalcontrol : MonoBehaviour
{
    public float myTime;
    private float mycounter;
    public bool countdown;
    public Transform otherPortal;
    // Start is called before the first frame update
    void Start()
    {
        mycounter = myTime;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            // countdown = true;
            // Debug.Log("teleport");
            if (Input.GetKeyDown(KeyCode.E))
            {
                other.transform.position = otherPortal.position;
            }

        }
    }
    void OnTriggerExit2D(Collider2D other)
    {

    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                other.transform.position = otherPortal.position;
            }
        }
    }

}

