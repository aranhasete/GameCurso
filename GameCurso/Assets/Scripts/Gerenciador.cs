using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Gerenciador : MonoBehaviour {


	public Vector2 posicaoInicialPlayer;
	public Transform player;
	public int levelAtual;
	public int proximoLevel;
	public int quantidadeColetada = 0;
	private int quantidadeMaxima ;



	// Use this for initialization
	void Awake () {
	
		if (player != null) {

			posicaoInicialPlayer = player.position;
		}

		quantidadeMaxima = 5;
	}
	


	public bool IsColetado()
	{

		if (quantidadeColetada >= quantidadeMaxima) {
				
						return true;
				} else {
				
			return false;
		}
	}

	public void StartGame()
	{
		player.position = posicaoInicialPlayer;
	}

	public void GameOver(string nome)
	{
        //#pragma warning disable CS0618 // O tipo ou membro é obsoleto
        //		Application.LoadLevel (nome);
        //#pragma warning restore CS0618 // O tipo ou membro é obsoleto
        SceneManager.LoadScene(nome);
    }


	public void AddQuantidade(int quantidade)
	{
		quantidadeColetada += quantidade;
	}

	public void ProximoLevel(int level)
	{
        //#pragma warning disable CS0618 // O tipo ou membro é obsoleto
        //		Application.LoadLevel (level);
        //#pragma warning restore CS0618 // O tipo ou membro é obsoleto
        SceneManager.LoadScene(level);
    }
}
