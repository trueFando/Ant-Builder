using System.Runtime.CompilerServices;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    [SerializeField] private BranchCounter branchCounter;
    [SerializeField] private BranchSpawner branchSpawner;
    [SerializeField] private BranchManager branchManager;
    private void OnTriggerEnter2D(Collider2D otherObject)
    {
        if (otherObject.gameObject.GetComponent<Branch>() != null)
        {
            Destroy(otherObject.gameObject); // удалить ветку со сцены
            branchCounter.AddBranch(); // посчитать количество веток
            branchManager.PickUpBranch(); // передать данные менеджеру
        }

        if (otherObject.gameObject.GetComponent<Anthill>() != null)
        {
            branchManager.LeaveBranch(); // передать данные менеджеру
            // заспаунить ветки
            for (int i = 0; i < branchCounter.Count; i++)
            {
                branchSpawner.SpawnBranch();
            }

            // сбросить все ветки
            branchCounter.ResetBranches();
        }
    }
}
