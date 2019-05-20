using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MyLoadLevel : MonoBehaviour
{

    public string leveToLoad;
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
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(leveToLoad);
        }
    }

    public void LoadALevel(string level)
    {
        SceneManager.LoadScene(level);
    }
}
