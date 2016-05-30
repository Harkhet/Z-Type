using UnityEngine;
using System.Collections;

public class Zombie : MonoBehaviour {

    public GameObject target;

    void Start()
    {
        target = GameObject.Find("[CameraRig]");

        if (target)
            GetComponent<NavMeshAgent>().destination = target.transform.position;
    }
}
