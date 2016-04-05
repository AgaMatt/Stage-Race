using UnityEngine;
using System.Collections;

public class CarredMy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		acelerar();
	}

	void acelerar(){
		//Acelerar
		if (Input.GetKey("up"))
		{
			GetComponent<Rigidbody2D>().AddForce(new Vector2 (0,1) * 100f);
		}
		//Ré
		if (Input.GetKey ("down")) 
		{
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, 1) * -100f);
		}
		//Virar esquerda
		if (Input.GetKey ("left")) 
		{
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (1, 0) * -100f);

		}
		//Virar direita
		if (Input.GetKey ("right")) 
		{
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (1, 0) * 100f);
			// asdwqeresfdsfergrtwedfasdawe
		}

	}

}
