using UnityEngine;
using System.Collections;

public class Letra : MonoBehaviour {


	public int ponto = 2;
	public float tempoMaximoVida;
	public float tempoVida;

	private Vidas vida;
	private Score score;
    private Gerenciador gerenciador;



    // Use this for initialization
    void Start () {
	
		score = GameObject.FindGameObjectWithTag("Pontos").GetComponent<Score>() as Score;
        gerenciador = FindObjectOfType(typeof(Gerenciador)) as Gerenciador;


    }
	
	// Update is called once per frame
	void Update () {
	
	
		tempoVida += Time.deltaTime;
		if (tempoVida >= tempoMaximoVida) {
				
			Destroy(gameObject);
			tempoVida = 0;
		
		}


	}


	void OnCollisionEnter2D(Collision2D colisor)
	{

		if(colisor.gameObject.tag == "Player"){

			vida = GameObject.FindGameObjectWithTag("Vidas").GetComponent<Vidas>() as Vidas;

			if(vida.ExcluirVida()){
			
				score.TirarPonto(ponto);
				Destroy (gameObject);
			
			
			}else
			{

				gerenciador.GameOver("GameOver");

			}
		}
	}

}
