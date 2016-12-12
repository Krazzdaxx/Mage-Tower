using UnityEngine;
using System.Collections;

public class RaycastShooting : MonoBehaviour
{
  
    
    public float damage = 100;
   

    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0)) //if the left mouse button is pressed do ....
        {

            if (Physics.Raycast(ray, out hit, 200)) //if a game object is in front of player but within 200 units of it trigger a hit
            {
               
                if (hit.collider.tag == "Enemy")
                {
                    Destroy(hit.collider.gameObject);
                }
                if (hit.collider.tag == "BossHead")
                {
                    hit.transform.SendMessage("HitByRay");
                    //Destroy(hit.collider.transform.root.gameObject);
                }
            }
        }
    }
}

