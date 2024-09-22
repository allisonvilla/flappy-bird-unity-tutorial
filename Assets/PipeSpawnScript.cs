using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(pipe, transform.position, transform.rotation);
        // transform.position and transform.rotation get the values of the object holding the script
        // therefore we're making it so that the game object 
    }
}
