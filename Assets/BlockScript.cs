﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        //衝突判定
        if(collision.gameObject.tag == "Ball")
        {
            Destroy(this.gameObject);
        }
    }
}
