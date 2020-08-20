using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour {
	private float update;
	public Vector2 velocidadeBola;

	// Usado para inciar
	void Start () {
		//Aki recupera-se infos do rigidbody da bola
		Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
		//Damos o primeiro empurrão na bolinha adicionando força.
		//Usa-se um vetor de 2 posições x e y
		rigidbody.AddForce(velocidadeBola);
	}
	void Update()
    {
        update += Time.deltaTime;
        if (update > 1.0f)
        {
            update = 0.0f;
			
            Debug.Log(velocidadeBola);
        }

    }
	

}
