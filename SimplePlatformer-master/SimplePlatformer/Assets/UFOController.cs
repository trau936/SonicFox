using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOController : MonoBehaviour {

    //Add Variables here
    public float movementSpeed;
    public Rigidbody2D theRB2D;


	// Use this for initialization
	void Start () {
        theRB2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        //Add Movement Code Here

        theRB2D.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"))*movementSpeed;

    }
}
