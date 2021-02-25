using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionComplete : MonoBehaviour
{
    
    public Gradient gradient;
    public Image fill;
    bool missComplete = false;

    public bool isComplete()
    {
        return missComplete;
    }

    public void missionComplete(bool isComplete)
    {
        if (isComplete)
        {
            fill.color = gradient.Evaluate(1f);
            missComplete = true;
        }
    }


}
