using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopStick : MonoBehaviour
{
    public GameObject player;
    public float distToGround = 1.0f;
    public LayerMask GroundLayer;
    // Start is called before the first frame update
    void Start()
    {
        player = this.gameObject;
    }

    public bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, distToGround, GroundLayer);
        if (hit.collider != null)
        {
            return true;
        }
        return false;

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!IsGrounded())
        {
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //player.GetComponent<Rigidbody2D>().
    }
}
