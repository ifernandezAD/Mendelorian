using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerCollectibleBehaviour : MonoBehaviour
{
    [SerializeField]
    GameObject[] pea;

    public Transform peaSpawnLocation;
    [SerializeField] private float reactivationTime;

    [SerializeField] BoxCollider myCollider;
    [SerializeField] MeshRenderer myRenderer;

    private void Awake()
    {
        myCollider = GetComponent<BoxCollider>();
        myRenderer = GetComponent<MeshRenderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SpawnPea();
            StartCoroutine("FlowerReactivation");
        }
    }

    private void SpawnPea()
    {
        int randomPea = Random.Range(0, 11);
        Instantiate(pea[randomPea], peaSpawnLocation.position, peaSpawnLocation.rotation);
    }

    IEnumerator FlowerReactivation()
    {
        myCollider.enabled = false;
        myRenderer.enabled = false;
        yield return new WaitForSeconds(reactivationTime);
        myCollider.enabled = true;
        myRenderer.enabled = true;
    }

}
