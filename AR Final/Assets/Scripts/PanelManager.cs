using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour {

	// public float panel_1_xPos;
	// public float panel_2_xPos;
	// public float panel_3_xPos;
	// public float panel_4_xPos;
	public TextMesh[] numbers;
	public GameObject panel_1;
	public GameObject panel_2;
	public GameObject panel_3;
	public GameObject panel_4;

	private ComicStrip comicStrip;

	public List<Panel> panels = new List<Panel>();
	public List<TextMesh> speechBubbles = new List<TextMesh>();
	public List<GameObject> trackedPanels = new List<GameObject>();

	// Use this f initialization = new List<Panels>()
	void Start () {
		comicStrip = new ComicStrip();
	}

	void Update(){
		if(trackedPanels.Count == 4){
			// FindLeftmostTrackedPanel();
			UpdatePanelOrder();
			GetTextFromPermutation();
		} else {
			panel_1 = null;
			panel_2 = null;
			panel_3 = null;
			panel_4 = null;
			for(int i = 0; i<3; i++){
				panels[0].speechText.text = "";
			}
		}
		//find position of comic panel in relation to camera
	
	}

	private string CreateKey(int _1, int _2, int _3, int _4){
		string key = _1.ToString() + _2.ToString() + _3.ToString() + _4.ToString();
		return key;
	}
	public void GetTextFromPermutation(){
		//  CreateKey(panels[0].myNum, panels[1].myNum, panels[2].myNum, panels[3].myNum);
		panels[0].speechText.text = comicStrip.comics[CreateKey(panels[0].myNum, panels[1].myNum, panels[2].myNum, panels[3].myNum)].string_1;
		panels[1].speechText.text = comicStrip.comics[CreateKey(panels[0].myNum, panels[1].myNum, panels[2].myNum, panels[3].myNum)].string_2;
		panels[2].speechText.text = comicStrip.comics[CreateKey(panels[0].myNum, panels[1].myNum, panels[2].myNum, panels[3].myNum)].string_3;
		panels[3].speechText.text = comicStrip.comics[CreateKey(panels[0].myNum, panels[1].myNum, panels[2].myNum, panels[3].myNum)].string_4;
	}

	void UpdatePanelOrder(){
		for (int i = 0; i < panels.Count; i++) {
            for (int j = i+1; j < panels.Count; j++) {
                if ( (panels[i].transform.position.x > panels[j].transform.position.x) && (i != j) ) {
					Panel tempGameObject;
					tempGameObject = panels[j];
					panels[j] = panels[i];
					panels[i] = tempGameObject;
                }
            }

			// nearestDropzone = dropzoneArray[0];
			// nearestDropzone.GetComponent<DropzoneManager>().RevealNearestDropzone();         
			// if(!dropzoneArray[i].GetComponent<DropzoneManager>().isOccupied){
			// 	nearestDropzone = dropzoneArray[0];
			// } else { 
			// 	nearestDropzone = dropzoneArray[i];
			// 	break;
			// }
			// if(nearestDropzone.GetComponent<DropzoneManager>().isOccupied)
			// 	nearestDropzone = dropzoneArray[i];
			// 	break;
		}
	}
	void FindLeftmostTrackedPanel(){
		for (int i = 0; i<3; i++){
			GameObject _leftMost = trackedPanels[0];
			// float shortestDist = 
			if(trackedPanels[i].transform.position.x < trackedPanels[0].transform.position.x){
				panel_1 = trackedPanels[i];
			}
			// if(trackedPanels[i].GetComponent<PanelCollider>().panelToMyLeft == null && trackedPanels[i].GetComponent<PanelCollider>().panelToMyLeft != null){
			// 	panel_1 = trackedPanels[i];
			// 	numbers[0].transform.position = panel_1.transform.position;
			// 	if(trackedPanels[i].GetComponent<PanelCollider>().panelToMyLeft == panel_1 ){
			// 		panel_2 = trackedPanels[i];
			// 		numbers[1].transform.position = panel_2.transform.position;
			// 	}
			// } 
			// if(trackedPanels[i].GetComponent<PanelCollider>().panelToMyLeft != null && trackedPanels[i].GetComponent<PanelCollider>().panelToMyLeft == null){
			// 	panel_4 = trackedPanels[i];
			// 	numbers[3].transform.position = panel_4.transform.position;
			// 	if(trackedPanels[i].GetComponent<PanelCollider>().panelToMyLeft == panel_4 && trackedPanels[i].GetComponent<PanelCollider>().panelToMyLeft == panel_2){
			// 		panel_3 = trackedPanels[i]; 
			// 		numbers[2].transform.position = panel_3.transform.position;
			// 	}
			// } 			
		}
	} 
	
	private void AddSpeechToSpeechBubbles(string speech_1, string speech_2, string speech_3, string speech_4){
		
	}
	// Update is called once per frame

}
