using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour {

	public float velocidadeJogador = 10.0f;
	public float horizontalAxis;
	public Rigidbody2D rigidBody;


	void Start(){
		rigidBody = GetComponent<Rigidbody2D> ();
	}


	// Update is called once per frame
	void Update () {
		
		horizontalAxis = Input.GetAxis("Horizontal");
		//no eixo x a velociade se altera, ja emm y é constante
		rigidBody.velocity = new Vector2(velocidadeJogador*	horizontalAxis, 0);

	}
}
