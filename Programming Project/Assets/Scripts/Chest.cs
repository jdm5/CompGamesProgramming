using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{

    public Animator anim;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        anim.SetBool("isOpen", false);
    }

    // Update is called once per frame
    void Update()
    {
       /* if (player.GetComponent<OpenChest>().GetIsReady())
        {
            anim.SetBool("isOpen", true);
        }
        else
        {
            anim.SetBool("isOpen", false);
        }*/
    }
}
