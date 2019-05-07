using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWeapons : MonoBehaviour
{

    public GameObject myBullet;
    public GameObject barrel;
    public LaserSiteControll lzerSight;
    public float speed;
    public float angle;
    public UFOController myUFO;
    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        myUFO = GetComponent<UFOController>();

    }

    // Update is called once per frame
    void Update()
    {
        ShootProjectile();
    }


    public void ShootProjectile()
    {
        //Rotate Laser
        Vector3 dir = Input.mousePosition -
    Camera.main.WorldToScreenPoint(transform.position);
        angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        barrel.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        //set laser endpoint
        dir = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dir.z = 0f;
        lzerSight.SetEnd(dir);

        //toggle laser
        if (Input.GetMouseButtonDown(1) || Input.GetKeyDown(KeyCode.Z))
        {

            lzerSight.ToggleLaser();

        }
        //shoot projectile
        if (Input.GetMouseButtonDown(0))
        {



            dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
            angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

            barrel.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            Instantiate(projectile, transform.position, barrel.transform.rotation);
        }
    }
}
