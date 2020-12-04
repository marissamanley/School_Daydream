using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowTouched : MonoBehaviour
{
    
    public bool canBeTouched;
    public KeyCode keyToPress;
    public AudioClip ouch;
    public AudioClip yay;
    public bool touched = false;
    public bool hit = false;
    public GameManager GameManager;
    public GameObject screen;
    public GameObject talkBubble;
    public Sprite talkBub;
    public Sprite talkBubMiss;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            if (canBeTouched)
            {
                hit = true;
                AudioSource.PlayClipAtPoint(yay, transform.position);
                gameObject.SetActive(false);
                GameManager.arrowNum--;
                GameManager.instance.NoteHit();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Activator" && touched == false)
        {
            canBeTouched = true;
            touched = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Activator" && touched == true && hit != true)
        {
            canBeTouched = false;
            touched = false;
            AudioSource.PlayClipAtPoint(ouch, transform.position);
            screen.GetComponent<Animator>().SetBool("Missed", true);
            talkBubble.GetComponent<SpriteRenderer>().sprite = talkBubMiss;
            GameManager.instance.NoteMissed();
            StartCoroutine(AnimWait());


        }
    }

    IEnumerator AnimWait()
    {
        yield return new WaitForSeconds(0.4f);
        screen.GetComponent<Animator>().SetBool("Missed", false);
        talkBubble.GetComponent<SpriteRenderer>().sprite = talkBub;
    }
}
