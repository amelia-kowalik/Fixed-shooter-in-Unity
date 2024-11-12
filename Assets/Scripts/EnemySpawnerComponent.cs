using UnityEngine;

public class EnemySpawnerComponent : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject enemyPrefab;
    
    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy),1f,1.5f);
    }

   private void SpawnEnemy(){
        int randomIndex = Random.Range(0,spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];

        GameObject spawnedEnemy = Instantiate(enemyPrefab,spawnPoint.position,Quaternion.identity);
        spawnedEnemy.transform.rotation = Quaternion.Euler(0,-90,0);


        Vector3 enemyDirection = spawnedEnemy.transform.forward * 3f;
        spawnedEnemy.GetComponent<Rigidbody>().AddForce(enemyDirection, ForceMode.Impulse);

   }
}
