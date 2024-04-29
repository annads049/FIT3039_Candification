using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineOnKey : MonoBehaviour
{
 
    public GameObject viewTarget;
    public GameObject timelineOpen;
    public GameObject timelineClose;
    public float maxRayDistance = 2.0f;
    public KeyCode interactionKey;
    public GameObject cursorDefault;
    public GameObject cursorActive;

    private PlayableDirector timeline1;
    private PlayableDirector timeline2;
    private Collider target;
    private bool chestOpen = false;

    [SerializeField] private int layer = 7;
    private int layerAsLayerMask;
    
    // Instantiating objects and components
    void Start()
    {
        target = viewTarget.GetComponent<Collider>();
        timeline1 = timelineOpen.GetComponent<PlayableDirector>();
        timeline2 = timelineClose.GetComponent<PlayableDirector>();
        layerAsLayerMask = (1 << layer);
    }

    private void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, maxRayDistance, layerAsLayerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            cursorActive.SetActive(true);
            cursorDefault.SetActive(false);
            if (Input.GetKeyDown(interactionKey) && chestOpen == false) 
            {
                timeline1.Play();
                chestOpen = true;
                //Debug.Log(chestOpen);
            }
            else if (Input.GetKeyDown(interactionKey) && chestOpen == true)
            {
                timeline2.Play();
                chestOpen = false;
                //Debug.Log(chestOpen);
            }
        }

        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 10, Color.red);
            cursorActive.SetActive(false);
            cursorDefault.SetActive(true);
        }
    }

}
