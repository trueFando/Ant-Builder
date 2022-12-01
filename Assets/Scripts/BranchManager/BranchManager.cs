using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BranchManager : MonoBehaviour
{
    private int branchLeft;
    private int branchCarried;
    private int branchCollected;

    [SerializeField] private Text branchLeftText;
    [SerializeField] private Text branchCarriedText;
    [SerializeField] private Text branchCollectedText;

    [SerializeField] private GameObject menu;

    private void Start()
    {
        branchLeft = FindObjectsOfType<Branch>().Length;
        branchLeftText.text = branchLeft.ToString();
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void PickUpBranch()
    {
        branchLeft--;
        branchCarried++;

        branchCarriedText.text = branchCarried.ToString();
        branchLeftText.text = branchLeft.ToString();
    }

    public void LeaveBranch()
    {
        branchCollected += branchCarried;
        branchCarried = 0;

        branchCollectedText.text = branchCollected.ToString();
        branchCarriedText.text = branchCarried.ToString();

        if (branchLeft == 0)
        {
            Time.timeScale = 0f; // остановить игру
            ShowMenu(); // вывести меню
        }
    }

    private void ShowMenu()
    {
        menu.SetActive(true);
    }
}
