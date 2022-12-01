using UnityEngine;

public class BranchCounter : MonoBehaviour
{
    private int count = 0;

    public int Count => count;

    public void AddBranch()
    {
        count++;
    }

    public void ResetBranches()
    {
        count = 0;
    }
}
