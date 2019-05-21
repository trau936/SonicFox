using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBadGuyBullet : MonoBehaviour
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
            //

        }
        else if (other.tag == "Player")
        {
            //make player take damage
            other.GetComponent<PlayerHealthControl>().TakeDamage(bulletDamage);
            Destroy(gameObject);

            //Playsound
        }

    }
}


