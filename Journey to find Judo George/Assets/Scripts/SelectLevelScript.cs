using UnityEngine;
using System.Collections;

public class SelectLevelScript : MonoBehaviour {
	
	public Transform level1;
	public Transform level2;
	
	bool isTriggered = false;
	string levelSelect;
	
	Color badColor = new Color(150,0,0,0.4f);
	// Use this for initialization
	void Start () {
	
		level1.renderer.enabled = false;
		level2.renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (isTriggered == true) 
		{			
			if (Input.GetKey (KeyCode.Return)) 
			{				
				
				switch(levelSelect)
				{
				case "Level1":
					Application.LoadLevel("OpeningScene");
					break;
				case "Level2":
					Application.LoadLevel ("Level2");
					break;
				case "Level3":
					Application.LoadLevel("Level3");
					break;
				case "Level4":
					Application.LoadLevel ("Level4");
					break;
				case "Level5":
					Application.LoadLevel("Level5");
					break;				
					
				}
			}
		}
		
	
	}
	
	void OnTriggerEnter(Collider other)
	{
		isTriggered = true;
		other.renderer.material.color = Color.red;
		levelSelect = other.gameObject.tag.ToString();
	}

	void OnTriggerExit(Collider other)
	{
		other.renderer.material.color = badColor;
	}
	
	void OnMouseDown()
	{
		if(gameObject.tag == "level1")
		{
			Application.LoadLevel("TheClassroom");
		}
		
		else if(gameObject.tag == "level2")
		{
			Application.LoadLevel("TheClassroom");
		}
		
	}
	
	void OnMouseEnter()
	{
		
		if(gameObject.tag == "level1")
		{
			level1.renderer.enabled = true;
		renderer.material.color = badColor;
		}
		else if(gameObject.tag == "level2")
		{
			level2.renderer.enabled = true;
		renderer.material.color = badColor;
		}
	}
	void OnMouseExit()
	{
		level1.renderer.enabled = false;
		level2.renderer.enabled = false;
	}
}