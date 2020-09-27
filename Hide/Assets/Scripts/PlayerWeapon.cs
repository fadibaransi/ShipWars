using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour {

    public GameObject bulletPrefab;
    public Transform bulletDirection;
    public float bulletSpeed;
    public float bulletLifeTime;
    public GameObject Player;
    public GameObject Enemy;
    public float bulletsDelay;
	// Use this for initialization
	void Start () {
        if (Enemy)
        {

            InvokeRepeating("Fire", 2.0f, 4f);
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (Player)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Fire();
            }
        }
        
    }

    private void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab);

        Physics.IgnoreCollision(bullet.GetComponent<Collider>(), bulletDirection.parent.GetComponent<Collider>());
        bullet.transform.position = bulletDirection.position;
        Vector3 rotation = bullet.transform.rotation.eulerAngles;

        bullet.transform.rotation = Quaternion.Euler(rotation.x, transform.eulerAngles.y, rotation.z);

        bullet.GetComponent<Rigidbody>().AddForce(bulletDirection.forward * bulletSpeed, ForceMode.Impulse);

        StartCoroutine(DestroyBilletAfterTime(bullet, bulletLifeTime));
    }
    private IEnumerator DestroyBilletAfterTime(GameObject bullett,float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(bullett);
    }
	
}
