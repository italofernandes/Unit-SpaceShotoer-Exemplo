using UnityEngine;
using System.Collections;

public class RamdonRotator : MonoBehaviour {
	public float tumble;

	void Start(){
		rigidbody.angularVelocity = Random.insideUnitSphere * tumble;	
	
	}
}
