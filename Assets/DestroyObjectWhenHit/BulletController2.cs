using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController2 : MonoBehaviour {


	void OnTriggerEnter(Collider c){
		if (c.GetComponent<Collider>().tag == "Enemy") {
			Destroy(c.gameObject);
		}
	}
}
