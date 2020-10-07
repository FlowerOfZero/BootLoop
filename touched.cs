using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touched : MonoBehaviour
{
    public bool touch = false;

    public void Update()
    {
        if(touch == true)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        }

        if (touch == false)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
        }
    }


    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            touch = true;
        }
    }
}
