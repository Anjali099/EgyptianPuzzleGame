using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMaskPuzzle : MonoBehaviour
{
    // Start is called before the first frame update
    // number of mask int
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "p1")
        {
            Debug.Log("right object :P");
            collision.gameObject.GetComponent<pickObjects>().rb.isKinematic = true;
            //number of mask ++
        }
        else
        {
            Debug.Log("wrong one!! ");

        };
       
    }

    // Update is called once per frame
    void Update()
    {
        // when masknumber == 4 or whatever then leave the room 

    }
}
