using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    public int strikes;
    public static GameManager instance;
    public GameObject screen;
    public bool hasStarted = false;
    public int arrowNum = 19;
    public int points;

    public Text strikeText;
    public Text infoText;
    public GameObject whiteBr;
    public GameObject CoinAccess;
    public Button go;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());
        instance = this;
        points = CoinAccess.GetComponent<Player_Health_Segmented>().GetScore();
        strikes = 5;
        strikeText.text = "Lives: " + strikes;
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(4);
        infoText.gameObject.SetActive(true);
        go.gameObject.SetActive(true);
        whiteBr.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (hasStarted == true)
        {
            infoText.gameObject.SetActive(false);
            go.gameObject.SetActive(false);
            whiteBr.SetActive(false);
            StartCoroutine(WinWait());
        }

        if (strikes == 0)
        {
            SceneManager.LoadScene(3);
        }


    }

    IEnumerator WinWait()
    {
        yield return new WaitForSeconds(22);
        if (strikes != 0)
            SceneManager.LoadScene(4);
    }

    public void NoteHit()
    {

    }

    public void NoteMissed()
    {
        strikes--;
        arrowNum--;
        strikeText.text = "Lives: " + strikes;
    }
}
