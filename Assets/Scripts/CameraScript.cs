using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    bool animation = true;
    Vector3 offset = new Vector3(0, 0.9f, 0);
    [SerializeField] GameObject player;

    void Awake()
    {
        
    }

    void Update()
    {
        if(!animation)
            this.transform.position = new Vector3(0, player.transform.position.y + offset.y, 0);
    }
}
