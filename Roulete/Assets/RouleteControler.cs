using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouleteControler : MonoBehaviour {

    // Use this for initialization

    float rotSpeed = 0;
    int i;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 20f;
            i = 0;
        }
        transform.Rotate(0, 0, rotSpeed);
        if(i == 90)
        {
            this.rotSpeed *= 0.985f;
        }
        else
        {
            i++;
        }
	}
}
