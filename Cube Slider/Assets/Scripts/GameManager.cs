using UnityEngine;
using UnityEngine.SceneManagement; // Whene ever we need to change from deffirent scenes or reload the current scene

public class GameManager : MonoBehaviour
{
	bool gameHasEnded = false;
	public GameObject completeLevelUI;
	public void EndGame()
	{
		if (!gameHasEnded)
		{
			gameHasEnded = true;
			Invoke("Restart", 1f);
		}
	}
	void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
	public void CompleteLevel()
	{
		completeLevelUI.SetActive(true);
	}
}
