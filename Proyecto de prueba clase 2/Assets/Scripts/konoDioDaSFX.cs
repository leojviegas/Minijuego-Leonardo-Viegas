using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class konoDioDaSFX : MonoBehaviour

{


    // Start is called before the first frame update
    void Start()
    {
    
    }
    void OnMouseDown()
    {
        GetComponent<AudioSource>().Play();
    }
    
    // Update is called once per frame
    void Update()
    {
       
    }
  
}
