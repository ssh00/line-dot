using UnityEngine;
using System.Collections;

public class camera_movement : MonoBehaviour {
	public GameObject targetl;
	public float xOffset = 0;
	public float yOffset = 0;
	public float zOffset = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
		this.transform.position = new Vector3(targetl.transform.position.x + xOffset,
		                                      targetl.transform.position.y + yOffset,
		                                      targetl.transform.position.z + zOffset);
	}
}
