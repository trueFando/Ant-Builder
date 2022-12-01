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
            Destroy(otherObject.gameObject); // ������� ����� �� �����
            branchCounter.AddBranch(); // ��������� ���������� �����
            branchManager.PickUpBranch(); // �������� ������ ���������
        }

        if (otherObject.gameObject.GetComponent<Anthill>() != null)
        {
            branchManager.LeaveBranch(); // �������� ������ ���������
            // ���������� �����
            for (int i = 0; i < branchCounter.Count; i++)
            {
                branchSpawner.SpawnBranch();
            }

            // �������� ��� �����
            branchCounter.ResetBranches();
        }
    }
}
