using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePatrol : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GetComponent<Patrol>().activated = true;
        }
    }
}
