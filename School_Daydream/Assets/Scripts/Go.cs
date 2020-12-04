using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Go : MonoBehaviour
{
    public GameManager GameManager;
    // Start is called before the first frame update
    public void proceed()
    {
        GameManager.hasStarted = true;
    }
}
