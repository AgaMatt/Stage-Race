using UnityEngine;
using System.Collections;

public class CarredMy : MonoBehaviour
{
	public float velocidade = 3000;
	public float re = 1800;
	public float rotacaovolante = 100;
	//float curva = 1000;
	bool mov = false;

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		acelerar ();
	}

	void acelerar ()
	{
		//Acelerar
		if (Input.GetKey ("up")) {
			GetComponent<Rigidbody2D> ().AddForce (transform.up * -velocidade);
			mov = true;
		}
		if (Input.GetKeyUp ("up")) {
			
			mov = false;
		}
		//Ré
		if (Input.GetKey ("down")) {
			GetComponent<Rigidbody2D> ().AddForce (transform.up * re);
			mov = true;
		}
		if (Input.GetKeyUp ("down")) {
			mov = false;
		}
		//Virar esquerda
		if (Input.GetKey ("left") && mov == true) {
			//	GetComponent<Rigidbody2D> ().transform.Rotate = new Vector2 (0, 45);
			//	transform.eulerAngles = new Vector3 (0, 0, (transform.eulerAngles.z + 1) * Time.deltaTime * 10);
			transform.Rotate (new Vector3 (0, 0, rotacaovolante) * Time.deltaTime);


		}
		/* if (Input.GetKeyUp ("left") && mov == true) {

			velocidade = velocidade + curva;

		}
		if (Input.GetKeyDown ("left") && mov == true) {

			velocidade = velocidade - curva;

		}
		*/

		//Virar direita
		if (Input.GetKey ("right") && mov == true) {
			//GetComponent<Rigidbody2D> ().AddForce (new Vector2 (1, 0) * velocidade);
			//transform.eulerAngles = new Vector3 (0, 0, 45);
			transform.Rotate (new Vector3 (0, 0, -rotacaovolante) * Time.deltaTime);
		}
		/*if (Input.GetKeyDown ("right") && mov == true) {

			velocidade = velocidade + curva;

		}
		if (Input.GetKeyUp ("right") && mov == true) {

			velocidade = velocidade + curva;

		}
		*/

	}


}