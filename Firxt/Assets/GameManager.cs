
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    bool GameHasEnded = false;
    public GameObject CompleteLevelUI;
    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
    }



     public void EndGame()
    {
        if(GameHasEnded == false)
        {
            GameHasEnded = true;
            Invoke("Restart", 1f);
            Restart();
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
