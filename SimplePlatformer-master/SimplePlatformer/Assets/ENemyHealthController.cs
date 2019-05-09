﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENemyHealthController : MonoBehaviour
{
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health <=0)
        {
            gameObject.transform.parent.gameObject.SetActive(false);    
        }
    }

    public void TakeDamage (int damage)
    {
        health = health - damage;
    }
}
