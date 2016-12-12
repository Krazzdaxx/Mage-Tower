using UnityEngine;
using System.Collections;

public class GrenadeExplosion : MonoBehaviour {

    private Collider[] hitColliders;
    private float destroyTime = 2.0f;
    public float blastRadius;
    public float explosionPower;
    public LayerMask explosionLayers;

	void OnCollisionEnter(Collision col)
    {
       // Debug.Log(col.contacts[0].point.ToString());
        ExplosionWork(col.contacts[0].point);
        Destroy(gameObject, 0.1f);
    }

    void ExplosionWork(Vector3 explosionPoint)
    {
        hitColliders = Physics.OverlapSphere(explosionPoint, blastRadius, explosionLayers);

        foreach (Collider hitCol in hitColliders)
        {
            if(hitCol.GetComponent<NavMeshAgent>() != null && hitCol.CompareTag("Spider"))
            {
                hitCol.GetComponent<NavMeshAgent>().enabled = false;
            } 

            if(hitCol.GetComponent<Rigidbody>() != null && hitCol.CompareTag("Spider"))
            {
                hitCol.GetComponent<Rigidbody>().isKinematic = false;
                hitCol.GetComponent<Rigidbody>().AddExplosionForce(explosionPower, explosionPoint, blastRadius, 1, ForceMode.Impulse);
            }

            if (hitCol.CompareTag("Spider")|| hitCol.CompareTag("Cube"))
            {
                Destroy(hitCol.gameObject, destroyTime);
            }
        }
    }
}
