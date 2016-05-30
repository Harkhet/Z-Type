using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider co)
    {
        HealthBar health = co.GetComponentInChildren<HealthBar>();

        if (health)
        {
            if (co.name == "Head")
            {
                health.headSHot();
            }
            else
            {

                health.decrease();
                Destroy(gameObject);
            }
        }
    }
}
