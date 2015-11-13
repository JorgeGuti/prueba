using UnityEngine;
using System.Collections;

public class movimiento : MonoBehaviour {

	public float fuerza = 200f;
	public float velocidad_pollo = 5f;
	Rigidbody2D rg; //Esto es para usar el rigidbody del objeto
	Vector3 mira_izquierda = new Vector3(1,1,1);
	Vector3 mira_derecha = new Vector3 (-1,1,1);
		// Use this for initialization
	void Start () {
		rg = GetComponent<Rigidbody2D> ();// Cargamos el rigidbody dentro de
	}
	
	// Update is called once per frame
	void Update () {
		//si pulsamos espacio saltamos
		Vector2 velocidad = GetComponent<Rigidbody2D>().velocity; 
		Debug.DrawLine(transform.position,
		               new Vector3(transform.position.x + velocidad.x,
		            transform.position.y + velocidad.y,
		            transform.position.z));
	

		if(Input.GetKeyDown(KeyCode.Space)){
			salto ();
			}
		if (Input.GetKeyDown (KeyCode.A)) {
			mueve_izquierda ();
				}
		if(Input.GetKeyDown(KeyCode.D)) {
			mueve_derecha();
		}
	
	}


	/*Funcion salto
	 * Aplica una fuerza al objeto con fuerza: fuerza
	 */

	void salto(){
				Debug.Log ("Salta");
				rg.AddForce (new Vector2 (0, fuerza)); // Añadimos una fuerza

		}

	void mueve_derecha(){
		transform.localScale = mira_derecha;
		rg.AddForce(new Vector2(velocidad_pollo,0));


	}

	void mueve_izquierda(){
		transform.localScale = mira_izquierda;
		rg.AddForce(new Vector2(-velocidad_pollo,0));
		}
}
