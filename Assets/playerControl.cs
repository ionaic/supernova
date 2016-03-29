using UnityEngine;
using System.Collections;

public class playerControl : MonoBehaviour {
	
	public GameObject bullet = null;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//move circle around
		if(Input.GetKeyDown("a"))
		{
			print("Left Key");
			transform.Translate(Vector3.left*Time.deltaTime*10);
			
		}
		else if(Input.GetKeyDown("d"))
		{
			print("Right Key");
			transform.Translate(Vector3.right*Time.deltaTime*10);
		}
		//shoot
		else if (Input.GetMouseButtonDown(1)){
			print("fire coordinates: " + Input.mousePosition); //right click
			print("Player Position: " + GameObject.Find("playerCharacter").transform.position); //get player sphere position
			//spawn particle at player sphere
			bullet = Instantiate(Resources.Load("prefabAmmo"), new Vector3(1,2,3), Quaternion.identity) as GameObject;
			//calculate path for particle
			//spawn particle along path
		}
	}
}
