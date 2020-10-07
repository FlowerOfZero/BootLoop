using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stepBox : MonoBehaviour
{
    public GameManager GM;
    public Text text;
    public int stepsRemaining;
    public GameObject resetZone;
    public int defaultSteps;

    // Start is called before the first frame update
    void Start()
    {
        GM = FindObjectOfType<GameManager>();
        
    }

    // Update is called once per frame
    void Update()
    {


        if(stepsRemaining == 0)
        {
            resetZone.SetActive(true);
        }
        else
            resetZone.SetActive(false);

        if (stepsRemaining <= - 1)
        {
            
            stepsRemaining = defaultSteps;
        }

        text.text = stepsRemaining.ToString();
    }
}
