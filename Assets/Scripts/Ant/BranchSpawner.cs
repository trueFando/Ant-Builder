using UnityEngine;

public class BranchSpawner : MonoBehaviour
{
    [SerializeField] private GameObject branch;
    [SerializeField] private Transform anthill;
    
    public void SpawnBranch()
    {
        Vector3 rotation = new Vector3(0, 0, Random.Range(0f, 360f));
        GameObject newBranch = Instantiate(branch, anthill.position, Quaternion.Euler(rotation));
        Destroy(newBranch.GetComponent<Branch>());
    }
}
