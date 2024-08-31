using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int playerHealth = 85;
    public GameObject healthItemPrefub;

    private Vector3 _position;
 

    void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("HealthPack"))
        {

            if (playerHealth > 0 && playerHealth < 100)
            {
                playerHealth += 10;
                if (playerHealth > 100)
                {
                    playerHealth = 100;
                }
                Destroy(other.gameObject);
            }
        } 
    }

    private void Update() 
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {   
            _position = new Vector3(Random.Range(-10.0f, 10.0f), 1.5f, Random.Range(-10.0f, 10.0f));
            Instantiate(healthItemPrefub, _position, Quaternion.identity);
        }   

    }
}
