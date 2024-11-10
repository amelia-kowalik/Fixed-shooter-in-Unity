using UnityEngine;

public class ShootingComponent : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float bulletSpeed;
    public float timeToDestroy;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            GameObject spawnedBullet = Instantiate(bulletPrefab,bulletSpawn.position,Quaternion.identity);
            Vector3 bulletDirection = spawnedBullet.transform.right * bulletSpeed;
            spawnedBullet.GetComponent<Rigidbody>().AddForce(bulletDirection,ForceMode.Impulse);

            Destroy(spawnedBullet,timeToDestroy);
        }
    }
}
