using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SteamVR_TrackedObject))]

public class Gun : MonoBehaviour {

    // The Bullet
    public GameObject bulletPrefab;
    public GameObject spawnPoint;

    public float bulletSpeed = 5f;

    SteamVR_TrackedObject trackedObj;
    SteamVR_Controller.Device device;

    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    // Update is called once per frame
    void Update () {
        //If Controller Trigger is touched down not held
        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            Fire();
        }
	}

    //Sets device parameter relative to real time physics updates
    void FixedUpdate() {
        device = SteamVR_Controller.Input((int)trackedObj.index);
    }

    void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation) as GameObject;
        bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * bulletSpeed);
    }
}
