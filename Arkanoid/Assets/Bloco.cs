using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour {

	public Rigidbody2D rigidbody;	
	public BoxCollider2D collider;

	// Use this for initialization
	void Start () {

		rigidbody = GetComponent<Rigidbody2D> ();


	}
	
	

	void OnCollisionEnter2D(Collision2D collision){
		Score.scoreAmount +=1;
		Destroy(this.gameObject);
	}
}
