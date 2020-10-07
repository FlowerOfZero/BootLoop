using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int loopCount = 1;
    public bool doorOpenInCurrentLoop;
    public touched t1, t2, t3, t4;
    public GameObject door;
    public Movement M;
    public GameObject L1, L2,L3,L4;
    public Text steptext;
    public GameObject stepObject;
    public int stepLimit;
    public int objectStepCount;
    public stepBox sb1,sb2,sb3,sb4,sb5,sb6;
    public EvilSquare ES, ES2;
    public GameObject timerObject;
    public Text timerText;
    public float currentTime = 60;
    public GameObject li1, li2, li3, li4;

    public AudioClip c1, c2, c3, c4, c5, c6, c7, c8, c9;
    public bool c2p, c3p, c4p, c5p, c6p, c7p, c8p, c9p;
    public AudioSource AudiSou;



    // Start is called before the first frame update
    void Start()
    {
        M = FindObjectOfType<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        if(doorOpenInCurrentLoop)
        {
            door.SetActive(false);
        }
        else if(M.stepCount > 1)
        {
            door.SetActive(true);
        }

        if(loopCount == 1)
        {
            doorOpenInCurrentLoop = true; 
        }

        if(loopCount == 2)
        {
            
            if (AudiSou.volume <= 0.1)
            {
                if (!c2p)
                {
                    c2p = true;
                    Debug.Log("Swapping Tracks");
                    AudiSou.clip = c2;
                    AudiSou.Play(); 
                }
                
            }
            else if (c1 == AudiSou.clip)
            {
                fadeOut(c1, AudiSou, c2);
            }
            

            if(c2p)
            {
                fadeIn(AudiSou);
            }
            

            t1.gameObject.SetActive(true);
            t2.gameObject.SetActive(true);
            if (t1.touch == true && t2.touch == true)
            {
                doorOpenInCurrentLoop = true;
            }
        }

        if (loopCount == 3)
        {
            t3.gameObject.SetActive(true);
            t4.gameObject.SetActive(true);
            if (t1.touch == true && t2.touch == true && t3.touch==true && t4.touch == true)
            {
                doorOpenInCurrentLoop = true;
            }
        }

        if(loopCount == 4)
        {
            stepObject.SetActive(true);
            stepLimit = 80;
            steptext.text = M.stepCount.ToString() + "/" + stepLimit.ToString() + "Steps";
            if(stepLimit <= M.stepCount)
            {
                M.playerReset();
            }

            if (t1.touch == true && t2.touch == true && t3.touch == true && t4.touch == true)
            {
                doorOpenInCurrentLoop = true;
            }
        }

        if(loopCount == 5)
        {
            if (AudiSou.volume <= 0.1)
            {
                if (!c3p)
                {
                    c3p = true;
                    Debug.Log("Swapping Tracks");
                    AudiSou.clip = c3;
                    AudiSou.Play();
                }

            }
            else if (c2 == AudiSou.clip)
            {
                fadeOut(c2, AudiSou, c3);
            }


            if (c3p)
            {
                fadeIn(AudiSou);
            }


            stepObject.SetActive(true);
            stepLimit = 80;
            steptext.text = M.stepCount.ToString() + "/" + stepLimit.ToString() + "Steps";
            li1.SetActive(true);
            li2.SetActive(true);

            if (stepLimit <= M.stepCount)
            {
                M.playerReset();
            }

            if (M.stepCount % 2 == 0)
            {
                L1.SetActive(true);
                L2.SetActive(true);

            }
            else
            {
                L1.SetActive(false);
                L2.SetActive(false);
            }

            if (t1.touch == true && t2.touch == true && t3.touch == true && t4.touch == true)
            {
                doorOpenInCurrentLoop = true;
            }
        }

        if(loopCount == 6)
        {
            

            stepObject.SetActive(true);
            sb1.gameObject.SetActive(true);
            sb2.gameObject.SetActive(true);
            sb3.gameObject.SetActive(true);
            sb4.gameObject.SetActive(true);
            stepLimit = 80;
            steptext.text = M.stepCount.ToString() + "/" + stepLimit.ToString() + "Steps";

            if (stepLimit <= M.stepCount)
            {
                M.playerReset();
            }

            if (M.stepCount % 2 == 0)
            {
                L1.SetActive(true);
                L2.SetActive(true);

            }
            else
            {
                L1.SetActive(false);
                L2.SetActive(false);
            }

            if (t1.touch == true && t2.touch == true && t3.touch == true && t4.touch == true)
            {
                doorOpenInCurrentLoop = true;
            }
        }

        if (loopCount == 7)
        {
            if (AudiSou.volume <= 0.1)
            {
                if (!c4p)
                {
                    c4p = true;
                    Debug.Log("Swapping Tracks");
                    AudiSou.clip = c4;
                    AudiSou.Play();
                }

            }
            else if (c3 == AudiSou.clip)
            {
                fadeOut(c3, AudiSou, c4);
            }


            if (c4p)
            {
                fadeIn(AudiSou);
            }



            li3.SetActive(true);
            li4.SetActive(true);
            stepLimit = 80;
            steptext.text = M.stepCount.ToString() + "/" + stepLimit.ToString() + "Steps";

            if (stepLimit <= M.stepCount)
            {
                M.playerReset();
            }

            if (M.stepCount % 2 == 0)
            {
                L1.SetActive(true);
                L2.SetActive(true);

            }
            else
            {
                L1.SetActive(false);
                L2.SetActive(false);
            }

            if (M.stepCount % 4 == 0)
            {
                L3.SetActive(true);
                L4.SetActive(true);

            }
            else
            {
                L3.SetActive(false);
                L4.SetActive(false);
            }


            if (t1.touch == true && t2.touch == true && t3.touch == true && t4.touch == true)
            {
                doorOpenInCurrentLoop = true;
            }
        }

        if (loopCount == 8)
        {
            if (AudiSou.volume <= 0.1)
            {
                if (!c5p)
                {
                    c5p = true;
                    Debug.Log("Swapping Tracks");
                    AudiSou.clip = c5;
                    AudiSou.Play();
                }

            }
            else if (c4 == AudiSou.clip)
            {
                fadeOut(c4, AudiSou, c5);
            }


            if (c5p)
            {
                fadeIn(AudiSou);
            }


            sb5.gameObject.SetActive(true);
            sb6.gameObject.SetActive(true);
            stepLimit = 80;
            steptext.text = M.stepCount.ToString() + "/" + stepLimit.ToString() + "Steps";

            if (stepLimit <= M.stepCount)
            {
                M.playerReset();
            }

            if (M.stepCount % 2 == 0)
            {
                L1.SetActive(true);
                L2.SetActive(true);

            }
            else
            {
                L1.SetActive(false);
                L2.SetActive(false);
            }

            if (M.stepCount % 4 == 0)
            {
                L3.SetActive(true);
                L4.SetActive(true);

            }
            else
            {
                L3.SetActive(false);
                L4.SetActive(false);
            }


            if (t1.touch == true && t2.touch == true && t3.touch == true && t4.touch == true)
            {
                doorOpenInCurrentLoop = true;
            }
        }

        if (loopCount == 9)
        {
            if (AudiSou.volume <= 0.1)
            {
                if (!c6p)
                {
                    c6p = true;
                    Debug.Log("Swapping Tracks");
                    AudiSou.clip = c6;
                    AudiSou.Play();
                }

            }
            else if (c5 == AudiSou.clip)
            {
                fadeOut(c5, AudiSou, c6);
            }


            if (c6p)
            {
                fadeIn(AudiSou);
            }



            t1.gameObject.SetActive(true);
            t2.gameObject.SetActive(true);
            t3.gameObject.SetActive(true);
            t4.gameObject.SetActive(true);
            stepObject.SetActive(true);
            sb1.gameObject.SetActive(true);
            sb2.gameObject.SetActive(true);
            sb3.gameObject.SetActive(true);
            sb4.gameObject.SetActive(true);
            sb5.gameObject.SetActive(true);
            sb6.gameObject.SetActive(true);
            ES.gameObject.SetActive(true);
            stepLimit = 80;
            steptext.text = M.stepCount.ToString() + "/" + stepLimit.ToString() + "Steps";

            if (stepLimit <= M.stepCount)
            {
                M.playerReset();
            }

            if (M.stepCount % 2 == 0)
            {
                L1.SetActive(true);
                L2.SetActive(true);

            }
            else
            {
                L1.SetActive(false);
                L2.SetActive(false);
            }

            if (M.stepCount % 4 == 0)
            {
                L3.SetActive(true);
                L4.SetActive(true);

            }
            else
            {
                L3.SetActive(false);
                L4.SetActive(false);
            }


            if (t1.touch == true && t2.touch == true && t3.touch == true && t4.touch == true)
            {
                doorOpenInCurrentLoop = true;
            }
        }

        if (loopCount == 10)
        {
            if (AudiSou.volume <= 0.1)
            {
                if (!c7p)
                {
                    c7p = true;
                    Debug.Log("Swapping Tracks");
                    AudiSou.clip = c7;
                    AudiSou.Play();
                }

            }
            else if (c6 == AudiSou.clip)
            {
                fadeOut(c6, AudiSou, c7);
            }


            if (c7p)
            {
                fadeIn(AudiSou);
            }



            t1.gameObject.SetActive(true);
            t2.gameObject.SetActive(true);
            t3.gameObject.SetActive(true);
            t4.gameObject.SetActive(true);
            stepObject.SetActive(true);
            sb1.gameObject.SetActive(true);
            sb2.gameObject.SetActive(true);
            sb3.gameObject.SetActive(true);
            sb4.gameObject.SetActive(true);
            sb5.gameObject.SetActive(true);
            sb6.gameObject.SetActive(true);
            ES.gameObject.SetActive(true);
            ES2.gameObject.SetActive(true);
            stepLimit = 80;
            steptext.text = M.stepCount.ToString() + "/" + stepLimit.ToString() + "Steps";

            if (stepLimit <= M.stepCount)
            {
                M.playerReset();
            }

            if (M.stepCount % 2 == 0)
            {
                L1.SetActive(true);
                L2.SetActive(true);

            }
            else
            {
                L1.SetActive(false);
                L2.SetActive(false);
            }

            if (M.stepCount % 4 == 0)
            {
                L3.SetActive(true);
                L4.SetActive(true);

            }
            else
            {
                L3.SetActive(false);
                L4.SetActive(false);
            }


            if (t1.touch == true && t2.touch == true && t3.touch == true && t4.touch == true)
            {
                doorOpenInCurrentLoop = true;
            }
        }

        if (loopCount == 11)
        {
            if (AudiSou.volume <= 0.1)
            {
                if (!c8p)
                {
                    c8p = true;
                    Debug.Log("Swapping Tracks");
                    AudiSou.clip = c8;
                    AudiSou.Play();
                }

            }
            else if (c7 == AudiSou.clip)
            {
                fadeOut(c7, AudiSou, c8);
            }


            if (c8p)
            {
                fadeIn(AudiSou);
            }



            if (M.stepCount >= 1)
            {
                currentTime -= Time.deltaTime;
                timerText.text = "Time Remaining: " + currentTime;

                if(currentTime <= 0)
                {
                    resetLoop();
                }
            }

            t1.gameObject.SetActive(true);
            t2.gameObject.SetActive(true);
            t3.gameObject.SetActive(true);
            t4.gameObject.SetActive(true);
            stepObject.SetActive(true);
            sb1.gameObject.SetActive(true);
            sb2.gameObject.SetActive(true);
            sb3.gameObject.SetActive(true);
            sb4.gameObject.SetActive(true);
            sb5.gameObject.SetActive(true);
            sb6.gameObject.SetActive(true);
            ES.gameObject.SetActive(true);

            ES2.gameObject.SetActive(true);
            timerObject.SetActive(true);

            stepLimit = 80;
            steptext.text = M.stepCount.ToString() + "/" + stepLimit.ToString() + "Steps";

            if (stepLimit <= M.stepCount)
            {
                M.playerReset();
            }

            if (M.stepCount % 2 == 0)
            {
                L1.SetActive(true);
                L2.SetActive(true);

            }
            else
            {
                L1.SetActive(false);
                L2.SetActive(false);
            }

            if (M.stepCount % 4 == 0)
            {
                L3.SetActive(true);
                L4.SetActive(true);

            }
            else
            {
                L3.SetActive(false);
                L4.SetActive(false);
            }


            if (t1.touch == true && t2.touch == true && t3.touch == true && t4.touch == true)
            {
                doorOpenInCurrentLoop = true;
            }
        }

        if(loopCount == 12)
        {
            if (AudiSou.volume <= 0.1)
            {
                if (!c9p)
                {
                    c9p = true;
                    Debug.Log("Swapping Tracks");
                    AudiSou.clip = c9;
                    AudiSou.Play();
                }

            }
            else if (c8 == AudiSou.clip)
            {
                fadeOut(c8, AudiSou, c9);
            }


            if (c9p)
            {
                fadeIn(AudiSou);
            }
            SceneManager.LoadScene(2);
        }

    }

    public void objectStep()
    {
        sb1.stepsRemaining -= 1;
        sb2.stepsRemaining -= 1;
        sb3.stepsRemaining -= 1;
        sb4.stepsRemaining -= 1;
        if(loopCount > 7)
        {
            sb5.stepsRemaining -= 1;
            sb6.stepsRemaining -= 1;
            ES.step();
            ES2.step();
        }
    }

    public void resetLoop()
    {
        doorOpenInCurrentLoop = false;
        t1.touch = false;
        t2.touch = false;
        t3.touch = false;
        t4.touch = false;
        M.stepCount = 0;
        sb1.stepsRemaining = sb1.defaultSteps;
        sb2.stepsRemaining = sb2.defaultSteps;
        sb3.stepsRemaining = sb3.defaultSteps;
        sb4.stepsRemaining = sb4.defaultSteps;
        sb5.stepsRemaining = sb5.defaultSteps;
        sb6.stepsRemaining = sb6.defaultSteps;
        ES.gameObject.transform.position = new Vector3(7,1,0);
        ES2.gameObject.transform.position = new Vector3(-7, -1, 0);
        currentTime = 60;
    }

    public void fadeIn(AudioSource AS)
    {
        if (AS.volume < 0.5)
        {
            Debug.Log("Fading in new song");
            AudiSou.volume += (float)0.1;// * Time.deltaTime add this if its too abrupt
        }
    }

    public void fadeOut(AudioClip AC, AudioSource AS, AudioClip Clip2)
    {
        if (AS.volume > 0.1 && AS.clip == AC)
        {
            AudiSou.volume -= (float)0.1;// * Time.deltaTime add this if its too abrupt
            Debug.Log("Fading out old song");
        }
      
    }
}
