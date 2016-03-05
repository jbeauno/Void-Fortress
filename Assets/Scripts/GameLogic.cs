using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameLogic : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}


public class Sector {
	public List<Sector> Sectors;
	public string Name;
	GameObject objSect;


	public Sector(string name="noname") {
		Sectors = new List<Sector> ();
		Name = name;
		//spawn object
		objSect = new GameObject("Cool GameObject made from Code");
		//Add Components
		objSect.AddComponent<MeshFilter>();
		objSect.AddComponent<BoxCollider>();
		objSect.AddComponent<MeshRenderer>();
		//objSect.GetComponent<MeshFilter>().mesh.

	}
}