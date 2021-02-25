using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
{
    public Animator anim;
    public GameObject player;
    public MissionComplete mission;
   // public bool isReady;
    bool isClose;

    /*public bool GetIsReady()
    {
        return isReady;
    }*/

    // Start is called before the first frame update
    void Start()
    {
        //isReady = false;
        isClose = false;
        anim.SetBool("isOpen", false);
    }

    // Update is called once per frame
    void Update()
    {
        bool intDown = Input.GetButtonDown("Interact");
        bool intHeld = Input.GetButton("Interact");
        bool intUp = Input.GetButtonUp("Interact");

        if (Vector3.Distance(player.transform.position, this.transform.position) < 5)
        {
            isClose = true;
        }
        else
        {
            isClose = false;
        }

        if ((intDown || intHeld) && (isClose == true))
        {
            anim.SetBool("isOpen", true);
            mission.missionComplete(true);
           // isReady = true;
        }
        
        if (intUp)
        {
            //isReady = false;
            anim.SetBool("isOpen", false);
        }

    }
}
