using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol_Plus : MonoBehaviour
{
    public Transform pointAplus;
    public Transform pointBplus;
    public Transform pointCplus;
    public Transform pointDplus;
    public int location = 0;
    public float speedPlus = 0.3f;
    private Vector3 pointAPositionPlus;
    private Vector3 pointBPositionPlus;
    private Vector3 pointCPositionPlus;
    private Vector3 pointDPositionPlus;
    void Start()
    {
        pointAPositionPlus = new Vector3(pointAplus.position.x, pointAplus.position.y, 0);
        pointBPositionPlus = new Vector3(pointBplus.position.x, pointBplus.position.y, 0);
        pointCPositionPlus = new Vector3(pointCplus.position.x, pointCplus.position.y, 0);
        pointDPositionPlus = new Vector3(pointDplus.position.x, pointDplus.position.y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 thisPosition = new Vector3(transform.position.x, transform.position.y, 0);
        if (location == 0)
        {

            transform.position = Vector3.MoveTowards(transform.position, pointDplus.position, speedPlus);
            if (thisPosition.Equals(pointDPositionPlus))
            {
                //Debug.Log ("Position b");
                //isRight = false;
                //GetComponent<SpriteRenderer>().flipX = true;
                location++;
            }
        }
        else if (location == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, pointCplus.position, speedPlus);
            if (thisPosition.Equals(pointCPositionPlus))
            {
                //Debug.Log ("Position a");
                //isRight = true;
                //GetComponent<SpriteRenderer>().flipX = false;
                location++;
            }
        }
        else if (location == 2)
        {
            transform.position = Vector3.MoveTowards(transform.position, pointBplus.position, speedPlus);
            if (thisPosition.Equals(pointBPositionPlus))
            {
                //Debug.Log ("Position a");
                //isRight = true;
                //GetComponent<SpriteRenderer>().flipX = false;
                location++;
            }
        }
        else if (location == 3)
        {
            transform.position = Vector3.MoveTowards(transform.position, pointAplus.position, speedPlus);
            if (thisPosition.Equals(pointAPositionPlus))
            {
                //Debug.Log ("Position a");
                //isRight = true;
                //GetComponent<SpriteRenderer>().flipX = false;
                location = 0;
            }
        }
    }
}
