using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {


	public static int ponto; 
	public static Score instance;
	// Use this for initialization


	void Awake()
	{
		instance = this;
	}


	void Start () {
	
		guiText.text = "Pontos:   " + ponto;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SomarPonto(int _ponto)
	{
		ponto += _ponto;
		guiText.text = "Pontos:   " + ponto;

	}

	public void TirarPonto(int _ponto)
	{
		ponto -= _ponto;
		guiText.text = "Pontos:   " + ponto;
		
	}

	public static void Inicializar()
	{
		ponto = 0;
	}



}
