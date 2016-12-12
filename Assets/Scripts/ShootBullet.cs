using UnityEngine;
using System.Collections;

public class ShootBullet : MonoBehaviour {


    public GameObject prefab;
   
    // Update is called once per frame
    void Update () {

        if (Input.GetMouseButtonDown(2))
        {

            GameObject projectile = Instantiate(prefab) as GameObject;
            projectile.transform.position = transform.position + Camera.main.transform.forward * 2;
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * 20;
        }
	
	}
}
