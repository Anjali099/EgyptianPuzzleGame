using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleRoom1 : MonoBehaviour
{
    //https://docs.unity3d.com/ScriptReference/Material.SetColor.html references for the report
    //https://www.youtube.com/watch?v=5OxmXaeAx2g

    //word pops up and then player would go to right symbol x3 and when done then mask 
    // Start is called before the first frame update
    [SerializeField] public GameObject[] Buttons;
    [SerializeField] public GameObject[] Text;
    [SerializeField] public Material[] ButtonMaterials;
    bool roundfinished;
    bool blockcompleted;
    bool block2completed;
    int numofrounds = 0;


    Renderer rend;
    Renderer rend1;
    Renderer rend2;
    Renderer rend3;

    Renderer textRend;
    public GameObject spawnpoint;

    public static bool room_one = true; // my bool

    void Start()
    {
        rend = Buttons[0].GetComponent<Renderer>();
        rend1 = Buttons[1].GetComponent<Renderer>();
        rend2 = Buttons[2].GetComponent<Renderer>();
        rend3 = Buttons[3].GetComponent<Renderer>();

        textRend = Text[0].GetComponent<Renderer>();


        //loadTextures();
        //textRend.material.color = Color.yellow;

        // setting it to true meaning the start of this script
    }

    // Update is called once per frame
    void Update()
    {
    
        if(blockcompleted == true) 
        {
            //resettextures();
            rend1.material.color = Color.green;
            
        }
        if (block2completed == true)
        {
            //resettextures();
            rend3.material.color = Color.green;
       
        }
        if (blockcompleted == true && block2completed == true) // once three rounds or sumeting is done then mask dropped
        {
           
            roundfinished = true;
            MaskDrop();
        }
    }
    void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject == Buttons[1])
        {

            Debug.Log("som");
            blockcompleted = true;
           
        }
        else if (collision.gameObject == Buttons[3])
        {

            Debug.Log("som2");
            block2completed = true;
      

        }
        else
        {
            Debug.Log("uh oh");
            resettextures();
        }
       
    
    }

    void loadTextures()
    {
        rend.material.SetColor("_Color", Random.ColorHSV());
        rend1.material.SetColor("_Color", Random.ColorHSV());
        rend2.material.SetColor("_Color", Random.ColorHSV());
        rend3.material.SetColor("_Color", Random.ColorHSV());
    }
    void resettextures()
    {
        rend.material.color = Color.red;
        rend1.material.color = Color.red;
        rend2.material.color = Color.red;
        rend3.material.color = Color.red;

      
        roundfinished = false;
        blockcompleted = false;
        block2completed = false;


    }
    void MaskDrop()
    {
        //Debug.Log("mask dropeed!");
        spawnpoint = GameObject.Find("Anubis");
        spawnpoint.GetComponent<Renderer>().enabled = true;
        
    }

}