using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ButtonClick : MonoBehaviour {
	public string sceneName;

	public Button button;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Button btn = button.GetComponent<Button>();
		btn.onClick.AddListener(ChangeLevel);
		
	}

	void ChangeLevel(){
		Application.LoadLevel(sceneName);
	}
}
