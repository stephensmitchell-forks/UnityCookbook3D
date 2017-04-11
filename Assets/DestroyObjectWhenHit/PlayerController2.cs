using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
	public GameObject bulletPrefab;
	public Transform bulletSpawn;
	private Vector3 screenPoint;
	private Vector3 offset;

	void Update()
	{
		// GetMouseButton - fires when left mouse click is pressed
		// GetMouseButtonDown - fires a bullet everytime you do a left click
		if (Input.GetMouseButtonDown(0))
		{
			Fire();
		}

	}

	void Fire()
	{
		// Create the Bullet from the Bullet Prefab
		var bullet = (GameObject)Instantiate(
			bulletPrefab,
			bulletSpawn.position,
			bulletSpawn.rotation);

		// Add velocity to the bullet
		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;

		// Destroy the bullet after 2 seconds
		Destroy(bullet, 1.0f);        
	}

	void OnMouseDown(){
		screenPoint = Camera.main.WorldToScreenPoint (gameObject.transform.position);
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
	}

}