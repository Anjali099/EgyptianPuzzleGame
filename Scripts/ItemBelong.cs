using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBelong : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        // if an object collides with the object attached to this script 
        //then find out if it is called cube and then make it a child of this cube and disable any not needed compoent of that object
       // cube = GameObject.Find("cube");

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "i1")
        {
            Debug.Log("right one");
            collision.gameObject.GetComponent<pickObjects>().rb.isKinematic = true;
            collision.gameObject.GetComponentInChildren<pickObjects>().rb = null;
            GameObject.Find("Cube").GetComponent<pickObjects>().enabled = false;
           
        }
        else {
            Debug.Log("not the right item");
        }

      
    }
    // how to lock the UI so the cross does not move


 
       


    }
//https://docs.unity3d.com/ScriptReference/GameObject.Find.html
//https://answers.unity.com/questions/632792/how-to-make-an-object-a-child-of-another-object-sc.html
//https://docs.unity3d.com/ScriptReference/Collider.OnTriggerEnter.html