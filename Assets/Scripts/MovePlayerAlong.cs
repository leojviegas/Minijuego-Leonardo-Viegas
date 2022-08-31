using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerAlong : MonoBehaviour
{
    public GameObject player;
    public GameObject movingPlatform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        player.transform.SetParent(movingPlatform.transform, true);
    }
    void Update()
    {
        
    }
}
