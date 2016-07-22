using UnityEngine;
using System.Collections;

public class Killer : MonoBehaviour {


	private Vidas vida;
	private Gerenciador gerenciador;


	// Use this for initialization
	void Start () {
	
		gerenciador = FindObjectOfType (typeof(Gerenciador)) as Gerenciador;
	}
	

	void OnTriggerEnter2D(Collider2D colisor)
	{
		if (colisor.gameObject.tag == "Player") {
		
			vida  = GameObject.FindGameObjectWithTag("Vidas").GetComponent<Vidas>() as Vidas;
		
			if(vida.ExcluirVida()){


				gerenciador.StartGame();
				gerenciador.quantidadeColetada = 0;
			}
			else
			{

				gerenciador.GameOver("GameOver");
			}
		
		}

	}


}
