using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadRotation : MonoBehaviour {

	// Use this for initialization
    // Line 10 enables gyro
	void Start () {
        Input.gyro.enabled = true;
	}
	// Line 16 stores rotation data from gyro
    // Line 17 ensures rotation matches head movements by flipping gyro rotation about the z-axis and then rotate around x-axis
	// Update is called once per frame
	void Update () {
        Quaternion att = Input.gyro.attitude;
        att = Quaternion.Euler(90f, 0f, 0f) * new Quaternion(att.x, att.y, -att.z, -att.w);
        transform.rotation = att; //this assigns rotation to camera
	}
}
