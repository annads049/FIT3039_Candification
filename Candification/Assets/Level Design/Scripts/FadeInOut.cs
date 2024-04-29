using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class FadeInOut : MonoBehaviour
{

    public GameObject screenFade;
    public GameObject activeZone;

    private Collider trigger;
    private PlayableDirector end;
    private bool gameOver = false;

    private void Start()
    {
        trigger = activeZone.GetComponent<Collider>();
        end = screenFade.GetComponent<PlayableDirector>();
    }

        private void OnTriggerEnter(Collider trigger)
    {
        if(trigger.gameObject.tag == "Player")
        {
            StartCoroutine(exitTimeline());
        }
    }

    private IEnumerator exitTimeline()
    {
        end.Play();
        yield return new WaitForSeconds((float)end.duration);
        gameOver = true;
    }

    private void Update()
    {
        if(gameOver == true)
        {
            Application.Quit();
        }
    }
}
