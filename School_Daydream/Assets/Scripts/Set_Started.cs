using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set_Started : MonoBehaviour
{

    public GameObject retryInfo;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void Started()
    {
        retryInfo.GetComponent<Retry_Boss>().SetStarted();
    }

}
