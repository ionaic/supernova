using UnityEngine;
using System.Collections;

public class playerControl : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("a"))
		{
			print("Left Key");
			transform.Translate(Vector3.left*Time.deltaTime);
			
		}
		else if(Input.GetKeyDown("d"))
		{
			print("Right Key");
			transform.Translate(Vector3.right*Time.deltaTime);
		}
		else if(Input.GetKeyDown("s"))
		{
			print("push off");
			transform.Translate(Vector3.up*Time.deltaTime);
		}
		if(Input.GetKeyDown("space"))
		{
			print("shoot");
		}
	}
}
