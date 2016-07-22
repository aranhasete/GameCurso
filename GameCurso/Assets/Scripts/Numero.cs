using UnityEngine;
using System.Collections;

public class Numero : MonoBehaviour {


	private int ponto = 10;
	public AudioClip clip;
	private float timeVida;
	public 	float tempoMaximoVida;
	private Score score;

	private Gerenciador gerenciador;
	void Awake()
	{
		score = GameObject.FindGameObjectWithTag("Pontos").GetComponent<Score>() as Score;
		gerenciador = FindObjectOfType (typeof(Gerenciador)) as Gerenciador;
	}

	// Use this for initialization
	void Start () {
	
		timeVida = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
		timeVida += Time.deltaTime;
		if (timeVida >= tempoMaximoVida) {
				
			Destroy(gameObject);
			timeVida = 0;
		}

	}

	void OnCollisionEnter2D(Collision2D colisor)
	{
		if (colisor.gameObject.tag == "Player") {

			score.SomarPonto(ponto);
			gerenciador.AddQuantidade(1);
			Destroy(gameObject);
		
		}

	}
}
