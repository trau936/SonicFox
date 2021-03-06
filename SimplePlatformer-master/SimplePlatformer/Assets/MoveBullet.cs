﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody2D theRB2D;
    public int bulletDamage;


    // Start is called before the first frame update
    void Start()
    {
        theRB2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        theRB2D.velocity = transform.right * movementSpeed;
    }

    void OnBeameInvisible()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            other.GetComponent<ENemyHealthController>().TakeDamage(bulletDamage);
            Destroy(gameObject);

        }
        else if (other.tag == "EnemyBullet")
        { 

        }
        else if (other.tag == "Destructable")
        {
            other.GetComponent<DestructableBlock>().TakeDamage(bulletDamage);
            Destroy(gameObject);

        }
        else if (other.tag != "Player")
        {
            Destroy(gameObject);
            //Playsound
        }
       
    }
}
