using UnityEngine;
using System.Collections;

public class GameCore : MonoBehaviour {

	Sector RootSector;

	// Use this for initialization
	void Start () {
		Sector sect;
		RootSector = new Sector ("First");
		sect = new Sector ("Andromeda");
		RootSector.Sectors.Add (sect);
		sect = new Sector ("MilkyWay");
		RootSector.Sectors.Add (sect);
		foreach (Sector s in RootSector.Sectors) {
			print ("hello" + s.Name);
			//s.
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
