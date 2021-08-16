 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    public static GM Instance { get; private set; }
    public GameObject mask;
    public GameObject player;
    private static GM GMOBJECT;
    private GameObject holder;
    //public Rigidbody rb;
    private GameObject playerholder;
  
    private void Awake()
    {

       playerholder = GameObject.Find("FirstPersonPlayer");
    
     

        holder = GameObject.Find("Anubis");
       holder.GetComponent<BoxCollider>().enabled = true;
        //holder.GetComponent<Rigidbody>().rb = true;

        if (PuzzleRoom1.room_one == true) // checking if my bool from puzzle1script is true and if it true then do that thing
        {
            mask.transform.parent = player.transform;
            Debug.Log("REEEEEEEEEEEEEEEEEE");
        }

        check();
    }

 

    public void check() {

        if (GMOBJECT != null && GMOBJECT != this) {
            Destroy(player);
            Destroy(mask);
        

        }

        else {
            GMOBJECT = this;
            DontDestroyOnLoad(player);
            DontDestroyOnLoad(mask);
         ;
        }
    }

}
