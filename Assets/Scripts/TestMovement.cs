using UnityEngine;
using System.Collections;

public class TestMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 newPosition = transform.position;
        newPosition.x += Time.deltaTime * Input.GetAxis("Horizontal");
        newPosition.y += Time.deltaTime * Input.GetAxis("Vertical");
        transform.position = newPosition;

    }
}
