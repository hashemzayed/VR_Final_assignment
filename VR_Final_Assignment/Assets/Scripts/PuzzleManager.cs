using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleManager : MonoBehaviour
{
    private int placedCount = 0;
    public GameObject winPanel;

    public void CubePlacedCorrectly()
    {
        placedCount++;
        Debug.Log("Placed Count: " + placedCount);

        if (placedCount >= 3)
        {
            Debug.Log("Puzzle Completed!");
            ShowWinScreen();
        }
    }

    void ShowWinScreen()
    {
        Debug.Log("Activating Win Panel");
        if (winPanel != null)
            winPanel.SetActive(true);
    }

    public void RestartPuzzle()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
