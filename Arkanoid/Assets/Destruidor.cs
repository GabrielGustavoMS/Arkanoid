using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruidor : MonoBehaviour {
	void OnCollisionEnter2D(Collision2D collision){

		GameObject collider = collision.collider.gameObject;
		GameObject.Destroy(collider);
	}
}
