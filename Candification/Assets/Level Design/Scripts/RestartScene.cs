using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartScene : MonoBehaviour
{
public KeyCode captureKey = KeyCode.R;
    // Start is called before the first frame update
    void Start()
{
 }
 void Update()
     {
         if (Input.GetKeyDown(captureKey))
         {
             Application.LoadLevel(0);
         }
     }
 }
