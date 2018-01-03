using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject followTarget;
    private Vector3 targetPos;
    public float moveSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        targetPos = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z); //Assign position of target (the GameObject) to targetPos
        transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime); //Moves from point A to point B with a speed. Lerp(Vector3 A, Vector3 B, Float Speed)
	}
}
