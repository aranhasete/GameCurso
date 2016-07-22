using UnityEngine;
using System.Collections;

public class Mouse : MonoBehaviour {


	void OnMouseDown()
	{
		Debug.Log("Mouse foi clicado por:" + this.name);
	}
	void OnMouseUp()
	{
		Debug.Log("Mouse esta UP:" + this.name);
	}
}
