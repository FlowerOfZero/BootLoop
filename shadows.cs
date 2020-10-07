using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shadows : MonoBehaviour
{
    List<List<int>> shadowSteps;
    GameObject[] ss;
    public GameObject s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11;
    // Start is called before the first frame update
    void Start()
    {
        shadowSteps = new List<List<int>>();
        shadowSteps.Add(new List<int>());
        shadowSteps[0].Add(0);
        ss = new GameObject[11];
        ss[0] = s1; ss[1] = s2; ss[2] = s3;
        ss[3] = s4; ss[4] = s5; ss[5] = s6;
        ss[6] = s7; ss[7] = s8; ss[8] = s9;
        ss[9] = s10; ss[10] = s11;
    }


    public void nextLoop()
    {
        if (shadowSteps.Count > 1) {
            foreach (GameObject s in ss)
            {
                if (s.activeSelf)
                {
                    s.transform.position = new Vector3(0, -5, 0);
                }
            }
        }
        shadowSteps.Add(new List<int>());
    }

    public void resetCurrent()
    {
        shadowSteps[shadowSteps.Count-1].Clear();
        foreach(GameObject s in ss)
        {
            if (s.activeSelf)
            {
                s.transform.position = new Vector3(0, -5, 0);
            }
        }
    }

    public void moveShadows(int loop, int step, int move)
    {
        // This is where you store the movements
        shadowSteps[loop].Add(move);
        if (loop != 0)
        {
            int temp = 0;
            // This is the part where you move all the shadows
            if (step == 2)
            {
                // This is where we turn on the shadows
                ss[loop-1].SetActive(true);
            }
            else if(step > 2)
            {
                // This is where we move the shadows
                int i = 0;
                foreach(GameObject s in ss)
                {
                    if (s.activeSelf)
                    {
                        if (step - 1 < shadowSteps[i].Count) {
                            temp = shadowSteps[i][step - 2];
                            if (temp == 0) {
                                s.transform.position = new Vector3(s.transform.position.x, s.transform.position.y + 1, s.transform.position.z);
                                s.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                            } else if (temp == 1) {
                                s.transform.position = new Vector3(s.transform.position.x, s.transform.position.y - 1, s.transform.position.z);
                                s.gameObject.transform.rotation = Quaternion.Euler(0, 0, 180);
                            } else if (temp == 2) {
                                s.transform.position = new Vector3(s.transform.position.x + 1, s.transform.position.y, s.transform.position.z);
                                s.gameObject.transform.rotation = Quaternion.Euler(0, 0, -90);
                            } else if (temp == 3) {
                                s.transform.position = new Vector3(s.transform.position.x - 1, s.transform.position.y, s.transform.position.z);
                                s.gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                            }
                        }
                        else if(step == shadowSteps[i].Count - 1)
                        {
                            s.transform.position = new Vector3(s.transform.position.x, s.transform.position.y + 1, s.transform.position.z);
                        }
                    }
                    i++;
                }
            }
        }
        
    }
}
