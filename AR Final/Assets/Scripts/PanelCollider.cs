using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelCollider : MonoBehaviour {
	public bool isTracking = false;
	public LayerMask layerMask;
	public GameObject panelToMyRight;
	public GameObject panelToMyLeft;
	// public GameObject somePanel_1;
	// public GameObject
	public List<PanelCollider> panels = new List<PanelCollider>();
	public PanelManager panelManager;
	// Use this for initialization
	public Vector3[] panelDirections = new Vector3[3];
	// public float[] anglesToLeft = new float [3];
	public float[] anglesToRight = new float[3];
	public float[] distanceToRight = new float[3];
	public float[] distanceToLeft = new float[3];
	void Start () {
 		// panels.AddRange(FindObjectsOfType<PanelCollider>());
		// if(panels.Contains(this.gameObject.GetComponent<PanelCollider>())){
		// 	panels.Remove(this.gameObject.GetComponent<PanelCollider>());
		// 	Debug.Log(panels.Count);
		// }
	}
	
	// Update is called once per frame
	void Update () {
		GetNextPanelPosition();	
		AddToTrackedPanels();
	}


	void AddToTrackedPanels(){
		if(isTracking && !panelManager.trackedPanels.Contains(this.gameObject)){
			panelManager.trackedPanels.Add(this.gameObject);
		} else if (!isTracking && panelManager.trackedPanels.Contains(this.gameObject)){
			panelManager.trackedPanels.Remove(this.gameObject);
		}
	}
	void GetNextPanelPosition(){
		// Ray ray_0 = new Ray(transform.position, panelDirections[0]);
		// Ray ray_1 = new Ray(transform.position, panelDirections[1]);
		// Ray ray_2 = new Ray(transform.position, panelDirections[2]);
		// RaycastHit hit_0 = new RaycastHit();
		// RaycastHit hit_1 = new RaycastHit();
		// RaycastHit hit_2 = new RaycastHit();
		// float rayDist = Mathf.Infinity;
		//direction from this panel to other panels
		for (int i = 0; i<3; i++){
			if(panels[i].GetComponent<PanelCollider>().isTracking){
				panelDirections[i] = transform.position - panels[i].transform.position;
				distanceToRight[i] = Vector3.Distance(panels[i].transform.position, transform.position);
				anglesToRight[i] = Vector3.Angle(panelDirections[i], -transform.right);
				// anglesToLeft[i] = Vector3.Angle(panelDirections[i], transform.right);
				if(distanceToRight[i] <= 2f && anglesToRight[i] <= 10f){
					panelToMyRight = panels[i].gameObject;
				} else {
					panelToMyRight = null;
				}
				if(distanceToRight[i] <= 2f && anglesToRight[i] >= 170f){
					panelToMyLeft = panels[i].gameObject;
				} else {
					panelToMyLeft = null;
				}
			} else {
				// panelToMyLeft = null;
				// panelToMyRight = null;
				panelDirections[i] = Vector3.zero;
				distanceToRight[i] = 0;
				anglesToRight[i] = 0;
			}			
		}
		// if(panels[0].GetComponent<PanelCollider>().isTracking){
		// 	panelDirections[0] = transform.position - panels[0].transform.position;
		// 	distanceToRight[0] = Vector3.Distance(panels[0].transform.position, transform.position);
		// 	anglesToRight[0] = Vector3.Angle(panelDirections[0], -transform.right);
		// } else {
		// 	panelDirections[0] = Vector3.zero;
		// 	distanceToRight[0] = 0;
		// 	anglesToRight[0] = 0;
		// }

		// if(panels[1].GetComponent<PanelCollider>().isTracking){
		// 	panelDirections[1] = transform.position - panels[1].transform.position;
		// 	distanceToRight[1] = Vector3.Distance(panels[1].transform.position, transform.position);
		// 	anglesToRight[1] = Vector3.Angle(panelDirections[1], -transform.right);
		// } else {
		// 	panelDirections[1] = Vector3.zero;
		// 	distanceToRight[1] = 0;
		// 	anglesToRight[1] = 0;
		// }

		// if(panels[2].GetComponent<PanelCollider>().isTracking){
		// 	panelDirections[2] = transform.position - panels[1].transform.position;
		// 	distanceToRight[2] = Vector3.Distance(panels[1].transform.position, transform.position);
		// 	anglesToRight[2] = Vector3.Angle(panelDirections[1], -transform.right);
		// } else {
		// 	panelDirections[2] = Vector3.zero;
		// 	distanceToRight[2] = 0;
		// 	anglesToRight[2] = 0;
		// }

	

		// for(int i = 0; i<panels.Count-1; i++){
			// Ray ray_0 = new Ray(transform.position, panelDirections[0]);
			// Ray ray_1 = new Ray(transform.position, panelDirections[1]);
			// Ray ray_2 = new Ray(transform.position, panelDirections[2]);
			// RaycastHit hit_1 = new RaycastHit();
			// RaycastHit hit_2 = new RaycastHit();
			// RaycastHit hit_3 = new RaycastHit();
			// RaycastHit hit_4 = new RaycastHit();
			// float rayDist = Mathf.Infinity;
			// panelDirections[i] = panels[i].transform.position - transform.position;
			// anglesToRight[i] = Vector3.Angle(panelDirections[i], transform.right);
			// // Debug.Log(anglesToRight[i]);
			// Debug.DrawRay(transform.position * 10f, panelDirections[i], Color.red);
			// if(anglesToRight[i] <= 10f){
			// 	Debug.Log("Hey, something's to your right!");
			// }
		// }
		// Vector3 dirTo_1 = panels[0].transform.position - transform.position;
		// Vector3 dirTo_2 = panels[1].transform.position - transform.position;
		// Vector3 dirTo_3 = panels[2].transform.position - transform.position;
		// float angleToSomePanel_1 = Vector3.Angle(dirTo_1, transform.right);
		// float angleToSomePanel_2 = Vector3.Angle(dirTo_2, transform.right);
		// float distanceToRightPanel = Vector3.Distance(transform.position,) 
		// Ray ray = new Ray(transform.position, dirTo_1);
	}

	

}
