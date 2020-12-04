using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poof : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(0,0,0,0);
            Destroy(gameObject);
        }
    }
}