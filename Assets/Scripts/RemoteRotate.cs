using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoteRotate : MonoBehaviour {
    [SerializeField]
    private int mRotation;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.LeftControl))
        {
            Debug.Log("OK");
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Rotate(mRotation, 0, 0);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(0, -mRotation, 0);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(0, mRotation, 0);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Rotate(-mRotation, 0, 0);
            }
        }
        else
        {
            Debug.Log("歩行操作中");
        }
	}
}
