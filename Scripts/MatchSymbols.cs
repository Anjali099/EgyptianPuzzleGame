using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MatchSymbols : MonoBehaviour
{
    //https://forum.unity.com/threads/array-image-to-ui.483136/
    //two arrays one for the one the player presses and another for the one we see
    // then we would check both these arrays and lets if index (whee they are in the array) or somethi else mathes then progress to the next
    // x3
    // Start is called before the first frame update
    [SerializeField] public Texture[] ImagesQuestion;
    [SerializeField] public Material[] PlayerImages;
    [SerializeField] public GameObject[] PlayerStand;

    [SerializeField] public int NumberofRounnd; // how many times we are going through this 

    private GameObject ImageQuestionCube;
    public GameObject[] EnterCollider = new GameObject[0];
    public GameObject Mask;
    public static bool room_two = true; // my bool


    void Start()
    {
       LoadWordTexture();
       RandomTexture();
    }

    

    private void OnTriggerEnter(Collider other)
      {
           if (other.material.name == "ankhtext") {
            // if the player collided with a material equal to....
              Debug.Log("good");

          }
          else {
              Debug.Log("not good");
            
         } 
      } 

    // Update is called once per frame
    void Update()// checks if the player picks the correcr awnser or not aala's comment
    {
        //goes through both arrays  
        for (int i = 0; i <= ImagesQuestion.Length; i++)
        {
            for (int j = 0; j <= PlayerImages.Length; j++)
            {
                if (ImagesQuestion[0] != PlayerImages[0]) // if the index of wall and player images match like i dunno 1==1 then move onto next round
                {
                    //Debug.Log("wrong");
                    // round++
                }
            }

        }
        if (NumberofRounnd == 3)
        {

            MaskDrop();

        }

    }

     public void RandomTexture() //function to randomaize the textures 
    {

        //Simple way: create int array for indicate assign material
        //
        int[]indMat = new int[PlayerImages.Length];//the lengh of playerimage is set to indMat
        for (int i = 0; i < PlayerImages.Length; i++)
        {
            indMat[i] = 0; //not assign material
            
        }

        foreach (GameObject stand in PlayerStand)
        {
            //stand.GetComponent<Renderer>() = PlayerImages[Random.Range(0, PlayerImages.Length)];
            //see all objects
          //Assign random material to object
        
            int num = Random.Range(0, PlayerImages.Length);//num is the random number to pick a random image

            //already apply, find next
            while (indMat[num] != 0)
            {
                num++;  // find another image??
                if (num >= PlayerImages.Length)// image greater than or equal to player image
                {
                    num = 0; //num is equal to zero
                }
            }
            indMat[num] = 1; 
            //assign material to all the pads
            stand.GetComponent<Renderer>().sharedMaterial = PlayerImages[num];
         
            
        }
    }
    void LoadWordTexture()
    {
        ImageQuestionCube = GameObject.Find("ImageQuestion");// finds this game object on the hier and sets it to this gameobject varaible
        ImageQuestionCube.GetComponent<Renderer>().material.mainTexture = ImagesQuestion[0];// gets that gameobject and sets the first texture on ImageQuestion


    }
    void MaskDrop()
    {
        Debug.Log("mask dropeed!");
    }
}









