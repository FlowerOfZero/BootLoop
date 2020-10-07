using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool loopComplete = false;
    public GameManager GM;
    public shadows edge;
    public int stepCount;
    public GameObject exitBox;
    
    // Start is called before the first frame update
    void Start()
    {
        GM = FindObjectOfType<GameManager>();
        edge = FindObjectOfType<shadows>();
    }


    // Update is called once per frame
    void Update()
    {

        if(stepCount > 1)
        {
            exitBox.SetActive(false);
        }

        if((GM.doorOpenInCurrentLoop) && (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && (gameObject.transform.position.y == 4 && gameObject.transform.position.x == 0))
        {
            Debug.Log("LoopComplete");
            loopComplete = true;
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1, gameObject.transform.position.z);
            edge.moveShadows(GM.loopCount - 1, stepCount, 0);
        }

        if(loopComplete)
        {
            gameObject.transform.position = new Vector3(0, -6, 0);
            GM.resetLoop();
            loopComplete = false;
            GM.loopCount += 1;
            stepCount = 0;
            edge.nextLoop();
            exitBox.SetActive(true);

        }

        if((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && gameObject.transform.position.y < 4)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1, gameObject.transform.position.z);
            gameObject.transform.rotation = Quaternion.Euler(0,0,0);
            stepCount += 1;
            GM.objectStep();
            edge.moveShadows(GM.loopCount - 1, stepCount, 0);
        }

        if ((Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) && (gameObject.transform.position.y >-4))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 1, gameObject.transform.position.z);
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 180);
            stepCount += 1;
            GM.objectStep();
            edge.moveShadows(GM.loopCount - 1, stepCount, 1);
        }

        if ((Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) && gameObject.transform.position.x < 8 && gameObject.transform.position.y != -5)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + 1, gameObject.transform.position.y, gameObject.transform.position.z);
            gameObject.transform.rotation = Quaternion.Euler(0, 0, -90); 
            stepCount += 1;
            GM.objectStep();
            edge.moveShadows(GM.loopCount - 1, stepCount, 2);
        }

        if ((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) && gameObject.transform.position.x > -8 && gameObject.transform.position.y != -5)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x-1, gameObject.transform.position.y, gameObject.transform.position.z);
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 90); 
            stepCount += 1;
            GM.objectStep();
            edge.moveShadows(GM.loopCount - 1, stepCount, 3);
        }
    }


    public void playerReset()
    {
        GM.resetLoop();
        gameObject.transform.position = new Vector3(0, -5, 0);
        stepCount = 0;
        edge.resetCurrent();
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Laser") && stepCount % 2 == 0)//this only works with the laser currently
        {
            playerReset();
            return;
        }

        if(col.CompareTag("BoxLaser"))
        {
            playerReset();
            return;
        }

    }
}
