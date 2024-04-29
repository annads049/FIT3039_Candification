using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOnExit : MonoBehaviour
{
    public GameObject activeZone;
    private Collider area;

    void Start()
    {
        area = activeZone.GetComponent<Collider>();
    }

    private void OnTriggerExit(Collider area)
    {
        activeZone.SetActive(false);
    }
}
