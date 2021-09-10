using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            TileManager.Instance.SpawnTile();
            StartCoroutine(FallDown());
        }
    }

    IEnumerator FallDown()
    {
        yield return new WaitForSeconds(1.3f);
        GetComponent<Rigidbody>().isKinematic = false;

        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
