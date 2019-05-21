using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthControl : MonoBehaviour
{
    public int health;
    public string levelToLoad;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            // gameObject.transform.parent.gameObject.SetActive(false);
            SceneManager.LoadScene(levelToLoad);
        }
    }

    public void TakeDamage(int damage)
    {
        health = health - damage;
    }
}
