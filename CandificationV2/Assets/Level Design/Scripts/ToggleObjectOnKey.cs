using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleObjectOnKey : MonoBehaviour
{
    public GameObject toggle;
    public KeyCode actionKey;

    private bool toggleOn = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(actionKey) && toggleOn == true)
        {
            toggle.SetActive(false);
            toggleOn = false;
        }
        else if (Input.GetKeyDown(actionKey) && toggleOn == false)
        {
            toggle.SetActive(true);
            toggleOn = true;
        }
    }
}
