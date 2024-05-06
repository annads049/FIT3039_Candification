using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerTimeline : MonoBehaviour
{
    private PlayableDirector timelineOpen;
    private PlayableDirector timelineClose;
    public Collider triggerArea;
    public GameObject timelineEnter;
    public GameObject timelineExit;

    // Start is called before the first frame update
    void Start()
    {
        timelineOpen = timelineEnter.GetComponent<PlayableDirector>();
        timelineClose = timelineExit.GetComponent<PlayableDirector>();
        triggerArea = GetComponent<Collider>();
    }

    void OnTriggerEnter(Collider triggerArea)
    {
        if (triggerArea.gameObject.tag == "Player")
        {
            timelineOpen.Play();
        }
    }

    void OnTriggerExit(Collider triggerArea)
    {
        if (triggerArea.gameObject.tag == "Player")
        {
            timelineClose.Play();
        }
    }
}
