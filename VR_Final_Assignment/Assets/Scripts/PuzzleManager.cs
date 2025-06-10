using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleManager : MonoBehaviour
{
    private int placedCount = 0;
    public GameObject winPanel;
    private AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void CubePlacedCorrectly()
    {
        placedCount++;
        if (placedCount >= 3)
        {
            ShowWinScreen();
        }
    }

    void ShowWinScreen()
    {
        if (audioSource) audioSource.Play();  // plays winJingle
        if (winPanel != null)
            winPanel.SetActive(true);
    }

    public void RestartPuzzle()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
