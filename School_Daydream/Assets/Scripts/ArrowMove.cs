using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMove : MonoBehaviour
{
    public float tempo;
    public GameManager GameManager;
    // Start is called before the first frame update
    void Start()
    {
        tempo = tempo / 60f;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.hasStarted == true) 
        {
            transform.position += new Vector3(0f, tempo * Time.deltaTime, 0f);
        }
    }
}
