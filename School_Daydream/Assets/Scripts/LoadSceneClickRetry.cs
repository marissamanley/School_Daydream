using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneClickRetry : MonoBehaviour
{
    public GameObject retryInfo;

    public void LoadByIndex(int sceneIndex)
    {
        if (retryInfo.GetComponent<Retry_Boss>().GetRetries() > 0)
        {
            retryInfo.GetComponent<Retry_Boss>().SetRetries(retryInfo.GetComponent<Retry_Boss>().GetRetries()-1);
            SceneManager.LoadScene(sceneIndex);
        }
        else
        {
            retryInfo.GetComponent<Retry_Boss>().SetStarted();
            SceneManager.LoadScene(1);
        }
    }
}
