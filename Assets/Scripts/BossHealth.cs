using UnityEngine;
using System.Collections;

public class BossHealth : MonoBehaviour {

    public int bossHealth = 100;

	
	
	
	void HitByRay () {

        Debug.Log("hit");
        bossHealth -= 10;

    }

    void Update()
    {
        if (bossHealth <= 0)
        {
            Debug.Log("boss died");
            Destroy(transform.root.gameObject);
        }
    }
}
