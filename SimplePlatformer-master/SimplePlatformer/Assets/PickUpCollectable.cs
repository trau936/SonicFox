﻿using UnityEngine;

public class PickUpCollectable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player") 
        {
            Destroy(gameObject);
            //Playsound
        }
    }




}
