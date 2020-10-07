using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilSquare : MonoBehaviour
{
    public bool movingRight;
    public GameObject laser;

    public void step()
    {
        if(movingRight)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + 1, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        else
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x - 1, gameObject.transform.position.y, gameObject.transform.position.z);
        }

        if (gameObject.transform.position.x >= 8)
        {
            movingRight = false;
        }
        else if(gameObject.transform.position.x <= -8)
        {
            movingRight = true;
        }

        laser.SetActive(false);
    }
    
    public void OnTriggerStay2D(Collider2D col)
    {
        if(col.CompareTag("Laser"))
        {
            laser.SetActive(true);
        }
    }
}
