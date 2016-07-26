using UnityEngine;
using System.Collections;

public class Vidas : MonoBehaviour {


    public Texture2D[] textureVida;
    private int vidas;
    public int vidasAtual;

    // Use this for initialization
    void Start()
    {
        GetComponent<GUITexture>().texture = textureVida[0];
        vidas = textureVida.Length - 1;
        vidasAtual = vidas;

    }

    // Update is called once per frame
    void Update()
    {

    }


    public bool ExcluirVida()
    {
        if (vidasAtual == 0)
        {
            return false;

        }
        else
        {
            vidasAtual--;
            var idTextura = vidas - vidasAtual;
            GetComponent<GUITexture>().texture = textureVida[idTextura];
            return true;

        }
    }
}
