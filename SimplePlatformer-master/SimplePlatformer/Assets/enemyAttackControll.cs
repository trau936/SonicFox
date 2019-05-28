using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAttackControll : MonoBehaviour
{

    public Color rayColor = Color.red;
    public float attackRange;
    public GameObject thePlayer;
    public GameObject badGuyBullet;
    public float attackTime=1;
    private float attackTimmer;
    // Start is called before the first frame update
    void Start()
    {
        thePlayer = GameObject.FindWithTag("Player");
        attackTimmer = attackTime;
    }

    // Update is called once per frame
    void Update()
    {
        if ((thePlayer.transform.position - transform.position).magnitude <= attackRange)
        {
            attackTimmer = attackTimmer - Time.deltaTime;

            if (attackTimmer <= 0)
            { 
                //shoot at the player
                Vector3 playerDir = thePlayer.transform.position - transform.position;
                float angle = Mathf.Atan2(playerDir.y, playerDir.x) * Mathf.Rad2Deg;
                Instantiate(badGuyBullet, transform.position, Quaternion.AngleAxis(angle, Vector3.forward));
                attackTimmer = attackTime;
             }
        }

    }

    void OnDrawGizmos()
    {
        Gizmos.color = rayColor;

        Gizmos.DrawWireSphere(transform.position, attackRange);
    }
}
