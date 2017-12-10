using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour {

	public Panel panel_1;
	public Panel panel_2;

	public Panel panel_3;

	public Panel panel_4;
	public List<Panel> panels = new List<Panel>();
	public List<TextMesh> speechBubbles = new List<TextMesh>();
	public List<GameObject> trackedPanels = new List<GameObject>();

	// Use this f initialization = new List<Panels>()
	void Start () {
	}

	void Update(){
		if(trackedPanels.Count == 4){
			EvaluatePermutation();
		}
	}
	public void EvaluatePermutation(){

	}
	
	private void AddSpeechToSpeechBubbles(string speech_1, string speech_2, string speech_3, string speech_4){
		
	}
	// Update is called once per frame

}
