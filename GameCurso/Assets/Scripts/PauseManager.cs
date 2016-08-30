using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Audio;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class PauseManager : MonoBehaviour {
	
	Canvas canvas;
    Resolution[] resolutions;
    Dropdown dropdownResolucao;
    Toggle windowsMode;

    void Start()
	{
		canvas = GetComponent<Canvas>();
        canvas.enabled = false;

        resolutions = Screen.resolutions;
        dropdownResolucao = GameObject.Find("ResolucaoDropdown").GetComponent<Dropdown>();
        windowsMode = GameObject.Find("WindowsModeToggle").GetComponent<Toggle>();

        dropdownResolucao.options.Clear();
        foreach (Resolution res in resolutions)
        {
            //print(res.width + "x" + res.height);
            Debug.Log(res.width + "x" + res.height);
            dropdownResolucao.options.Add(new Dropdown.OptionData(res.width + "x" + res.height));
        }

    }

    void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Pause();
		}

        Screen.SetResolution(resolutions[dropdownResolucao.value].width, resolutions[dropdownResolucao.value].height, !windowsMode.isOn);
    }
	
	public void Pause()
	{
        canvas.enabled = !canvas.enabled;
        Time.timeScale = Time.timeScale == 0 ? 1 : 0;
    }

    public void Quit()
	{
		#if UNITY_EDITOR 
		EditorApplication.isPlaying = false;
		#else 
		Application.Quit();
		#endif
	}
}
