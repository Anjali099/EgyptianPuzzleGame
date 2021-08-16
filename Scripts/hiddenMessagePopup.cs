using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class hiddenMessagePopup : MonoBehaviour
{
    [SerializeField] private Text hiddenMessage;
    // Start is called before the first frame update
    private void OnMouseDown()
    {

        hiddenMessage.enabled = true; // shows cross when picked up

    }

    private void OnMouseUp()
    {

        hiddenMessage.enabled = false; // cross is gone uh oh 

    }
}
