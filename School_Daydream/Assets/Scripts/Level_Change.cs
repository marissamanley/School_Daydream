using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Make sure to add this, or you can't use SceneManager
using UnityEngine.SceneManagement;


public class Level_Change : MonoBehaviour
{

    public GameObject started;
    void OnTriggerEnter2D(Collider2D other)
    {
        //other.name should equal the root of your Player object
        if (other.name == "Player")
        {
            started.GetComponent<Set_Started>().Started();
            SceneManager.LoadScene(2);
        }
    }
}