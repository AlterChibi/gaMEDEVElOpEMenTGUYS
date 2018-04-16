using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuadTest : MonoBehaviour {

    private float collide = 0;

    private void Start()
    {
        
    }
    private void Update()
    {
        
    }
    private void OnGUI()
    {
        if (collide==2) {
            GUI.Label(new Rect(750, 300, 100, 20), "sample text");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collide = 1;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        collide = 2;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        collide = 3;
    }
}
