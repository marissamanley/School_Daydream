using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Retry_Boss : MonoBehaviour
{
    public GameObject CoinAccess;
    public int points;
    static public int retries;
    static public bool started;
    public Text retryInfo;
    public Text coinInfo;
    // Start is called before the first frame update
    void Start()
    {
        points = CoinAccess.GetComponent<Player_Health_Segmented>().GetScore();
        if(started)
            retries = points / 10;
        started = false;
        coinInfo.text = "Coins: " + points;
        retryInfo.text = "Retry #: " + retries; 
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SetRetries(int tretries)
    {
        retries = tretries;
    }

    public int GetRetries()
    {
        return retries;
    }

    public void SetStarted()
    {
        started = true;
    }

    public bool GetStarted()
    {
        return started;
    }
}
