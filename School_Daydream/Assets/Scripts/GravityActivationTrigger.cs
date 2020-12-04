using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityActivationTrigger : MonoBehaviour
{

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Parachute"))
        {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 0.1f;
            gameObject.GetComponent<Animator>().SetBool("IsParachuting", true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Parachute"))
        {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 1f;
            gameObject.GetComponent<Animator>().SetBool("IsParachuting", false);
        }
    

    }
}
