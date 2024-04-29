using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTextInArea : MonoBehaviour
{
    public Collider activeZone;
    public GameObject screenText;
    public string message;

    private Text text;

    // Start is called before the first frame update
    void Start()
    {
        activeZone = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider activeZone)
    {
        text = screenText.GetComponent<Text>();
        text.text = message;
        screenText.SetActive(true);
    }

    private void OnTriggerExit(Collider activeZone)
    {
        screenText.SetActive(false);
    }
}
