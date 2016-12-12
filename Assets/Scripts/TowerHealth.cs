using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TowerHealth : MonoBehaviour {

    public int startingHealth = 100;
    public int currentHealth;
    public Text displayHealth;
    public GameObject player;

     void Awake()
    {
        currentHealth = startingHealth;

        displayHealth.text = ("Health:")+ currentHealth.ToString();

    }


    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            TakeDamage(5);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Spider")
        {
            TakeDamage(3);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Boss")
        {
            Debug.Log("boss");
            TakeDamage(20);
            Destroy(collision.transform.root.gameObject);
        }
    }

    void TakeDamage(int amount)
    {
        currentHealth -= amount;
       
        if (currentHealth <= 0)
        {
            Destroy(player);
        }
    }

    void Update()
    {
        displayHealth.text = ("Health:") + currentHealth.ToString();
    }

}
