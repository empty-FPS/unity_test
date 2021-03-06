﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboardtest : MonoBehaviour {

    [SerializeField]
    private float speed;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            Debug.Log("カメラ操作中");
        }
        else
        { 
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(0, 0, speed);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-speed, 0, 0);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(speed, 0, 0);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(0, 0, -speed);
            }
        }
	}
}
